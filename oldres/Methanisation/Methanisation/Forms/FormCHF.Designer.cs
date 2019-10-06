namespace Methanisation
{
    partial class FormCHF
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Exploitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exploitants = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bt_AddLine = new System.Windows.Forms.Button();
            this.Bt_DelLine = new System.Windows.Forms.Button();
            this.Bt_Save = new System.Windows.Forms.Button();
            this.chauffeurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chauffeurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Exploitation,
            this.Adresses,
            this.Exploitants});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = "-";
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(838, 410);
            this.dataGridView1.TabIndex = 3;
            // 
            // Exploitation
            // 
            this.Exploitation.FillWeight = 70.47179F;
            this.Exploitation.HeaderText = "Nom";
            this.Exploitation.Name = "Exploitation";
            // 
            // Adresses
            // 
            this.Adresses.FillWeight = 77.24397F;
            this.Adresses.HeaderText = "Prenom";
            this.Adresses.Name = "Adresses";
            // 
            // Exploitants
            // 
            this.Exploitants.FillWeight = 152.2843F;
            this.Exploitants.HeaderText = "Descrption";
            this.Exploitants.Name = "Exploitants";
            // 
            // Bt_AddLine
            // 
            this.Bt_AddLine.AutoSize = true;
            this.Bt_AddLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_AddLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_AddLine.Location = new System.Drawing.Point(0, 440);
            this.Bt_AddLine.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bt_AddLine.Name = "Bt_AddLine";
            this.Bt_AddLine.Size = new System.Drawing.Size(838, 23);
            this.Bt_AddLine.TabIndex = 5;
            this.Bt_AddLine.Text = "Ajouter un chauffeur";
            this.Bt_AddLine.UseVisualStyleBackColor = true;
            this.Bt_AddLine.Click += new System.EventHandler(this.Bt_AddLine_Click);
            // 
            // Bt_DelLine
            // 
            this.Bt_DelLine.AutoSize = true;
            this.Bt_DelLine.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_DelLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_DelLine.Location = new System.Drawing.Point(0, 463);
            this.Bt_DelLine.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.Bt_DelLine.Name = "Bt_DelLine";
            this.Bt_DelLine.Size = new System.Drawing.Size(838, 23);
            this.Bt_DelLine.TabIndex = 4;
            this.Bt_DelLine.Text = "Supprimer le Chauffeur";
            this.Bt_DelLine.UseVisualStyleBackColor = true;
            this.Bt_DelLine.Click += new System.EventHandler(this.Bt_DelLine_Click);
            // 
            // Bt_Save
            // 
            this.Bt_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bt_Save.Location = new System.Drawing.Point(0, 406);
            this.Bt_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(838, 34);
            this.Bt_Save.TabIndex = 6;
            this.Bt_Save.Text = "Enregistrer";
            this.Bt_Save.UseVisualStyleBackColor = true;
            this.Bt_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            // 
            // chauffeurBindingSource
            // 
            this.chauffeurBindingSource.DataSource = typeof(Methanisation.Chauffeur);
            // 
            // FormCHF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 486);
            this.Controls.Add(this.Bt_Save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Bt_AddLine);
            this.Controls.Add(this.Bt_DelLine);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "FormCHF";
            this.Text = "FormCHF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCHF_Closing);
            this.Load += new System.EventHandler(this.FormCHF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chauffeurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Bt_AddLine;
        private System.Windows.Forms.Button Bt_DelLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exploitation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exploitants;
        private System.Windows.Forms.Button Bt_Save;
        private System.Windows.Forms.BindingSource chauffeurBindingSource;
    }
}