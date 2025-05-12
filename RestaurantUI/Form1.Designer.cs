namespace RestaurantUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpNouaComanda = new System.Windows.Forms.GroupBox();
            this.btnStergeProdus = new System.Windows.Forms.Button();
            this.lblTotalComanda = new System.Windows.Forms.Label();
            this.lstProduseComanda = new System.Windows.Forms.ListBox();
            this.btnFinalizareComanda = new System.Windows.Forms.Button();
            this.btnAdaugaProdus = new System.Windows.Forms.Button();
            this.cmbCategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPretProdus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeProdus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpCautare = new System.Windows.Forms.GroupBox();
            this.btnCautaMasa = new System.Windows.Forms.Button();
            this.txtCautaMasa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCautaId = new System.Windows.Forms.Button();
            this.txtCautaId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpListaComenzi = new System.Windows.Forms.GroupBox();
            this.btnStergeComanda = new System.Windows.Forms.Button();
            this.lstComenzi = new System.Windows.Forms.ListBox();
            this.grpNouaComanda.SuspendLayout();
            this.grpCautare.SuspendLayout();
            this.grpListaComenzi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNouaComanda
            // 
            this.grpNouaComanda.Controls.Add(this.btnStergeProdus);
            this.grpNouaComanda.Controls.Add(this.lblTotalComanda);
            this.grpNouaComanda.Controls.Add(this.lstProduseComanda);
            this.grpNouaComanda.Controls.Add(this.btnFinalizareComanda);
            this.grpNouaComanda.Controls.Add(this.btnAdaugaProdus);
            this.grpNouaComanda.Controls.Add(this.cmbCategorie);
            this.grpNouaComanda.Controls.Add(this.label3);
            this.grpNouaComanda.Controls.Add(this.txtPretProdus);
            this.grpNouaComanda.Controls.Add(this.label2);
            this.grpNouaComanda.Controls.Add(this.txtNumeProdus);
            this.grpNouaComanda.Controls.Add(this.label1);
            this.grpNouaComanda.Controls.Add(this.txtMasa);
            this.grpNouaComanda.Controls.Add(this.label4);
            this.grpNouaComanda.Location = new System.Drawing.Point(12, 12);
            this.grpNouaComanda.Name = "grpNouaComanda";
            this.grpNouaComanda.Size = new System.Drawing.Size(350, 500);
            this.grpNouaComanda.TabIndex = 0;
            this.grpNouaComanda.TabStop = false;
            this.grpNouaComanda.Text = "Nouă Comandă";
            // 
            // btnStergeProdus
            // 
            this.btnStergeProdus.Location = new System.Drawing.Point(180, 460);
            this.btnStergeProdus.Name = "btnStergeProdus";
            this.btnStergeProdus.Size = new System.Drawing.Size(150, 30);
            this.btnStergeProdus.TabIndex = 12;
            this.btnStergeProdus.Text = "Șterge Produs";
            this.btnStergeProdus.UseVisualStyleBackColor = true;
            this.btnStergeProdus.Click += new System.EventHandler(this.btnStergeProdus_Click);
            // 
            // lblTotalComanda
            // 
            this.lblTotalComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalComanda.Location = new System.Drawing.Point(10, 430);
            this.lblTotalComanda.Name = "lblTotalComanda";
            this.lblTotalComanda.Size = new System.Drawing.Size(320, 20);
            this.lblTotalComanda.TabIndex = 11;
            this.lblTotalComanda.Text = "Total: 0 RON";
            this.lblTotalComanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lstProduseComanda
            // 
            this.lstProduseComanda.FormattingEnabled = true;
            this.lstProduseComanda.ItemHeight = 16;
            this.lstProduseComanda.Location = new System.Drawing.Point(10, 220);
            this.lstProduseComanda.Name = "lstProduseComanda";
            this.lstProduseComanda.Size = new System.Drawing.Size(320, 196);
            this.lstProduseComanda.TabIndex = 10;
            // 
            // btnFinalizareComanda
            // 
            this.btnFinalizareComanda.Location = new System.Drawing.Point(10, 460);
            this.btnFinalizareComanda.Name = "btnFinalizareComanda";
            this.btnFinalizareComanda.Size = new System.Drawing.Size(150, 30);
            this.btnFinalizareComanda.TabIndex = 9;
            this.btnFinalizareComanda.Text = "Finalizează Comanda";
            this.btnFinalizareComanda.UseVisualStyleBackColor = true;
            this.btnFinalizareComanda.Click += new System.EventHandler(this.btnFinalizareComanda_Click);
            // 
            // btnAdaugaProdus
            // 
            this.btnAdaugaProdus.Location = new System.Drawing.Point(10, 180);
            this.btnAdaugaProdus.Name = "btnAdaugaProdus";
            this.btnAdaugaProdus.Size = new System.Drawing.Size(320, 30);
            this.btnAdaugaProdus.TabIndex = 8;
            this.btnAdaugaProdus.Text = "Adaugă Produs la Comandă";
            this.btnAdaugaProdus.UseVisualStyleBackColor = true;
            this.btnAdaugaProdus.Click += new System.EventHandler(this.btnAdaugaProdus_Click);
            // 
            // cmbCategorie
            // 
            this.cmbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategorie.FormattingEnabled = true;
            this.cmbCategorie.Location = new System.Drawing.Point(10, 140);
            this.cmbCategorie.Name = "cmbCategorie";
            this.cmbCategorie.Size = new System.Drawing.Size(220, 24);
            this.cmbCategorie.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categorie:";
            // 
            // txtPretProdus
            // 
            this.txtPretProdus.Location = new System.Drawing.Point(10, 90);
            this.txtPretProdus.Name = "txtPretProdus";
            this.txtPretProdus.Size = new System.Drawing.Size(220, 22);
            this.txtPretProdus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Preț:";
            // 
            // txtNumeProdus
            // 
            this.txtNumeProdus.Location = new System.Drawing.Point(10, 40);
            this.txtNumeProdus.Name = "txtNumeProdus";
            this.txtNumeProdus.Size = new System.Drawing.Size(220, 22);
            this.txtNumeProdus.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nume Produs:";
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(240, 40);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(90, 22);
            this.txtMasa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Masă:";
            // 
            // grpCautare
            // 
            this.grpCautare.Controls.Add(this.btnCautaMasa);
            this.grpCautare.Controls.Add(this.txtCautaMasa);
            this.grpCautare.Controls.Add(this.label6);
            this.grpCautare.Controls.Add(this.btnRefresh);
            this.grpCautare.Controls.Add(this.btnCautaId);
            this.grpCautare.Controls.Add(this.txtCautaId);
            this.grpCautare.Controls.Add(this.label5);
            this.grpCautare.Location = new System.Drawing.Point(380, 12);
            this.grpCautare.Name = "grpCautare";
            this.grpCautare.Size = new System.Drawing.Size(350, 150);
            this.grpCautare.TabIndex = 1;
            this.grpCautare.TabStop = false;
            this.grpCautare.Text = "Căutare Comenzi";
            // 
            // btnCautaMasa
            // 
            this.btnCautaMasa.Location = new System.Drawing.Point(180, 90);
            this.btnCautaMasa.Name = "btnCautaMasa";
            this.btnCautaMasa.Size = new System.Drawing.Size(150, 30);
            this.btnCautaMasa.TabIndex = 6;
            this.btnCautaMasa.Text = "Caută după Masă";
            this.btnCautaMasa.UseVisualStyleBackColor = true;
            this.btnCautaMasa.Click += new System.EventHandler(this.btnCautaMasa_Click);
            // 
            // txtCautaMasa
            // 
            this.txtCautaMasa.Location = new System.Drawing.Point(10, 100);
            this.txtCautaMasa.Name = "txtCautaMasa";
            this.txtCautaMasa.Size = new System.Drawing.Size(150, 22);
            this.txtCautaMasa.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Masă:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(240, 40);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCautaId
            // 
            this.btnCautaId.Location = new System.Drawing.Point(180, 40);
            this.btnCautaId.Name = "btnCautaId";
            this.btnCautaId.Size = new System.Drawing.Size(50, 30);
            this.btnCautaId.TabIndex = 2;
            this.btnCautaId.Text = "Caută";
            this.btnCautaId.UseVisualStyleBackColor = true;
            this.btnCautaId.Click += new System.EventHandler(this.btnCautaId_Click);
            // 
            // txtCautaId
            // 
            this.txtCautaId.Location = new System.Drawing.Point(10, 50);
            this.txtCautaId.Name = "txtCautaId";
            this.txtCautaId.Size = new System.Drawing.Size(150, 22);
            this.txtCautaId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // grpListaComenzi
            // 
            this.grpListaComenzi.Controls.Add(this.btnStergeComanda);
            this.grpListaComenzi.Controls.Add(this.lstComenzi);
            this.grpListaComenzi.Location = new System.Drawing.Point(380, 170);
            this.grpListaComenzi.Name = "grpListaComenzi";
            this.grpListaComenzi.Size = new System.Drawing.Size(350, 342);
            this.grpListaComenzi.TabIndex = 2;
            this.grpListaComenzi.TabStop = false;
            this.grpListaComenzi.Text = "Listă Comenzi";
            // 
            // btnStergeComanda
            // 
            this.btnStergeComanda.Location = new System.Drawing.Point(10, 300);
            this.btnStergeComanda.Name = "btnStergeComanda";
            this.btnStergeComanda.Size = new System.Drawing.Size(330, 30);
            this.btnStergeComanda.TabIndex = 1;
            this.btnStergeComanda.Text = "Șterge Comanda Selectată";
            this.btnStergeComanda.UseVisualStyleBackColor = true;
            this.btnStergeComanda.Click += new System.EventHandler(this.btnStergeComanda_Click);
            // 
            // lstComenzi
            // 
            this.lstComenzi.FormattingEnabled = true;
            this.lstComenzi.HorizontalScrollbar = true;
            this.lstComenzi.ItemHeight = 16;
            this.lstComenzi.Location = new System.Drawing.Point(10, 20);
            this.lstComenzi.Name = "lstComenzi";
            this.lstComenzi.Size = new System.Drawing.Size(330, 260);
            this.lstComenzi.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 523);
            this.Controls.Add(this.grpListaComenzi);
            this.Controls.Add(this.grpCautare);
            this.Controls.Add(this.grpNouaComanda);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Management System";
            this.grpNouaComanda.ResumeLayout(false);
            this.grpNouaComanda.PerformLayout();
            this.grpCautare.ResumeLayout(false);
            this.grpCautare.PerformLayout();
            this.grpListaComenzi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNouaComanda;
        private System.Windows.Forms.Button btnAdaugaProdus;
        private System.Windows.Forms.ComboBox cmbCategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPretProdus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeProdus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCautare;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCautaId;
        private System.Windows.Forms.TextBox txtCautaId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpListaComenzi;
        private System.Windows.Forms.ListBox lstComenzi;
        private System.Windows.Forms.Button btnFinalizareComanda;
        private System.Windows.Forms.ListBox lstProduseComanda;
        private System.Windows.Forms.Label lblTotalComanda;
        private System.Windows.Forms.Button btnStergeProdus;
        private System.Windows.Forms.Button btnCautaMasa;
        private System.Windows.Forms.TextBox txtCautaMasa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnStergeComanda;
        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.Label label4;
    }
}