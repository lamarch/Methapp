using Methanisation;
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
    public partial class FormEXPL : Form
    {
        private DataGridView savedDataGridView;

        public FormEXPL()
        {
            InitializeComponent();
            savedDataGridView = DGW_util.CloneDGW(dataGridView1);
        }

        private void FormEXPL_Load(object sender, EventArgs e)
        {
            List<Exploitation> exploitations = DataCore.Exploitations;
            //Mis à jour des différentes ligne
            DGW_util.InitRows(exploitations.Count, dataGridView1);

            foreach (Exploitation exploitation in exploitations)
            {
                DataGridViewRow row;

                row = dataGridView1.Rows[exploitations.IndexOf(exploitation)];

                Debug.Log("new exploitation loaded (" + exploitation.ToString() + ") -> f# " + (exploitations.IndexOf(exploitation) + 1) + "/" + exploitations.Count);

                row.Cells[0].Value = exploitation.Nom;
                row.Cells[1].Value = exploitation.Cle;
                row.Cells[2].Value = exploitation.Adresse;
                row.Cells[3].Value = string.Join(",",exploitation.Exploitants);
            }
            DataCore.SetExploitations(exploitations);
        }

        private void Bt_Save_Click(object sender, EventArgs e)
        {
            List<Exploitation> exploitations = new List<Exploitation>();
            int i_nd = 1;
            bool err = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                Exploitation exploitation = Exploitation.GetExploitationFromDGWRow(row, out bool err_);
                err = err || err_;

                //Si il n'y a pas d'erreur alors on l'ajoute à la liste à sauvegarder
                if (!err)
                {
                    exploitations.Add(exploitation);
                    Debug.Log("new exploitation saved (" + exploitation.ToString() + ")");
                }
                i_nd++;

            }

            if (err)
            {
                Debug.MsgErr("Il y a eu une erreur, la sauvegarde n'a donc pas eu lieu. Corrigez les erreurs et réessayez", "F4x70", null);
            }
            else
            {
                //On met le DGW en tant que sauvegardé
                savedDataGridView = DGW_util.CloneDGW(dataGridView1);
                //Et on le sauvegarde
                DataCore.SetExploitations(exploitations);
            }
        }

        private void Bt_DelLine_Click(object sender, EventArgs e)
        {
            DGW_util.RemoveRow(dataGridView1);
        }

        private void Bt_AddLine_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(new DataGridViewRow());
        }

        private void FormEXPL_Closing(object sender, FormClosingEventArgs e)
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

