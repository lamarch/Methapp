using System;
using System.IO;

namespace Methanisation
{
    //Les constantes :

    static class Ref
    {
        /*
         * Les constantes relatives à l'appli :
         */
        public const string APP_NAME = "Methapp";
        public const string APP_VER = "0.057";

        /*
         * Les dossiers :
         */
        public const string DIR_BL = "bons_de_livraisons";
        public const string DIR_CFG = "cfg";
        public const string DIR_LOG = "logs";
        public const string DIR_SAVE = "saves";

        public const string FL_ID = "id.txt";

        public static string PT_ID = DIR_CFG + "\\" + FL_ID;

        //Ne sert quasiment pas ;-(
        public static string FULL_TIME
        {
            get {
                return DateTime.Now.ToString("yyyy -> MMMM (#MM) -> dddd(#dd) -> HH [K / zzz] : mm : ss : ffffff");
            }
        }

        //Le nom du fichier des logs
        public static string FILE_LOGS { get; private set; }


        //Voilà, à appeler au démarrage
        public static void InitVars()
        {
            FILE_LOGS = DIR_LOG + "\\" + DateTime.Now.ToString("y-MM-dd__hh-mm-ss") + ".txt";
        }

    }
}
