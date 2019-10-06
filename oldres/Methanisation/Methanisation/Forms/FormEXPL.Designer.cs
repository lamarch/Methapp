namespace Methanisation
{
    partial class FormEXPL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Noms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clés = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exploitants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_DelLine = new System.Windows.Forms.Button();
            this.Bt_AddLine = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bt_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Noms,
            this.Clés,
            this.Adresse,
            this.Exploitants});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(930, 494);
            this.dataGridView1.TabIndex = 0;
            // 
            // Noms
            // 
            this.Noms.FillWeight = 106.599F;
            this.Noms.HeaderText = "Noms";
            this.Noms.Name = "Noms";
            // 
            // Clés
            // 
            this.Clés.FillWeight = 72.10422F;
            this.Clés.HeaderText = "Clés";
            this.Clés.Name = "Clés";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Exploitants
            // 
            this.Exploitants.FillWeight = 121.2968F;
            this.Exploitants.HeaderText = "Exploitants  (séparés par virgule)";
            this.Exploitants.Name = "Exploitants";
            // 
            // Bt_DelLine
            // 
            this.Bt_DelLine.AutoSize = true;
            this.Bt_DelLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_DelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_DelLine.Location = new System.Drawing.Point(0, 547);
            this.Bt_DelLine.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.Bt_DelLine.Name = "Bt_DelLine";
            this.Bt_DelLine.Size = new System.Drawing.Size(930, 23);
            this.Bt_DelLine.TabIndex = 1;
            this.Bt_DelLine.Text = "Supprimer L\'exploitation";
            this.Bt_DelLine.UseVisualStyleBackColor = true;
            this.Bt_DelLine.Click += new System.EventHandler(this.Bt_DelLine_Click);
            // 
            // Bt_AddLine
            // 
            this.Bt_AddLine.AutoSize = true;
            this.Bt_AddLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_AddLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_AddLine.Location = new System.Drawing.Point(0, 524);
            this.Bt_AddLine.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bt_AddLine.Name = "Bt_AddLine";
            this.Bt_AddLine.Size = new System.Drawing.Size(930, 23);
            this.Bt_AddLine.TabIndex = 2;
            this.Bt_AddLine.Text = "Ajouter une exploitation";
            this.Bt_AddLine.UseVisualStyleBackColor = true;
            this.Bt_AddLine.Click += new System.EventHandler(this.Bt_AddLine_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.Bt_Save);
            this.panel1.Controls.Add(this.Bt_AddLine);
            this.panel1.Controls.Add(this.Bt_DelLine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 570);
            this.panel1.TabIndex = 3;
            // 
            // Bt_Save
            // 
            this.Bt_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_Save.Location = new System.Drawing.Point(0, 493);
            this.Bt_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(930, 31);
            this.Bt_Save.TabIndex = 7;
            this.Bt_Save.Text = "Enregistrer";
            this.Bt_Save.UseVisualStyleBackColor = true;
            this.Bt_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            // 
            // FormEXPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(930, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FormEXPL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEXPL_Closing);
            this.Load += new System.EventHandler(this.FormEXPL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_DelLine;
        private System.Windows.Forms.Button Bt_AddLine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Noms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clés;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exploitants;
        private System.Windows.Forms.Button Bt_Save;
    }
}