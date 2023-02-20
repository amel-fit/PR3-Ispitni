namespace DLWMS.WinForms.IB210000
{
    partial class frmUvjerenjaIB210000
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
            this.dgvUvjerenja = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vrsta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Svrha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uplatnica = new System.Windows.Forms.DataGridViewImageColumn();
            this.Printano = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Printaj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNovoUvjerenje = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtBrojUvjerenja = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUvjerenja
            // 
            this.dgvUvjerenja.AllowUserToAddRows = false;
            this.dgvUvjerenja.AllowUserToDeleteRows = false;
            this.dgvUvjerenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUvjerenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Vrsta,
            this.Svrha,
            this.Uplatnica,
            this.Printano,
            this.Brisi,
            this.Printaj});
            this.dgvUvjerenja.Location = new System.Drawing.Point(12, 40);
            this.dgvUvjerenja.Name = "dgvUvjerenja";
            this.dgvUvjerenja.RowTemplate.Height = 25;
            this.dgvUvjerenja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUvjerenja.Size = new System.Drawing.Size(790, 229);
            this.dgvUvjerenja.TabIndex = 0;
            this.dgvUvjerenja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUvjerenja_CellClick);
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Datum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Vrsta
            // 
            this.Vrsta.DataPropertyName = "Vrsta";
            this.Vrsta.HeaderText = "Vrsta";
            this.Vrsta.Name = "Vrsta";
            this.Vrsta.Width = 120;
            // 
            // Svrha
            // 
            this.Svrha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Svrha.DataPropertyName = "Svrha";
            this.Svrha.HeaderText = "Svrha";
            this.Svrha.Name = "Svrha";
            // 
            // Uplatnica
            // 
            this.Uplatnica.DataPropertyName = "Uplatnica";
            this.Uplatnica.HeaderText = "Uplatnica";
            this.Uplatnica.Name = "Uplatnica";
            this.Uplatnica.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uplatnica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Printano
            // 
            this.Printano.DataPropertyName = "Printano";
            this.Printano.HeaderText = "Printano";
            this.Printano.Name = "Printano";
            this.Printano.Width = 70;
            // 
            // Brisi
            // 
            this.Brisi.HeaderText = "";
            this.Brisi.Name = "Brisi";
            this.Brisi.Text = "Brisi";
            this.Brisi.UseColumnTextForButtonValue = true;
            // 
            // Printaj
            // 
            this.Printaj.HeaderText = "";
            this.Printaj.Name = "Printaj";
            this.Printaj.Text = "Printaj";
            this.Printaj.UseColumnTextForButtonValue = true;
            // 
            // btnNovoUvjerenje
            // 
            this.btnNovoUvjerenje.Location = new System.Drawing.Point(690, 8);
            this.btnNovoUvjerenje.Name = "btnNovoUvjerenje";
            this.btnNovoUvjerenje.Size = new System.Drawing.Size(112, 26);
            this.btnNovoUvjerenje.TabIndex = 1;
            this.btnNovoUvjerenje.Text = "Novi zahtjev";
            this.btnNovoUvjerenje.UseVisualStyleBackColor = true;
            this.btnNovoUvjerenje.Click += new System.EventHandler(this.btnNovoUvjerenje_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.btnDodaj);
            this.groupBox1.Controls.Add(this.txtBrojUvjerenja);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSvrha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbVrsta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodavanje zahtjeva za izdavanjem uvjerenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Info:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(6, 90);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(784, 165);
            this.txtInfo.TabIndex = 8;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(676, 37);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(114, 23);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.Text = "Dodaj =>";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtBrojUvjerenja
            // 
            this.txtBrojUvjerenja.Location = new System.Drawing.Point(558, 37);
            this.txtBrojUvjerenja.Name = "txtBrojUvjerenja";
            this.txtBrojUvjerenja.Size = new System.Drawing.Size(112, 23);
            this.txtBrojUvjerenja.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(558, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Broj zahtjeva:";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Location = new System.Drawing.Point(241, 37);
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(309, 23);
            this.txtSvrha.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Svrha izdavanja:";
            // 
            // cmbVrsta
            // 
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.FormattingEnabled = true;
            this.cmbVrsta.Location = new System.Drawing.Point(6, 37);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(229, 23);
            this.cmbVrsta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vrsta uvjerenja:";
            // 
            // frmUvjerenjaIB210000
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNovoUvjerenje);
            this.Controls.Add(this.dgvUvjerenja);
            this.Name = "frmUvjerenjaIB210000";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broj uvjerenja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUvjerenja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvUvjerenja;
        private Button btnNovoUvjerenje;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtInfo;
        private Button btnDodaj;
        private TextBox txtBrojUvjerenja;
        private Label label3;
        private TextBox txtSvrha;
        private Label label2;
        private ComboBox cmbVrsta;
        private Label label1;
        private DataGridViewTextBoxColumn Datum;
        private DataGridViewTextBoxColumn Vrsta;
        private DataGridViewTextBoxColumn Svrha;
        private DataGridViewImageColumn Uplatnica;
        private DataGridViewCheckBoxColumn Printano;
        private DataGridViewButtonColumn Brisi;
        private DataGridViewButtonColumn Printaj;
    }
}