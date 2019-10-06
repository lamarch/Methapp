using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation_2
{
    public abstract class UniqueID
    {
        const string _id_FileName = "id.txt";

        static bool _res_init;
        static bool _isInit = false;
        static ulong _id;

        public readonly string ID;

        public UniqueID()
        {
            ID = GenNewID();
        }

        public static string GenNewID()
        {
            Init();
            return _id++.ToString("x");
        }

        public static ulong GetIdFromList(List<UniqueID> iDs)
        {
            //On trie la list
            var sortedId = from id in iDs orderby id.ID select id;
            //Et convertit en ulong
            return ulong.Parse(sortedId.Last().ID, System.Globalization.NumberStyles.HexNumber) + 1;
        }

        public static bool Init()
        {
            //si n'est pas deja initialise
            if (!_isInit)
            {
                _isInit = true;

                //si n'exist ou bien il n'est pas lisible alors on en recréé un et on init l'id autrement
                if (!File.Exists(_id_FileName) || !ulong.TryParse(File.ReadAllText(_id_FileName), out _id))
                {
                    File.Create(_id_FileName).Close();
                    //on prend les ticks
                    _id = (ulong)DateTime.Now.Ticks;
                    _res_init = false;
                }
                else
                    _res_init = true;
            }

            return _res_init;
        }
    }
}
