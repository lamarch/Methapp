using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace Methanisation
{
    public class BonLivraison
    {
        public string Nom;
        string ID;

        //J'avais pas d'idée de nom...
        public string GETID { get => ID; }
        public DateTime LivraisonTime;
        public DateTime CreateTime;
        public Exploitation Exploitation;
        public Fumier Fumier;
        public Chauffeur Chauffeur;

        public string ShortDesc { get => $"#{ID} {Nom} du \" {LivraisonTime.ToShortDateString()} \""; }
        public string LongDesc { get => ShortDesc + $" à \" {LivraisonTime.ToShortTimeString()} \" fait le \" {CreateTime.ToShortDateString()} \" à \" {CreateTime.ToShortTimeString()} \" (exploitation : \" {Exploitation} \" , chauffeur : \" {Chauffeur} \", fumier : \" {Fumier} \")."; }

        public BonLivraison()
        {
            this.Nom = "<nom indéfini>";
            this.ID = ID_Store.GetID_str(ID_Store.IDtype.BL);
        }

        public BonLivraison(string nom, DateTime livraisonTime, DateTime createTime, Exploitation exploitation, Fumier fumier, Chauffeur chauffeur)
        {
            this.Nom = nom;
            this.ID = ID_Store.GetID_str(ID_Store.IDtype.BL);
            this.LivraisonTime = livraisonTime;
            this.CreateTime = createTime;
            this.Exploitation = exploitation;
            this.Fumier = fumier;
            this.Chauffeur = chauffeur;
        }

        public string CreateAnotherID()
        {
            //Si l'id est déjà pris
            //On le remet en décimal
            //On lui ajoute 1
            int val = int.Parse(ID, System.Globalization.NumberStyles.HexNumber) + 1;
            //Et on le reconverti en hexa
            //Et on remplace l'id
            return ID = Util.ToHex(val);
        }

        public static BonLivraison BLFromLWItem(ListViewItem i)
        {
            ListViewSubItemCollection si = i.SubItems;
            return new BonLivraison();
        }

        public static ListViewItem LWItemFromBL(BonLivraison b)
        {
            return new ListViewItem();
        }
    }
}
