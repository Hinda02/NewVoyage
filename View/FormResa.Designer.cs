namespace NewVoyage
{
    partial class FormResa
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
            this.tbNbPers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.btnNbPers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.cbClient = new System.Windows.Forms.CheckBox();
            this.cbCFidele = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTypeCli = new System.Windows.Forms.Button();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbNbPers
            // 
            this.tbNbPers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNbPers.Location = new System.Drawing.Point(476, 404);
            this.tbNbPers.MaxLength = 3;
            this.tbNbPers.Name = "tbNbPers";
            this.tbNbPers.Size = new System.Drawing.Size(100, 26);
            this.tbNbPers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de place à reserver:";
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmer.Location = new System.Drawing.Point(415, 497);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(136, 40);
            this.btnConfirmer.TabIndex = 2;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Visible = false;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.BackColor = System.Drawing.Color.Transparent;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblResultat.ForeColor = System.Drawing.Color.Green;
            this.lblResultat.Location = new System.Drawing.Point(231, 448);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(0, 24);
            this.lblResultat.TabIndex = 3;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestination.Location = new System.Drawing.Point(316, 10);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(0, 27);
            this.lblDestination.TabIndex = 4;
            // 
            // btnNbPers
            // 
            this.btnNbPers.BackColor = System.Drawing.Color.Gold;
            this.btnNbPers.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNbPers.Location = new System.Drawing.Point(598, 400);
            this.btnNbPers.Name = "btnNbPers";
            this.btnNbPers.Size = new System.Drawing.Size(38, 35);
            this.btnNbPers.TabIndex = 5;
            this.btnNbPers.Text = ">";
            this.btnNbPers.UseVisualStyleBackColor = false;
            this.btnNbPers.Click += new System.EventHandler(this.btnNbPers_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.lblDestination);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 47);
            this.panel1.TabIndex = 6;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.LightCoral;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(248, 497);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(134, 40);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // cbClient
            // 
            this.cbClient.AutoSize = true;
            this.cbClient.Location = new System.Drawing.Point(117, 25);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(67, 22);
            this.cbClient.TabIndex = 18;
            this.cbClient.Text = "Client";
            this.cbClient.UseVisualStyleBackColor = true;
            // 
            // cbCFidele
            // 
            this.cbCFidele.AutoSize = true;
            this.cbCFidele.Location = new System.Drawing.Point(117, 52);
            this.cbCFidele.Name = "cbCFidele";
            this.cbCFidele.Size = new System.Drawing.Size(110, 22);
            this.cbCFidele.TabIndex = 19;
            this.cbCFidele.Text = "Client Fidèle";
            this.cbCFidele.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTypeCli);
            this.groupBox1.Controls.Add(this.lbClients);
            this.groupBox1.Controls.Add(this.cbCFidele);
            this.groupBox1.Controls.Add(this.cbClient);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 278);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ancien Client";
            // 
            // btnTypeCli
            // 
            this.btnTypeCli.Location = new System.Drawing.Point(265, 30);
            this.btnTypeCli.Name = "btnTypeCli";
            this.btnTypeCli.Size = new System.Drawing.Size(40, 39);
            this.btnTypeCli.TabIndex = 21;
            this.btnTypeCli.Text = ">";
            this.btnTypeCli.UseVisualStyleBackColor = true;
            this.btnTypeCli.Click += new System.EventHandler(this.btnTypeCli_Click);
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.ItemHeight = 18;
            this.lbClients.Location = new System.Drawing.Point(19, 94);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(297, 166);
            this.lbClients.TabIndex = 20;
            this.lbClients.SelectedIndexChanged += new System.EventHandler(this.lbClients_SelectedIndexChanged);
            this.lbClients.DoubleClick += new System.EventHandler(this.lbClients_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnInscrire);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.txtAdresse);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(408, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 278);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nouveau Client";
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(152, 230);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(115, 33);
            this.btnInscrire.TabIndex = 10;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(136, 182);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(152, 24);
            this.txtMail.TabIndex = 9;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(136, 145);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(152, 24);
            this.txtAdresse.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(136, 109);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(152, 24);
            this.txtTel.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(136, 74);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(152, 24);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(136, 40);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(152, 24);
            this.txtNom.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mail : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Adresse : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tel : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Prénom : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nom : ";
            // 
            // FormResa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(802, 593);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNbPers);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNbPers);
            this.Name = "FormResa";
            this.Text = "FormResa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNbPers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Button btnNbPers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.CheckBox cbClient;
        private System.Windows.Forms.CheckBox cbCFidele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Button btnTypeCli;
    }
}