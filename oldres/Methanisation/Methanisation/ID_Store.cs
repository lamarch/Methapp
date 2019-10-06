using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methanisation
{
    static class ID_Store
    {

        public static int ID_BL = 1;
        public static int ID_EXPL = 1;
        public static int ID_FMR = 1;
        public static int ID_CHF = 1;

        private static string separator = "%-%";

        public enum IDtype
        {
            BL,
            EXPL,
            FMR,
            CHF
        }

        public static string GetID_str(IDtype t)
        {
            switch (t)
            {
                case IDtype.BL:
                    return ID_BL++.ToString("X");
                case IDtype.CHF:
                    return ID_CHF++.ToString("X");
                case IDtype.EXPL:
                    return ID_EXPL++.ToString("X");
                case IDtype.FMR:
                    return ID_FMR++.ToString("X");
                default:
                    return Util.GetRndID();
            }
        }

        public static bool Store()
        {
            string[] res =
            {
                ID_BL.ToString(),
                ID_CHF.ToString(),
                ID_EXPL.ToString(),
                ID_FMR.ToString()
            };

            try
            {
                File.WriteAllText(Ref.PT_ID, string.Join(separator, res));
                return false;
            }
            catch (Exception e)
            {
                Debug.MsgErr("Une erreur est survenue lors de la sauvegarde des id.", "Gx26", e);
                return true;
            }
        }

        public static bool Get()
        {
            bool ret = false;
            string[] res = new string[15];
            try
            {
                res = File.ReadAllText(Ref.PT_ID).Split(separator.ToCharArray(0,separator.Length)).Where(e=>!string.IsNullOrEmpty(e) && !string.IsNullOrWhiteSpace(e)).ToArray();
            }
            catch (Exception e)
            {
                Debug.MsgErr("Une erreur est survenue lors du chargement des id.", "Gx56", e);
                ret = true;
            }

            try
            {
                ID_BL = int.Parse(res[0]);
                ID_CHF = int.Parse(res[1]);
                ID_EXPL = int.Parse(res[2]);
                ID_FMR = int.Parse(res[3]);
            }catch(FormatException e)
            {
                Debug.MsgInfo($"res {string.Join(" - ", res)}");
                Debug.MsgErr("Une erreur est survenue lors de la lecture des id.", "Gx68", e);
                ret = true;
            }
            return ret;
        }
    }
}
