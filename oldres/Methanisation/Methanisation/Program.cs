using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Methanisation
{
    static class Program
    {
        static MainForm mf;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ref.InitVars();
            
            FileManager.InitDirs();
            FileManager.InitFiles();
            Debug.InitLogs();

            Debug.Log($"STARTING application[name = {Ref.APP_NAME}, version = \" {Ref.APP_VER} \"] ::");

            Debug.Log("Application.EnableVisualStyles()");
            Application.EnableVisualStyles();
            Debug.Log("success");

            Debug.Log("Application.SetCompatibleTextRenderingDefault(false)");
            Application.SetCompatibleTextRenderingDefault(false);
            Debug.Log("success");

            Debug.Log("INIT...");

            Debug.Log("Objects...");
            mf = new MainForm();
            mf.Text = Ref.APP_NAME + " - " + Ref.APP_VER;
            Debug.Log("OK");

            Debug.Log("Delegates...");
            DataCore.onSaveStart += mf.SetStateToSaving;
            DataCore.onSaveStop += mf.SetStateToSaved;
            Debug.Log("OK");

            Debug.Log("INIT end");


            Debug.Log("Loading lists...");
            DataCore.LoadLists();

            Debug.Log("Application.Run(new MainForm())");

            try
            {
                Application.Run(mf);
                Debug.Log("START finish with success result.");
            }
            catch (Exception e)
            {

                Debug.MsgErr("ERREUR IRRECUPERABLE !", "Ax55", e);
                DataCore.SaveLists();
                Debug.Log("ERREUR.");
                Application.Exit();
            }

            Debug.Log("Saving lists...");
            DataCore.SaveLists();

            Debug.Log("Application stopping...");

            Debug.Log("Closing opened forms...");
            foreach(Form form in Application.OpenForms)
            {
                form.Close();
            }

            Debug.Log("application STOPED.");
        }

        public static void ShowBLWin()
        {
            Debug.Log("Show BLWin _win_");
            new FormBL().Show();
        }

        public static void ShowBLModifWin(BonLivraison bl)
        {
            Debug.Log("Show BLModifWin _win_");
            new FormBLmodif(bl).Show();
        }

        public static void ShowOptions()
        {
            Debug.Log("Show Options _win_");
            new FormOptions().Show();
        }

        public static void ShowFumier()
        {
            Debug.Log("Show Fumier _win_");
            new FormFumiers().Show();
        }

        public static void ShowExpl()
        {
            Debug.Log("Show Expl _win_");
            new FormEXPL().Show();
        }

        public static void ShowCHF()
        {
            Debug.Log("Show CHF _win_");
            new FormCHF().Show();
        }

        public static void ShowHelp()
        {
            Debug.Log("ShowHelp()");
            Debug.MsgNotImp();
        }

        public static void GetLoseData()
        {
            Debug.Log("GetLoseData()");
            Debug.MsgNotImp();
        }

        public static void ShowInExplorer()
        {
            Debug.Log("ShowInExplorer()");
            Process.Start(Environment.CurrentDirectory);
        }

        public static void ContactDevs()
        {
            Debug.Log("ContactDevs()");

            Debug.Log("PROCESS.START -> help (mailto)");
            Process.Start("mailto:paulmarchal54370@gmail.com");

            Debug.MsgNotImp();
        }

        public static void MakeBackup()
        {
            Debug.Log("MakeBackup()");
            Debug.MsgNotImp();
        }
        
    }
}
