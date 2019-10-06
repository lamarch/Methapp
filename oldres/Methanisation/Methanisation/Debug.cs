
using System;
using System.IO;
using System.Windows.Forms;

namespace Methanisation
{
    static class Debug
    {
        public static bool RowDebug = false;
        static int logNum = 0;

        public static void InitLogs()
        {
            Debug.Log("LOGS METHANISATION APP (" + Ref.FILE_LOGS + ")>>\n~~" + Ref.FULL_TIME + "~~ >> ");
        }

        public static DialogResult MsgWarn(string text, MessageBoxButtons mbb = MessageBoxButtons.OK)
        {
            DialogResult res = MessageBox.Show(text, "Attention !", mbb, MessageBoxIcon.Warning);
            Log("MSG_BOX #WARNING > " + text + " > " + res);
            return res;
        }

        public static DialogResult MsgNotImp()
        {
            DialogResult res = MessageBox.Show("Cette option n'est pas encore disponible...", "Attention !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Log("MSG_BOX #NOT_IMPLEMENTED >> " + res);
            return res;

        }

        public static DialogResult MsgErr(string text, string ErrCode, Exception excp = null, MessageBoxButtons mbb = MessageBoxButtons.OK)
        {
            string e;

            // TODO : Affiche des guillemets vides, alors il faut qu'il affiche 'nule ou vide'
            if (excp == null || string.IsNullOrEmpty(excp.Message) || string.IsNullOrWhiteSpace(excp.Message))
                e = "exception est nule ou vide";
            else
                e = excp.Message;

            DialogResult res = MessageBox.Show("ERREUR (CODE : " + ErrCode + ") :\n\nMESSAGE :\n\" " + text  + " \"\n\nEXCEPTION :\n\" "  + excp + " \"", "Erreur (" + ErrCode + ") !", mbb, MessageBoxIcon.Error);
            Log("MSG_BOX #ERROR > " + text + " > " + res);
            return res;

        }

        public static DialogResult MsgInfo(string text, MessageBoxButtons mbb = MessageBoxButtons.OK)
        {
            DialogResult res = MessageBox.Show(text, "Information !", mbb, MessageBoxIcon.Information);
            Log("MSG_BOX #INFO > " + text + " > " + res);
            return res;

        }

        public static bool Log(string txt)
        {
            try
            {
                File.AppendAllText(Ref.FILE_LOGS, string.Format("LOG [{0}] ({1}) -> {2}", logNum, DateTime.Now.ToString("HH : mm : ss : ffff"), txt));
                File.AppendAllText(Ref.FILE_LOGS, Environment.NewLine);
                logNum++;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n " + e.Message + "\n " + e.StackTrace, "Erreur lors de l'ecriture des logs", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        public static bool Log(string[] txt)
        {
            try
            {
                foreach (string item in txt)
                {
                    File.AppendAllText(Ref.FILE_LOGS, item + " - ");
                }
                File.AppendAllText(Ref.FILE_LOGS, "Environment.NewLine");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : \n " + e.Message + "\n " + e.StackTrace, "Erreur lors de l'ecriture des logs", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}
