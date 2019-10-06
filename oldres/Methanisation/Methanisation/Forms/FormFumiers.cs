using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methanisation
{
    public partial class FormFumiers : Form
    {
        bool cancelFormQuit;
        private DataGridView savedDataGridView;

        public FormFumiers()
        {
            InitializeComponent();
            savedDataGridView = DGW_util.CloneDGW(dataGridView1);
        }

        private void FormFumiers_Load(object sender, EventArgs e)
        {
            //List<Fumier> fumiers = Fumier.LoadFumiers();
            List<Fumier> fumiers = DataCore.Fumiers;

            DGW_util.InitRows(fumiers.Count,dataGridView1);

            foreach (Fumier fumier in fumiers)
            {
                DataGridViewRow row;

                row = dataGridView1.Rows[fumiers.IndexOf(fumier)];

                row.Cells[0].Value = fumier.Nom;
                row.Cells[1].Value = fumier.Poids;
                row.Cells[2].Value = fumier.MSeche;
                row.Cells[3].Value = fumier.TxCh4;

                Debug.Log("new fumier loaded (" + fumier.ToString() + ") -> f# " + (fumiers.IndexOf(fumier) + 1) + "/" + fumiers.Count);

            }
        }

        //Lors de suppression :
        private void Bt_DelLine_Click(object sender, EventArgs e)
        {
            DGW_util.RemoveRow(dataGridView1);
        }

        private void Bt_Save_Click(object sender, EventArgs e)
        {
            List<Fumier> fumiers = new List<Fumier>();
            //int i = 0;
            int y = 0;
            int i_nd = 1;
            string err = "";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                y++;

                Fumier fumier = Fumier.GetFumierFromDGWRow(row, out err);

                if (err == "")
                {
                    fumiers.Add(fumier);
                    Debug.Log("new fumier saved (" + fumier.ToString() + ")");
                }
                //i = 0;

            }
            if (err != "")
            {
                Debug.MsgErr("Il y a eu une erreur, la sauvegarde n'a donc pas eu lieu. Corrigez les erreurs et réessayez  : " + err, "F5x76", null);
            }
            else
            {
                //On met le DGW en tant que sauvegardé
                savedDataGridView = DGW_util.CloneDGW(dataGridView1);
                //Et on le sauvegarde
                DataCore.SetFumiers(fumiers);
            }

        }

        private void Bt_AddLine_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new DataGridViewRow());
        }

        private void FormFumiers_Closing(object sender, FormClosingEventArgs e)
        {
            Debug.Log("Form closing");
            if (true)
            {
                Debug.Log("Waiting form closing because unsaved");
                DialogResult diagres = Debug.MsgWarn("Voulez-vous sauvegarder avant de quitter ?", MessageBoxButtons.YesNoCancel);
                if (diagres == DialogResult.Yes)
                {
                    Bt_Save_Click(sender, e);
                    e.Cancel = false;
                }
                else if (diagres == DialogResult.No)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
