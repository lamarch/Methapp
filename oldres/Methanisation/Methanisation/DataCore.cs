using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methanisation
{
    static class DataCore
    {
        /* Delegates pour l'affichage(MainForm) synchro avec la sauvegarde(DataCore) */

        public delegate void OnSaveStart();
        public delegate void OnSaveStop();

        public static OnSaveStart onSaveStart;
        public static OnSaveStop onSaveStop;

        /* Champs */

        static List<Fumier> fumiers = new List<Fumier>();
        static List<Chauffeur> chauffeurs = new List<Chauffeur>();
        static List<Exploitation> exploitations = new List<Exploitation>();
        static List<BonLivraison> bonLivraisons = new List<BonLivraison>();

        static Serialisateur<List<Fumier>> ser_fum = new Serialisateur<List<Fumier>>("fumiers", Ref.DIR_SAVE);
        static Serialisateur<List<Chauffeur>> ser_chf = new Serialisateur<List<Chauffeur>>("chauffeurs", Ref.DIR_SAVE);
        static Serialisateur<List<Exploitation>> ser_expl = new Serialisateur<List<Exploitation>>("exploitations", Ref.DIR_SAVE);

        static DateTime lastBLModif = DateTime.Now;

        /* "Propriétés" statique */

        public static List<Fumier> Fumiers
        {
            get { return fumiers; }
        }

        public static List<Chauffeur> Chauffeurs
        {
            get { return chauffeurs; }
        }

        public static List<Exploitation> Exploitations
        {
            get { return exploitations; }
        }

        public static List<BonLivraison> BonLivraisons
        {
            get { return bonLivraisons; }
        }

        /* Methodes pour modifier les listes. */

        public static List<Fumier> SetFumiers(List<Fumier> _fumiers)
        {
            fumiers = _fumiers;
            return fumiers;
        }

        public static List<Chauffeur> SetChauffeurs(List<Chauffeur> _chauffeurs)
        {
            chauffeurs = _chauffeurs;
            return chauffeurs;
        }

        public static List<Exploitation> SetExploitations(List<Exploitation> _exploitations)
        {
            exploitations = _exploitations;
            return exploitations;
        }

        /* Methode spéciale  */

        public static List<BonLivraison> AddBonLivraison(BonLivraison bl)
        {
            bonLivraisons.Add(bl);
            return bonLivraisons;
        }

        /* Methodes de sauvegarde */

        public static bool SaveLists()
        {
            //les fameuses delegates
            onSaveStart.Invoke();

            bool res = false;
            if(!ser_chf.Save(chauffeurs))
            {
                Debug.MsgErr($"Il y a eu une erreur lors de la sauvegarde de la liste des chauffeurs.", "Dx74", ser_chf.GetException());
                res = true;
            }

            if(!ser_expl.Save(exploitations))
            {
                Debug.MsgErr($"Il y a eu une erreur lors de la sauvegarde de la liste des exploitations.", "Dx80", ser_expl.GetException());
                res = true;

            }

            if (!ser_fum.Save(fumiers))
            {
                Debug.MsgErr($"Il y a eu une erreur lors de la sauvegarde de la liste des fumiers.", "Dx87", ser_fum.GetException());
                res = true;

            }

            if (!SaveBLs())
            {
                res = true;
            }

            if (!ID_Store.Store())
            {
                res = true;
            }

            //
            onSaveStop.Invoke();
            return res;
        }

        public static bool LoadLists()
        {
            ID_Store.Get();

            chauffeurs = ser_chf.Load(out bool ok_1);
            if (!ok_1)
            {
                Debug.MsgErr($"Il y a eu une erreur lors du chargements de la liste des chauffeurs.", "Dx107", ser_chf.GetException());
            }

            if(chauffeurs == null)
            {
                chauffeurs = new List<Chauffeur>();
            }

            exploitations = ser_expl.Load(out bool ok_2);
            if (!ok_2)
            {
                Debug.MsgErr($"Il y a eu une erreur lors du chargements de la liste des exploitations.", "Dx113", ser_expl.GetException());
            }
            if (exploitations == null)
            {
                exploitations = new List<Exploitation>();
            }

            fumiers = ser_fum.Load(out bool ok_3);
            if (!ok_3)
            {
                Debug.MsgErr($"Il y a eu une erreur lors du chargements de la liste des fumiers.", "Dx119", ser_fum.GetException());
            }
            if (fumiers == null)
            {
                fumiers = new List<Fumier>();
            }

            bonLivraisons = LoadBLs();

            return ok_1 || ok_2 || ok_3;
        }

        static bool SaveBLs()
        {
            bool ret = false;
            foreach (BonLivraison bonLivraison in bonLivraisons)
            {
                Serialisateur<BonLivraison> ser = new Serialisateur<BonLivraison>(bonLivraison.GETID, Ref.DIR_BL);
                if (!ser.Save(bonLivraison))
                {
                    Debug.MsgErr("La sauvegarde du bon de livraison \"" + bonLivraison.GETID + "\" a échouée.", "Dx139", ser.GetException());
                    ret = false;
                }
            }
            bonLivraisons.Clear();
            return ret;
        }

        static List<BonLivraison> LoadBLs()
        {
            List<BonLivraison> bls = new List<BonLivraison>();
            foreach (string f in Directory.GetFiles(Ref.DIR_BL))
            {
                if (File.Exists(f))
                {
                    string[] vs = f.Split('\\','/');
                    string final = vs[vs.Length - 1];
                    final = final.Substring(0, final.Length - 4);
                    Serialisateur<BonLivraison> ser = new Serialisateur<BonLivraison>(final, Ref.DIR_BL);
                    BonLivraison bl = ser.Load(out bool ok);
                    if (ok)
                    {
                        bls.Add(bl);
                    }
                    else
                    {
                        Debug.MsgErr("La récupération du bon de livraison dans le fichier \" " + string.Join("/", vs) + " \" n'a pas été possible, faites attention à ne pas déposer de fichier MANUELLEMENT dans le dossier \" " + Ref.DIR_BL + ".", "Dx165", ser.GetException());
                    }

                }
            }
            return bls;
        }
    }
}
