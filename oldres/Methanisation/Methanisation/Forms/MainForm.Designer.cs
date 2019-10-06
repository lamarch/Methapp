namespace Methanisation
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.bt_menu_chauffeur = new System.Windows.Forms.Button();
            this.bt_menu_expl2 = new System.Windows.Forms.Button();
            this.button_ManageFumiers = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.bt_newBL = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.button_Quit = new System.Windows.Forms.Button();
            this.bt_modif_bl_select = new System.Windows.Forms.Button();
            this.dataGridView_BL = new System.Windows.Forms.DataGridView();
            this.Bon_de_livraison = new System.Windows.Forms.DataGridViewLinkColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.montrerDansLExplorateurDeFichiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.récupérerDesDonnéesPerduesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contatcerLeDeveloppeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faireUneSauvegardeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualiserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_Save = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_SAVING = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer_refresh_bls = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer1.Panel1.Controls.Add(this.middlePanel);
            this.splitContainer1.Panel1.Controls.Add(this.TopPanel);
            this.splitContainer1.Panel1.Controls.Add(this.bottomPanel);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(50);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bt_modif_bl_select);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_BL);
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1234, 487);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 0;
            // 
            // middlePanel
            // 
            this.middlePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.middlePanel.Controls.Add(this.bt_menu_chauffeur);
            this.middlePanel.Controls.Add(this.bt_menu_expl2);
            this.middlePanel.Controls.Add(this.button_ManageFumiers);
            this.middlePanel.Location = new System.Drawing.Point(53, 155);
            this.middlePanel.MinimumSize = new System.Drawing.Size(366, 122);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(366, 122);
            this.middlePanel.TabIndex = 12;
            // 
            // bt_menu_chauffeur
            // 
            this.bt_menu_chauffeur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_menu_chauffeur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_menu_chauffeur.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_menu_chauffeur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bt_menu_chauffeur.Location = new System.Drawing.Point(0, 80);
            this.bt_menu_chauffeur.Name = "bt_menu_chauffeur";
            this.bt_menu_chauffeur.Size = new System.Drawing.Size(366, 40);
            this.bt_menu_chauffeur.TabIndex = 10;
            this.bt_menu_chauffeur.Text = "Menu Des Chauffeurs";
            this.bt_menu_chauffeur.UseVisualStyleBackColor = true;
            this.bt_menu_chauffeur.Click += new System.EventHandler(this.bt_menu_chauffeur_Click);
            // 
            // bt_menu_expl2
            // 
            this.bt_menu_expl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_menu_expl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_menu_expl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_menu_expl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bt_menu_expl2.Location = new System.Drawing.Point(0, 40);
            this.bt_menu_expl2.Name = "bt_menu_expl2";
            this.bt_menu_expl2.Size = new System.Drawing.Size(366, 40);
            this.bt_menu_expl2.TabIndex = 7;
            this.bt_menu_expl2.Text = "Menu Des Exploitations";
            this.bt_menu_expl2.UseVisualStyleBackColor = true;
            this.bt_menu_expl2.Click += new System.EventHandler(this.button_MenuExpl_Click);
            // 
            // button_ManageFumiers
            // 
            this.button_ManageFumiers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_ManageFumiers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ManageFumiers.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ManageFumiers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_ManageFumiers.Location = new System.Drawing.Point(0, 0);
            this.button_ManageFumiers.Name = "button_ManageFumiers";
            this.button_ManageFumiers.Size = new System.Drawing.Size(366, 40);
            this.button_ManageFumiers.TabIndex = 6;
            this.button_ManageFumiers.Text = "Menu Des Fumiers";
            this.button_ManageFumiers.UseVisualStyleBackColor = true;
            this.button_ManageFumiers.Click += new System.EventHandler(this.button_ManageFumiers_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.AutoSize = true;
            this.TopPanel.Controls.Add(this.bt_newBL);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(50, 50);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(366, 40);
            this.TopPanel.TabIndex = 11;
            // 
            // bt_newBL
            // 
            this.bt_newBL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_newBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_newBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_newBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.bt_newBL.Location = new System.Drawing.Point(0, 0);
            this.bt_newBL.Name = "bt_newBL";
            this.bt_newBL.Size = new System.Drawing.Size(366, 40);
            this.bt_newBL.TabIndex = 1;
            this.bt_newBL.Text = "Créer Un Nouveau Bon De Livraison";
            this.bt_newBL.UseVisualStyleBackColor = true;
            this.bt_newBL.Click += new System.EventHandler(this.button_NewBL_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bottomPanel.Controls.Add(this.button1);
            this.bottomPanel.Controls.Add(this.button_Quit);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(50, 357);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(366, 80);
            this.bottomPanel.TabIndex = 10;
            // 
            // button_Quit
            // 
            this.button_Quit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Quit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_Quit.Location = new System.Drawing.Point(0, 40);
            this.button_Quit.Name = "button_Quit";
            this.button_Quit.Size = new System.Drawing.Size(366, 40);
            this.button_Quit.TabIndex = 2;
            this.button_Quit.Text = "Quitter";
            this.button_Quit.UseVisualStyleBackColor = true;
            this.button_Quit.Click += new System.EventHandler(this.button_Quit_Click);
            // 
            // bt_modif_bl_select
            // 
            this.bt_modif_bl_select.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_modif_bl_select.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_modif_bl_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_modif_bl_select.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.bt_modif_bl_select.Location = new System.Drawing.Point(156, 447);
            this.bt_modif_bl_select.MaximumSize = new System.Drawing.Size(550, 40);
            this.bt_modif_bl_select.Name = "bt_modif_bl_select";
            this.bt_modif_bl_select.Size = new System.Drawing.Size(461, 40);
            this.bt_modif_bl_select.TabIndex = 9;
            this.bt_modif_bl_select.Text = "Modifier Le Bon De Livraison Sélectionné";
            this.bt_modif_bl_select.UseVisualStyleBackColor = true;
            // 
            // dataGridView_BL
            // 
            this.dataGridView_BL.AllowUserToAddRows = false;
            this.dataGridView_BL.AllowUserToDeleteRows = false;
            this.dataGridView_BL.AllowUserToResizeColumns = false;
            this.dataGridView_BL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_BL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_BL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridView_BL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_BL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_BL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Bon_de_livraison});
            this.dataGridView_BL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_BL.EnableHeadersVisualStyles = false;
            this.dataGridView_BL.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_BL.MultiSelect = false;
            this.dataGridView_BL.Name = "dataGridView_BL";
            this.dataGridView_BL.ReadOnly = true;
            this.dataGridView_BL.RowHeadersVisible = false;
            this.dataGridView_BL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_BL.Size = new System.Drawing.Size(764, 487);
            this.dataGridView_BL.TabIndex = 10;
            // 
            // Bon_de_livraison
            // 
            this.Bon_de_livraison.HeaderText = "Bons de livraison";
            this.Bon_de_livraison.Name = "Bon_de_livraison";
            this.Bon_de_livraison.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 487);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.actualiserToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.montrerDansLExplorateurDeFichiersToolStripMenuItem,
            this.récupérerDesDonnéesPerduesToolStripMenuItem,
            this.contatcerLeDeveloppeurToolStripMenuItem,
            this.faireUneSauvegardeToolStripMenuItem});
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            // 
            // montrerDansLExplorateurDeFichiersToolStripMenuItem
            // 
            this.montrerDansLExplorateurDeFichiersToolStripMenuItem.Name = "montrerDansLExplorateurDeFichiersToolStripMenuItem";
            this.montrerDansLExplorateurDeFichiersToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.montrerDansLExplorateurDeFichiersToolStripMenuItem.Text = "Montrer Dans L\'Explorateur De Fichiers";
            this.montrerDansLExplorateurDeFichiersToolStripMenuItem.Click += new System.EventHandler(this.montrerDansLExplorateurDeFichiersToolStripMenuItem_Click);
            // 
            // récupérerDesDonnéesPerduesToolStripMenuItem
            // 
            this.récupérerDesDonnéesPerduesToolStripMenuItem.Name = "récupérerDesDonnéesPerduesToolStripMenuItem";
            this.récupérerDesDonnéesPerduesToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.récupérerDesDonnéesPerduesToolStripMenuItem.Text = "Récupérer Des Données Perdues";
            this.récupérerDesDonnéesPerduesToolStripMenuItem.Click += new System.EventHandler(this.récupérerDesDonnéesPerduesToolStripMenuItem_Click);
            // 
            // contatcerLeDeveloppeurToolStripMenuItem
            // 
            this.contatcerLeDeveloppeurToolStripMenuItem.Name = "contatcerLeDeveloppeurToolStripMenuItem";
            this.contatcerLeDeveloppeurToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.contatcerLeDeveloppeurToolStripMenuItem.Text = "Contacter Le Developpeur";
            this.contatcerLeDeveloppeurToolStripMenuItem.Click += new System.EventHandler(this.contatcerLeDeveloppeurToolStripMenuItem_Click);
            // 
            // faireUneSauvegardeToolStripMenuItem
            // 
            this.faireUneSauvegardeToolStripMenuItem.Name = "faireUneSauvegardeToolStripMenuItem";
            this.faireUneSauvegardeToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.faireUneSauvegardeToolStripMenuItem.Text = "Faire une sauvegarde";
            this.faireUneSauvegardeToolStripMenuItem.Click += new System.EventHandler(this.faireUneSauvegardeToolStripMenuItem_Click);
            // 
            // actualiserToolStripMenuItem
            // 
            this.actualiserToolStripMenuItem.Name = "actualiserToolStripMenuItem";
            this.actualiserToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.actualiserToolStripMenuItem.Text = "Actualiser";
            this.actualiserToolStripMenuItem.Click += new System.EventHandler(this.actualiserToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // timer_Save
            // 
            this.timer_Save.Enabled = true;
            this.timer_Save.Interval = 10000;
            this.timer_Save.Tick += new System.EventHandler(this.Timer_Save_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_SAVING});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_SAVING
            // 
            this.toolStripStatusLabel_SAVING.ActiveLinkColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel_SAVING.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel_SAVING.Name = "toolStripStatusLabel_SAVING";
            this.toolStripStatusLabel_SAVING.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel_SAVING.Text = ".";
            // 
            // timer_refresh_bls
            // 
            this.timer_refresh_bls.Enabled = true;
            this.timer_refresh_bls.Interval = 500;
            this.timer_refresh_bls.Tick += new System.EventHandler(this.Timer_refresh_bls_Tick);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1234, 536);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1250, 575);
            this.Name = "MainForm";
            this.Text = "err";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Quit;
        private System.Windows.Forms.Button bt_newBL;
        private System.Windows.Forms.Button button_ManageFumiers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem montrerDansLExplorateurDeFichiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem récupérerDesDonnéesPerduesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contatcerLeDeveloppeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualiserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Button bt_menu_expl2;
        private System.Windows.Forms.Panel middlePanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button bt_menu_chauffeur;
        private System.Windows.Forms.ToolStripMenuItem faireUneSauvegardeToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Save;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_SAVING;
        private System.Windows.Forms.Button bt_modif_bl_select;
        private System.Windows.Forms.Timer timer_refresh_bls;
        private System.Windows.Forms.DataGridView dataGridView_BL;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridViewLinkColumn Bon_de_livraison;
        private System.Windows.Forms.Button button1;
    }
}

