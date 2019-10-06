namespace Methanisation
{
    partial class FormBL
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
            this.pn_name = new System.Windows.Forms.Panel();
            this.lb_name_id = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pn_ddl = new System.Windows.Forms.Panel();
            this.dtp_lvr = new System.Windows.Forms.DateTimePicker();
            this.lb_lvr = new System.Windows.Forms.Label();
            this.pn_expl = new System.Windows.Forms.Panel();
            this.cbb_expl = new System.Windows.Forms.ComboBox();
            this.lb_expl = new System.Windows.Forms.Label();
            this.pn_chf = new System.Windows.Forms.Panel();
            this.cbb_chf = new System.Windows.Forms.ComboBox();
            this.lb_chf = new System.Windows.Forms.Label();
            this.pn_fmr = new System.Windows.Forms.Panel();
            this.cbb_fmr = new System.Windows.Forms.ComboBox();
            this.lb_fmr = new System.Windows.Forms.Label();
            this.Bt_Save = new System.Windows.Forms.Button();
            this.exploitationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pn_name.SuspendLayout();
            this.pn_ddl.SuspendLayout();
            this.pn_expl.SuspendLayout();
            this.pn_chf.SuspendLayout();
            this.pn_fmr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exploitationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_name
            // 
            this.pn_name.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_name.Controls.Add(this.lb_name_id);
            this.pn_name.Controls.Add(this.tb_name);
            this.pn_name.Controls.Add(this.lb_name);
            this.pn_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_name.Location = new System.Drawing.Point(0, 0);
            this.pn_name.Margin = new System.Windows.Forms.Padding(10);
            this.pn_name.MinimumSize = new System.Drawing.Size(241, 50);
            this.pn_name.Name = "pn_name";
            this.pn_name.Padding = new System.Windows.Forms.Padding(15);
            this.pn_name.Size = new System.Drawing.Size(800, 90);
            this.pn_name.TabIndex = 0;
            // 
            // lb_name_id
            // 
            this.lb_name_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lb_name_id.Location = new System.Drawing.Point(15, 38);
            this.lb_name_id.Name = "lb_name_id";
            this.lb_name_id.Size = new System.Drawing.Size(81, 23);
            this.lb_name_id.TabIndex = 2;
            this.lb_name_id.Text = "#ID";
            this.lb_name_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_name
            // 
            this.tb_name.Dock = System.Windows.Forms.DockStyle.Right;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tb_name.Location = new System.Drawing.Point(102, 35);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(679, 26);
            this.tb_name.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.DarkGray;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lb_name.Location = new System.Drawing.Point(15, 15);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(766, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "Nom";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_ddl
            // 
            this.pn_ddl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_ddl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_ddl.Controls.Add(this.dtp_lvr);
            this.pn_ddl.Controls.Add(this.lb_lvr);
            this.pn_ddl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_ddl.Location = new System.Drawing.Point(0, 90);
            this.pn_ddl.Margin = new System.Windows.Forms.Padding(10);
            this.pn_ddl.MinimumSize = new System.Drawing.Size(241, 50);
            this.pn_ddl.Name = "pn_ddl";
            this.pn_ddl.Padding = new System.Windows.Forms.Padding(15);
            this.pn_ddl.Size = new System.Drawing.Size(800, 83);
            this.pn_ddl.TabIndex = 1;
            // 
            // dtp_lvr
            // 
            this.dtp_lvr.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_lvr.CustomFormat = "dddd dd MMMM yyyy HH:mm";
            this.dtp_lvr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtp_lvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtp_lvr.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_lvr.Location = new System.Drawing.Point(15, 38);
            this.dtp_lvr.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtp_lvr.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.dtp_lvr.Name = "dtp_lvr";
            this.dtp_lvr.Size = new System.Drawing.Size(766, 26);
            this.dtp_lvr.TabIndex = 1;
            this.dtp_lvr.Value = new System.DateTime(2019, 4, 14, 2, 2, 0, 0);
            // 
            // lb_lvr
            // 
            this.lb_lvr.BackColor = System.Drawing.Color.DarkGray;
            this.lb_lvr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_lvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lb_lvr.Location = new System.Drawing.Point(15, 15);
            this.lb_lvr.Name = "lb_lvr";
            this.lb_lvr.Size = new System.Drawing.Size(766, 20);
            this.lb_lvr.TabIndex = 0;
            this.lb_lvr.Text = "Date de livraison";
            this.lb_lvr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_expl
            // 
            this.pn_expl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_expl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_expl.Controls.Add(this.cbb_expl);
            this.pn_expl.Controls.Add(this.lb_expl);
            this.pn_expl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_expl.Location = new System.Drawing.Point(0, 173);
            this.pn_expl.Margin = new System.Windows.Forms.Padding(10);
            this.pn_expl.MinimumSize = new System.Drawing.Size(241, 50);
            this.pn_expl.Name = "pn_expl";
            this.pn_expl.Padding = new System.Windows.Forms.Padding(15);
            this.pn_expl.Size = new System.Drawing.Size(800, 90);
            this.pn_expl.TabIndex = 2;
            // 
            // cbb_expl
            // 
            this.cbb_expl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_expl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_expl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbb_expl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbb_expl.FormattingEnabled = true;
            this.cbb_expl.Location = new System.Drawing.Point(15, 43);
            this.cbb_expl.MaxDropDownItems = 100;
            this.cbb_expl.Name = "cbb_expl";
            this.cbb_expl.Size = new System.Drawing.Size(766, 28);
            this.cbb_expl.Sorted = true;
            this.cbb_expl.TabIndex = 1;
            // 
            // lb_expl
            // 
            this.lb_expl.BackColor = System.Drawing.Color.DarkGray;
            this.lb_expl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_expl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lb_expl.Location = new System.Drawing.Point(15, 15);
            this.lb_expl.Name = "lb_expl";
            this.lb_expl.Size = new System.Drawing.Size(766, 20);
            this.lb_expl.TabIndex = 0;
            this.lb_expl.Text = "Exploitation";
            this.lb_expl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_chf
            // 
            this.pn_chf.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_chf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_chf.Controls.Add(this.cbb_chf);
            this.pn_chf.Controls.Add(this.lb_chf);
            this.pn_chf.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_chf.Location = new System.Drawing.Point(0, 263);
            this.pn_chf.Margin = new System.Windows.Forms.Padding(10);
            this.pn_chf.MinimumSize = new System.Drawing.Size(241, 50);
            this.pn_chf.Name = "pn_chf";
            this.pn_chf.Padding = new System.Windows.Forms.Padding(15);
            this.pn_chf.Size = new System.Drawing.Size(800, 90);
            this.pn_chf.TabIndex = 3;
            // 
            // cbb_chf
            // 
            this.cbb_chf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_chf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_chf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbb_chf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbb_chf.FormattingEnabled = true;
            this.cbb_chf.Items.AddRange(new object[] {
            "d",
            "ds",
            "es"});
            this.cbb_chf.Location = new System.Drawing.Point(15, 43);
            this.cbb_chf.MaxDropDownItems = 100;
            this.cbb_chf.Name = "cbb_chf";
            this.cbb_chf.Size = new System.Drawing.Size(766, 28);
            this.cbb_chf.Sorted = true;
            this.cbb_chf.TabIndex = 1;
            // 
            // lb_chf
            // 
            this.lb_chf.BackColor = System.Drawing.Color.DarkGray;
            this.lb_chf.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_chf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lb_chf.Location = new System.Drawing.Point(15, 15);
            this.lb_chf.Name = "lb_chf";
            this.lb_chf.Size = new System.Drawing.Size(766, 20);
            this.lb_chf.TabIndex = 0;
            this.lb_chf.Text = "Chauffeur";
            this.lb_chf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_fmr
            // 
            this.pn_fmr.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pn_fmr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_fmr.Controls.Add(this.cbb_fmr);
            this.pn_fmr.Controls.Add(this.lb_fmr);
            this.pn_fmr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_fmr.Location = new System.Drawing.Point(0, 353);
            this.pn_fmr.Margin = new System.Windows.Forms.Padding(10);
            this.pn_fmr.MinimumSize = new System.Drawing.Size(241, 50);
            this.pn_fmr.Name = "pn_fmr";
            this.pn_fmr.Padding = new System.Windows.Forms.Padding(15);
            this.pn_fmr.Size = new System.Drawing.Size(800, 91);
            this.pn_fmr.TabIndex = 4;
            // 
            // cbb_fmr
            // 
            this.cbb_fmr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbb_fmr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_fmr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbb_fmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cbb_fmr.FormattingEnabled = true;
            this.cbb_fmr.Items.AddRange(new object[] {
            "d",
            "ds",
            "es"});
            this.cbb_fmr.Location = new System.Drawing.Point(15, 44);
            this.cbb_fmr.MaxDropDownItems = 100;
            this.cbb_fmr.Name = "cbb_fmr";
            this.cbb_fmr.Size = new System.Drawing.Size(766, 28);
            this.cbb_fmr.Sorted = true;
            this.cbb_fmr.TabIndex = 1;
            // 
            // lb_fmr
            // 
            this.lb_fmr.BackColor = System.Drawing.Color.DarkGray;
            this.lb_fmr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_fmr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.lb_fmr.Location = new System.Drawing.Point(15, 15);
            this.lb_fmr.Name = "lb_fmr";
            this.lb_fmr.Size = new System.Drawing.Size(766, 20);
            this.lb_fmr.TabIndex = 0;
            this.lb_fmr.Text = "Fumier";
            this.lb_fmr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_Save
            // 
            this.Bt_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bt_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bt_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Bt_Save.Location = new System.Drawing.Point(0, 444);
            this.Bt_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(800, 63);
            this.Bt_Save.TabIndex = 8;
            this.Bt_Save.Text = "Enregistrer";
            this.Bt_Save.UseVisualStyleBackColor = true;
            this.Bt_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            // 
            // exploitationBindingSource
            // 
            this.exploitationBindingSource.DataSource = typeof(Methanisation.Exploitation);
            // 
            // FormBL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.Bt_Save);
            this.Controls.Add(this.pn_fmr);
            this.Controls.Add(this.pn_chf);
            this.Controls.Add(this.pn_expl);
            this.Controls.Add(this.pn_ddl);
            this.Controls.Add(this.pn_name);
            this.Name = "FormBL";
            this.Text = "FormBL";
            this.Load += new System.EventHandler(this.FormBL_Load);
            this.pn_name.ResumeLayout(false);
            this.pn_name.PerformLayout();
            this.pn_ddl.ResumeLayout(false);
            this.pn_expl.ResumeLayout(false);
            this.pn_chf.ResumeLayout(false);
            this.pn_fmr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exploitationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_name;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel pn_ddl;
        private System.Windows.Forms.DateTimePicker dtp_lvr;
        private System.Windows.Forms.Label lb_lvr;
        private System.Windows.Forms.Panel pn_expl;
        private System.Windows.Forms.Label lb_expl;
        private System.Windows.Forms.ComboBox cbb_expl;
        private System.Windows.Forms.BindingSource exploitationBindingSource;
        private System.Windows.Forms.Panel pn_chf;
        private System.Windows.Forms.ComboBox cbb_chf;
        private System.Windows.Forms.Label lb_chf;
        private System.Windows.Forms.Panel pn_fmr;
        private System.Windows.Forms.ComboBox cbb_fmr;
        private System.Windows.Forms.Label lb_fmr;
        private System.Windows.Forms.Button Bt_Save;
        private System.Windows.Forms.Label lb_name_id;
    }
}