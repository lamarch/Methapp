using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Methanisation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        /* Main Form Button Events */

        //New BL
        private void button_NewBL_Click(object sender, EventArgs e)
        {
            Program.ShowBLWin();
        }

        //Options
        private void button_Options_Click(object sender, EventArgs e)
        {
            Program.ShowOptions();
        }

        //Actualiser
        private void button_Refresh_Click(object sender, EventArgs e)
        {

        }

        //Quitter
        private void button_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Menu Fumiers
        private void button_ManageFumiers_Click(object sender, EventArgs e)
        {
            Program.ShowFumier();
        }

        /* Menu Strip Controls */

        //Montrer dans l'eploreur de fichier
        private void montrerDansLExplorateurDeFichiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ShowInExplorer();
        }

        //Récupérer les données perdues, à voir...
        private void récupérerDesDonnéesPerduesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.GetLoseData();
        }

        //Contacter le développeur, à faire...
        private void contatcerLeDeveloppeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ContactDevs();
        }

        //Montrer une aide quelconque, à voir...
        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ShowHelp();
        }

        //Actualiser l'interface, les fumiers, les bons de livraisons
        private void actualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Les options de l'appli, à voir...
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ShowOptions();
        }

        //Montrer le menu des exploitations.
        private void button_MenuExpl_Click(object sender, EventArgs e)
        {
            Program.ShowExpl();
        }

        //Montrer le menu des chauffeurs
        private void bt_menu_chauffeur_Click(object sender, EventArgs e)
        {
            Program.ShowCHF();
        }

        private void faireUneSauvegardeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.MakeBackup();
        }

        private void Timer_Save_Tick(object sender, EventArgs e)
        {
            DataCore.SaveLists();
        }


        public void SetSaveText(string text)
        {
        }

        public void SetStateToSaving()
        {
            toolStripStatusLabel_SAVING.Text = "sauvegarde en cours...";
        }

        public void SetStateToSaved()
        {
            toolStripStatusLabel_SAVING.Text = "sauvegardé";
        }

        private void Timer_refresh_bls_Tick(object sender, EventArgs e)
        {
            
            dataGridView_BL.Rows.Clear();
            DGW_util.InitRows(DataCore.BonLivraisons.Count, dataGridView_BL);

            for(int i = 0; i < DataCore.BonLivraisons.Count; i++)
            {

                DataGridViewRow row = dataGridView_BL.Rows[i];
                row.Cells[0].Value = DataCore.BonLivraisons[i].LongDesc;

            }
        }
    }
}
