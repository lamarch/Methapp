using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Methanisation
{
    public class Fumier
    {

        public float TxCh4;
        public float MSeche;
        public float Poids;
        public string Nom;
        public float Valeur;

        string ID;

        public string GETID { get => ID; }

        public string ShortDesc { get => $"{Nom}"; }
        public string LongDesc { get => ShortDesc + $" (poids : {Poids} ; Matière Séche : {MSeche} ; Taux de CH4 {TxCh4})"; }

        public Fumier()
        {
            this.ID = ID_Store.GetID_str(ID_Store.IDtype.FMR);
            this.Nom = "<non défini>";
            this.MSeche = 0f;
            this.Poids = 0f;
            this.TxCh4 = 0f;
            this.Valeur = 0f;
        }
        public Fumier(string nom, float poids, float mSeche, float txCh4, float valeur)
        {
            this.ID = ID_Store.GetID_str(ID_Store.IDtype.FMR);
            this.Nom = nom;
            this.Poids = poids;
            this.MSeche = mSeche;
            this.TxCh4 = txCh4;
            this.Valeur = valeur;
        }

        public static Fumier GetFumierFromDGWRow(DataGridViewRow row, out string err)
        {
            err = "";
            Fumier fumier = new Fumier();
            if (row.Cells[0].Value != null)
            {
                fumier.Nom = row.Cells[0].Value.ToString();
            }
            else
            {
            }

            if (row.Cells[1].Value != null)
            {
                if(!float.TryParse(row.Cells[1].Value.ToString(), out fumier.Poids))
                {
                    err += Debug.MsgErr("La valeur entrée dans la cellule ligne : " + (row.Index+ 1) + " colonne : " + (row.Cells[1].ColumnIndex + 1) + ", n'est pas valide. Verifiez que ce soit bien un nombre !", "C5x52", null);
                }
            }

            if (row.Cells[2].Value != null)
            {
                if (!float.TryParse(row.Cells[2].Value.ToString(), out fumier.MSeche))
                {
                    err += Debug.MsgErr("La valeur entrée dans la cellule ligne : " + (row.Index + 1) + " colonne : " + (row.Cells[2].ColumnIndex + 1) + ", n'est pas valide. Verifiez que ce soit bien un nombre !", "C5x60", null);
                }
            }

            if (row.Cells[3].Value != null)
            {
                if (!float.TryParse(row.Cells[3].Value.ToString(), out fumier.MSeche))
                {
                    err += Debug.MsgErr("La valeur entrée dans la cellule ligne : " + (row.Index + 1) + " colonne : " + (row.Cells[3].ColumnIndex + 1) + ", n'est pas valide. Verifiez que ce soit bien un nombre !", "C5x68", null);
                }
            }

            return fumier;
        }
    }
}
