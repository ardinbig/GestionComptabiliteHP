namespace GestionComptabiliteHP.Forms
{
    partial class FrmReport
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
            this.RptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnPrintJournal = new System.Windows.Forms.Button();
            this.DtFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DtDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPrintBilan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PnelHeaderCompte = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PnelHeaderCompte.SuspendLayout();
            this.SuspendLayout();
            // 
            // RptViewer
            // 
            this.RptViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptViewer.Location = new System.Drawing.Point(3, 16);
            this.RptViewer.Name = "RptViewer";
            this.RptViewer.Size = new System.Drawing.Size(745, 239);
            this.RptViewer.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox2.Controls.Add(this.BtnPrintJournal);
            this.groupBox2.Controls.Add(this.DtFin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.DtDebut);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(510, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Journal des opérations comptables";
            // 
            // BtnPrintJournal
            // 
            this.BtnPrintJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.BtnPrintJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintJournal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintJournal.ForeColor = System.Drawing.Color.White;
            this.BtnPrintJournal.Location = new System.Drawing.Point(356, 20);
            this.BtnPrintJournal.Name = "BtnPrintJournal";
            this.BtnPrintJournal.Size = new System.Drawing.Size(138, 50);
            this.BtnPrintJournal.TabIndex = 15;
            this.BtnPrintJournal.Text = "Journal";
            this.BtnPrintJournal.UseVisualStyleBackColor = false;
            this.BtnPrintJournal.Click += new System.EventHandler(this.BtnPrintJournal_Click);
            // 
            // DtFin
            // 
            this.DtFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DtFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DtFin.Location = new System.Drawing.Point(107, 48);
            this.DtFin.Name = "DtFin";
            this.DtFin.Size = new System.Drawing.Size(229, 22);
            this.DtFin.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date fin : ";
            // 
            // DtDebut
            // 
            this.DtDebut.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DtDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DtDebut.Location = new System.Drawing.Point(107, 20);
            this.DtDebut.Name = "DtDebut";
            this.DtDebut.Size = new System.Drawing.Size(229, 22);
            this.DtDebut.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date début : ";
            // 
            // BtnPrintBilan
            // 
            this.BtnPrintBilan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrintBilan.Location = new System.Drawing.Point(27, 19);
            this.BtnPrintBilan.Name = "BtnPrintBilan";
            this.BtnPrintBilan.Size = new System.Drawing.Size(95, 30);
            this.BtnPrintBilan.TabIndex = 16;
            this.BtnPrintBilan.Text = "Bilan";
            this.BtnPrintBilan.UseVisualStyleBackColor = true;
            this.BtnPrintBilan.Click += new System.EventHandler(this.BtnPrintBilan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.RptViewer);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 258);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox3.Controls.Add(this.BtnPrintBilan);
            this.groupBox3.Location = new System.Drawing.Point(545, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 84);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // PnelHeaderCompte
            // 
            this.PnelHeaderCompte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PnelHeaderCompte.Controls.Add(this.label5);
            this.PnelHeaderCompte.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnelHeaderCompte.Location = new System.Drawing.Point(0, 0);
            this.PnelHeaderCompte.Name = "PnelHeaderCompte";
            this.PnelHeaderCompte.Size = new System.Drawing.Size(775, 46);
            this.PnelHeaderCompte.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(313, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rapport";
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(775, 445);
            this.Controls.Add(this.PnelHeaderCompte);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReport";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.PnelHeaderCompte.ResumeLayout(false);
            this.PnelHeaderCompte.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptViewer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnPrintJournal;
        private System.Windows.Forms.DateTimePicker DtFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPrintBilan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel PnelHeaderCompte;
        private System.Windows.Forms.Label label5;
    }
}