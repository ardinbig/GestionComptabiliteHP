namespace GestionComptabiliteHP.Forms
{
    partial class UcOperation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnelHeaderOperation = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.PnlMainOperation = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnEditOperation = new System.Windows.Forms.Button();
            this.BtnDeleteOperation = new System.Windows.Forms.Button();
            this.BtnSaveOperation = new System.Windows.Forms.Button();
            this.BtnNewOperation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DgvOperation = new System.Windows.Forms.DataGridView();
            this.DgvColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColCompteD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColTypeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColMontantD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColCompteC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColTypeC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvColMontantC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CmbType2 = new System.Windows.Forms.ComboBox();
            this.CmbType1 = new System.Windows.Forms.ComboBox();
            this.CmbCmpt2 = new System.Windows.Forms.ComboBox();
            this.CmbCmpt1 = new System.Windows.Forms.ComboBox();
            this.TxtMontant = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RbComptant = new System.Windows.Forms.RadioButton();
            this.RbCaisse = new System.Windows.Forms.RadioButton();
            this.DtDateOperation = new System.Windows.Forms.DateTimePicker();
            this.RbBanque = new System.Windows.Forms.RadioButton();
            this.TxtLibelleOperation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIdOperation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnelHeaderOperation.SuspendLayout();
            this.PnlMainOperation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperation)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnelHeaderOperation
            // 
            this.PnelHeaderOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.PnelHeaderOperation.Controls.Add(this.label5);
            this.PnelHeaderOperation.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnelHeaderOperation.Location = new System.Drawing.Point(0, 0);
            this.PnelHeaderOperation.Name = "PnelHeaderOperation";
            this.PnelHeaderOperation.Size = new System.Drawing.Size(768, 46);
            this.PnelHeaderOperation.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(181, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Enregistrement des opérations comptables";
            // 
            // PnlMainOperation
            // 
            this.PnlMainOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(228)))), ((int)(((byte)(229)))));
            this.PnlMainOperation.Controls.Add(this.groupBox1);
            this.PnlMainOperation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlMainOperation.Location = new System.Drawing.Point(0, 45);
            this.PnlMainOperation.Name = "PnlMainOperation";
            this.PnlMainOperation.Size = new System.Drawing.Size(768, 425);
            this.PnlMainOperation.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEditOperation);
            this.groupBox1.Controls.Add(this.BtnDeleteOperation);
            this.groupBox1.Controls.Add(this.BtnSaveOperation);
            this.groupBox1.Controls.Add(this.BtnNewOperation);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // BtnEditOperation
            // 
            this.BtnEditOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(204)))), ((int)(((byte)(62)))));
            this.BtnEditOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditOperation.Enabled = false;
            this.BtnEditOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditOperation.Location = new System.Drawing.Point(390, 173);
            this.BtnEditOperation.Name = "BtnEditOperation";
            this.BtnEditOperation.Size = new System.Drawing.Size(95, 30);
            this.BtnEditOperation.TabIndex = 10;
            this.BtnEditOperation.Text = "Modifier";
            this.BtnEditOperation.UseVisualStyleBackColor = false;
            this.BtnEditOperation.Click += new System.EventHandler(this.ControleOperation_Click);
            // 
            // BtnDeleteOperation
            // 
            this.BtnDeleteOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(146)))), ((int)(((byte)(0)))));
            this.BtnDeleteOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDeleteOperation.Enabled = false;
            this.BtnDeleteOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteOperation.Location = new System.Drawing.Point(502, 173);
            this.BtnDeleteOperation.Name = "BtnDeleteOperation";
            this.BtnDeleteOperation.Size = new System.Drawing.Size(95, 30);
            this.BtnDeleteOperation.TabIndex = 9;
            this.BtnDeleteOperation.Text = "Supprimer";
            this.BtnDeleteOperation.UseVisualStyleBackColor = false;
            this.BtnDeleteOperation.Click += new System.EventHandler(this.ControleOperation_Click);
            // 
            // BtnSaveOperation
            // 
            this.BtnSaveOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(100)))), ((int)(((byte)(174)))));
            this.BtnSaveOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveOperation.Enabled = false;
            this.BtnSaveOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveOperation.Location = new System.Drawing.Point(273, 173);
            this.BtnSaveOperation.Name = "BtnSaveOperation";
            this.BtnSaveOperation.Size = new System.Drawing.Size(95, 30);
            this.BtnSaveOperation.TabIndex = 8;
            this.BtnSaveOperation.Text = "Enregistrer";
            this.BtnSaveOperation.UseVisualStyleBackColor = false;
            this.BtnSaveOperation.Click += new System.EventHandler(this.ControleOperation_Click);
            // 
            // BtnNewOperation
            // 
            this.BtnNewOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(181)))), ((int)(((byte)(115)))));
            this.BtnNewOperation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewOperation.Location = new System.Drawing.Point(163, 173);
            this.BtnNewOperation.Name = "BtnNewOperation";
            this.BtnNewOperation.Size = new System.Drawing.Size(95, 30);
            this.BtnNewOperation.TabIndex = 7;
            this.BtnNewOperation.Text = "Nouveau";
            this.BtnNewOperation.UseVisualStyleBackColor = false;
            this.BtnNewOperation.Click += new System.EventHandler(this.ControleOperation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DgvOperation);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(3, 215);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(742, 197);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste de catégories de classe";
            // 
            // DgvOperation
            // 
            this.DgvOperation.AllowUserToAddRows = false;
            this.DgvOperation.AllowUserToDeleteRows = false;
            this.DgvOperation.AllowUserToOrderColumns = true;
            this.DgvOperation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOperation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvOperation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DgvOperation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOperation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvColId,
            this.DgvColDate,
            this.DgvColLibelle,
            this.DgvColCompteD,
            this.DgvColTypeD,
            this.DgvColMontantD,
            this.DgvColCompteC,
            this.DgvColTypeC,
            this.DgvColMontantC});
            this.DgvOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvOperation.Location = new System.Drawing.Point(3, 16);
            this.DgvOperation.Name = "DgvOperation";
            this.DgvOperation.ReadOnly = true;
            this.DgvOperation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOperation.Size = new System.Drawing.Size(736, 178);
            this.DgvOperation.TabIndex = 0;
            this.DgvOperation.Click += new System.EventHandler(this.DgvOperation_Click);
            // 
            // DgvColId
            // 
            this.DgvColId.DataPropertyName = "id";
            this.DgvColId.FillWeight = 45.68528F;
            this.DgvColId.HeaderText = "Code";
            this.DgvColId.Name = "DgvColId";
            this.DgvColId.ReadOnly = true;
            // 
            // DgvColDate
            // 
            this.DgvColDate.DataPropertyName = "date_operation";
            this.DgvColDate.FillWeight = 106.7893F;
            this.DgvColDate.HeaderText = "Date";
            this.DgvColDate.Name = "DgvColDate";
            this.DgvColDate.ReadOnly = true;
            // 
            // DgvColLibelle
            // 
            this.DgvColLibelle.DataPropertyName = "libelle";
            this.DgvColLibelle.FillWeight = 106.7893F;
            this.DgvColLibelle.HeaderText = "Libellé";
            this.DgvColLibelle.Name = "DgvColLibelle";
            this.DgvColLibelle.ReadOnly = true;
            // 
            // DgvColCompteD
            // 
            this.DgvColCompteD.DataPropertyName = "compte_d";
            this.DgvColCompteD.FillWeight = 106.7893F;
            this.DgvColCompteD.HeaderText = "Compte";
            this.DgvColCompteD.Name = "DgvColCompteD";
            this.DgvColCompteD.ReadOnly = true;
            // 
            // DgvColTypeD
            // 
            this.DgvColTypeD.DataPropertyName = "type_d";
            this.DgvColTypeD.FillWeight = 106.7893F;
            this.DgvColTypeD.HeaderText = "Type";
            this.DgvColTypeD.Name = "DgvColTypeD";
            this.DgvColTypeD.ReadOnly = true;
            // 
            // DgvColMontantD
            // 
            this.DgvColMontantD.DataPropertyName = "montant_d";
            this.DgvColMontantD.FillWeight = 106.7893F;
            this.DgvColMontantD.HeaderText = "Montant";
            this.DgvColMontantD.Name = "DgvColMontantD";
            this.DgvColMontantD.ReadOnly = true;
            // 
            // DgvColCompteC
            // 
            this.DgvColCompteC.DataPropertyName = "compte_c";
            this.DgvColCompteC.FillWeight = 106.7893F;
            this.DgvColCompteC.HeaderText = "Compte";
            this.DgvColCompteC.Name = "DgvColCompteC";
            this.DgvColCompteC.ReadOnly = true;
            // 
            // DgvColTypeC
            // 
            this.DgvColTypeC.DataPropertyName = "type_c";
            this.DgvColTypeC.FillWeight = 106.7893F;
            this.DgvColTypeC.HeaderText = "Type";
            this.DgvColTypeC.Name = "DgvColTypeC";
            this.DgvColTypeC.ReadOnly = true;
            // 
            // DgvColMontantC
            // 
            this.DgvColMontantC.DataPropertyName = "montant_c";
            this.DgvColMontantC.FillWeight = 106.7893F;
            this.DgvColMontantC.HeaderText = "Montant";
            this.DgvColMontantC.Name = "DgvColMontantC";
            this.DgvColMontantC.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox3.Controls.Add(this.CmbType2);
            this.groupBox3.Controls.Add(this.CmbType1);
            this.groupBox3.Controls.Add(this.CmbCmpt2);
            this.groupBox3.Controls.Add(this.CmbCmpt1);
            this.groupBox3.Controls.Add(this.TxtMontant);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(369, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 146);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mouvement";
            // 
            // CmbType2
            // 
            this.CmbType2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CmbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CmbType2.FormattingEnabled = true;
            this.CmbType2.Location = new System.Drawing.Point(294, 90);
            this.CmbType2.Name = "CmbType2";
            this.CmbType2.Size = new System.Drawing.Size(61, 24);
            this.CmbType2.TabIndex = 15;
            this.CmbType2.SelectedIndexChanged += new System.EventHandler(this.CmbTypeOperation_SelectedIndexChanged);
            // 
            // CmbType1
            // 
            this.CmbType1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CmbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CmbType1.FormattingEnabled = true;
            this.CmbType1.Location = new System.Drawing.Point(294, 55);
            this.CmbType1.Name = "CmbType1";
            this.CmbType1.Size = new System.Drawing.Size(61, 24);
            this.CmbType1.TabIndex = 14;
            this.CmbType1.SelectedIndexChanged += new System.EventHandler(this.CmbTypeOperation_SelectedIndexChanged);
            // 
            // CmbCmpt2
            // 
            this.CmbCmpt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CmbCmpt2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCmpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CmbCmpt2.FormattingEnabled = true;
            this.CmbCmpt2.Location = new System.Drawing.Point(113, 90);
            this.CmbCmpt2.Name = "CmbCmpt2";
            this.CmbCmpt2.Size = new System.Drawing.Size(169, 24);
            this.CmbCmpt2.TabIndex = 13;
            this.CmbCmpt2.SelectedIndexChanged += new System.EventHandler(this.CmbOperation_SelectedIndexChanged);
            // 
            // CmbCmpt1
            // 
            this.CmbCmpt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.CmbCmpt1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCmpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CmbCmpt1.FormattingEnabled = true;
            this.CmbCmpt1.Location = new System.Drawing.Point(113, 54);
            this.CmbCmpt1.Name = "CmbCmpt1";
            this.CmbCmpt1.Size = new System.Drawing.Size(169, 24);
            this.CmbCmpt1.TabIndex = 12;
            this.CmbCmpt1.SelectedIndexChanged += new System.EventHandler(this.CmbOperation_SelectedIndexChanged);
            // 
            // TxtMontant
            // 
            this.TxtMontant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TxtMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontant.Location = new System.Drawing.Point(113, 20);
            this.TxtMontant.Mask = "000000000";
            this.TxtMontant.Name = "TxtMontant";
            this.TxtMontant.Size = new System.Drawing.Size(242, 22);
            this.TxtMontant.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Compte 2 : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Compte 1 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Montant : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.groupBox2.Controls.Add(this.RbComptant);
            this.groupBox2.Controls.Add(this.RbCaisse);
            this.groupBox2.Controls.Add(this.DtDateOperation);
            this.groupBox2.Controls.Add(this.RbBanque);
            this.groupBox2.Controls.Add(this.TxtLibelleOperation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtIdOperation);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 146);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opération";
            // 
            // RbComptant
            // 
            this.RbComptant.AutoSize = true;
            this.RbComptant.Location = new System.Drawing.Point(247, 110);
            this.RbComptant.Name = "RbComptant";
            this.RbComptant.Size = new System.Drawing.Size(85, 17);
            this.RbComptant.TabIndex = 16;
            this.RbComptant.Text = "Au comptant";
            this.RbComptant.UseVisualStyleBackColor = true;
            // 
            // RbCaisse
            // 
            this.RbCaisse.AutoSize = true;
            this.RbCaisse.Checked = true;
            this.RbCaisse.Location = new System.Drawing.Point(134, 110);
            this.RbCaisse.Name = "RbCaisse";
            this.RbCaisse.Size = new System.Drawing.Size(74, 17);
            this.RbCaisse.TabIndex = 15;
            this.RbCaisse.TabStop = true;
            this.RbCaisse.Text = "Par caisse";
            this.RbCaisse.UseVisualStyleBackColor = true;
            // 
            // DtDateOperation
            // 
            this.DtDateOperation.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.DtDateOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DtDateOperation.Location = new System.Drawing.Point(115, 47);
            this.DtDateOperation.Name = "DtDateOperation";
            this.DtDateOperation.Size = new System.Drawing.Size(217, 22);
            this.DtDateOperation.TabIndex = 10;
            // 
            // RbBanque
            // 
            this.RbBanque.AutoSize = true;
            this.RbBanque.Location = new System.Drawing.Point(18, 110);
            this.RbBanque.Name = "RbBanque";
            this.RbBanque.Size = new System.Drawing.Size(80, 17);
            this.RbBanque.TabIndex = 14;
            this.RbBanque.Text = "Par banque";
            this.RbBanque.UseVisualStyleBackColor = true;
            // 
            // TxtLibelleOperation
            // 
            this.TxtLibelleOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TxtLibelleOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibelleOperation.Location = new System.Drawing.Point(115, 74);
            this.TxtLibelleOperation.Name = "TxtLibelleOperation";
            this.TxtLibelleOperation.Size = new System.Drawing.Size(217, 22);
            this.TxtLibelleOperation.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Libellé : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date : ";
            // 
            // TxtIdOperation
            // 
            this.TxtIdOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TxtIdOperation.Enabled = false;
            this.TxtIdOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIdOperation.Location = new System.Drawing.Point(115, 20);
            this.TxtIdOperation.Name = "TxtIdOperation";
            this.TxtIdOperation.Size = new System.Drawing.Size(217, 22);
            this.TxtIdOperation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code : ";
            // 
            // UcOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnlMainOperation);
            this.Controls.Add(this.PnelHeaderOperation);
            this.MinimumSize = new System.Drawing.Size(768, 470);
            this.Name = "UcOperation";
            this.Size = new System.Drawing.Size(768, 470);
            this.Load += new System.EventHandler(this.UcOperation_Load);
            this.PnelHeaderOperation.ResumeLayout(false);
            this.PnelHeaderOperation.PerformLayout();
            this.PnlMainOperation.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperation)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnelHeaderOperation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel PnlMainOperation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox TxtMontant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DtDateOperation;
        private System.Windows.Forms.TextBox TxtLibelleOperation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIdOperation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbComptant;
        private System.Windows.Forms.RadioButton RbCaisse;
        private System.Windows.Forms.RadioButton RbBanque;
        private System.Windows.Forms.ComboBox CmbCmpt2;
        private System.Windows.Forms.ComboBox CmbCmpt1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgvOperation;
        private System.Windows.Forms.ComboBox CmbType2;
        private System.Windows.Forms.ComboBox CmbType1;
        private System.Windows.Forms.Button BtnDeleteOperation;
        private System.Windows.Forms.Button BtnSaveOperation;
        private System.Windows.Forms.Button BtnNewOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCompteD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColTypeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColMontantD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColCompteC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColTypeC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvColMontantC;
        private System.Windows.Forms.Button BtnEditOperation;
    }
}
