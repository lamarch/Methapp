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
    public partial class FormCHF : Form
    {
        private DataGridView savedDataGridView;

        public FormCHF()
        {
            InitializeComponent();
            savedDataGridView = DGW_util.CloneDGW(dataGridView1);
        }

        private void FormCHF_Load(object sender, EventArgs e)
        {
            List<Chauffeur> chauffeurs = DataCore.Chauffeurs;
            //Mis à jour des différentes ligne
            DGW_util.InitRows(chauffeurs.Count, dataGridView1);

            foreach (Chauffeur chauffeur in chauffeurs)
            {
                DataGridViewRow row;

                row = dataGridView1.Rows[chauffeurs.IndexOf(chauffeur)];

                Debug.Log("new chauffeur loaded (" + chauffeur.ToString() + ") -> f# " + (chauffeurs.IndexOf(chauffeur) + 1) + "/" + chauffeurs.Count);

                row.Cells[0].Value = chauffeur.Nom;
                row.Cells[1].Value = chauffeur.Prenom;
                row.Cells[2].Value = chauffeur.Description;
            }
            DataCore.SetChauffeurs(chauffeurs);
        }

        private void Bt_Save_Click(object sender, EventArgs e)
        {

            List<Chauffeur> chauffeurs = new List<Chauffeur>();
            int i_nd = 1;
            bool err = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                Chauffeur chauffeur = Chauffeur.GetChauffeurFromDGWRow(row, out bool err_);
                err = err || err_;
                
                //Si il n'y a pas d'erreur alors on l'ajoute à la liste à sauvegarder
                if (!err)
                {
                    chauffeurs.Add(chauffeur);
                    Debug.Log("new chauffeur saved (" + chauffeur.ToString() + ")");
                }
                i_nd++;

            }

            if (err)
            {
                Debug.MsgErr("Il y a eu une erreur, la sauvegarde n'a donc pas eu lieu. Corrigez les erreurs et réessayez", "F3x69", null);
            }
            else
            {
                //On met le DGW en tant que sauvegardé
                savedDataGridView = DGW_util.CloneDGW(dataGridView1);
                //Et on le sauvegarde
                DataCore.SetChauffeurs(chauffeurs);
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

        private void FormCHF_Closing(object sender, FormClosingEventArgs e)
        {
            Debug.Log("Form closing");
            if (true)
            {
                Debug.Log("Waiting form closing because unsaved");
                DialogResult diagres = Debug.MsgWarn("Voulez-vous sauvegarder avant de quitter ?", MessageBoxButtons.YesNoCancel);
                if ( diagres == DialogResult.Yes)
                {
                    Bt_Save_Click(sender, e);
                    e.Cancel = false;
                }
                else if(diagres == DialogResult.No)
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
