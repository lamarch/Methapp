namespace Methanisation
{
    partial class FormFumiers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_Save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSeche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxCh4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_DelLine = new System.Windows.Forms.Button();
            this.Bt_AddLine = new System.Windows.Forms.Button();
            this.Bt_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(831, 481);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Enregistrer";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Visible = false;
            this.button_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Poids,
            this.MSeche,
            this.TxCh4});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(918, 588);
            this.dataGridView1.TabIndex = 1;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 100;
            this.Nom.Name = "Nom";
            this.Nom.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nom.ToolTipText = "Le nom du fumier.";
            // 
            // Poids
            // 
            this.Poids.DataPropertyName = "Poids";
            this.Poids.HeaderText = "Poids";
            this.Poids.MinimumWidth = 100;
            this.Poids.Name = "Poids";
            this.Poids.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MSeche
            // 
            this.MSeche.DataPropertyName = "MSeche";
            this.MSeche.HeaderText = "MSeche";
            this.MSeche.MinimumWidth = 100;
            this.MSeche.Name = "MSeche";
            // 
            // TxCh4
            // 
            this.TxCh4.DataPropertyName = "TxCh4";
            this.TxCh4.HeaderText = "TxCh4";
            this.TxCh4.MinimumWidth = 100;
            this.TxCh4.Name = "TxCh4";
            // 
            // Bt_DelLine
            // 
            this.Bt_DelLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_DelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_DelLine.Location = new System.Drawing.Point(0, 565);
            this.Bt_DelLine.Name = "Bt_DelLine";
            this.Bt_DelLine.Size = new System.Drawing.Size(918, 23);
            this.Bt_DelLine.TabIndex = 2;
            this.Bt_DelLine.Text = "Supprimer Le Fumier";
            this.Bt_DelLine.UseVisualStyleBackColor = true;
            this.Bt_DelLine.Click += new System.EventHandler(this.Bt_DelLine_Click);
            // 
            // Bt_AddLine
            // 
            this.Bt_AddLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_AddLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_AddLine.Location = new System.Drawing.Point(0, 542);
            this.Bt_AddLine.Name = "Bt_AddLine";
            this.Bt_AddLine.Size = new System.Drawing.Size(918, 23);
            this.Bt_AddLine.TabIndex = 3;
            this.Bt_AddLine.Text = "Ajouter Un Fumier";
            this.Bt_AddLine.UseVisualStyleBackColor = true;
            this.Bt_AddLine.Click += new System.EventHandler(this.Bt_AddLine_Click);
            // 
            // Bt_Save
            // 
            this.Bt_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_Save.Location = new System.Drawing.Point(0, 508);
            this.Bt_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(918, 34);
            this.Bt_Save.TabIndex = 7;
            this.Bt_Save.Text = "Enregistrer";
            this.Bt_Save.UseVisualStyleBackColor = true;
            this.Bt_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            // 
            // FormFumiers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 588);
            this.Controls.Add(this.Bt_Save);
            this.Controls.Add(this.Bt_AddLine);
            this.Controls.Add(this.Bt_DelLine);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Save);
            this.Name = "FormFumiers";
            this.Text = "FormFumiers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFumiers_Closing);
            this.Load += new System.EventHandler(this.FormFumiers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_DelLine;
        private System.Windows.Forms.Button Bt_AddLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSeche;
        private System.Windows.Forms.DataGridViewTextBoxColumn TxCh4;
        private System.Windows.Forms.Button Bt_Save;
    }
}