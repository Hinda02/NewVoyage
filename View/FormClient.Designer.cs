namespace NewVoyage
{
    partial class FormClient
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
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lResa = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.tbAdresse = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(24, 11);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(53, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mail : ";
            // 
            // lResa
            // 
            this.lResa.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lResa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResa.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lResa.FormattingEnabled = true;
            this.lResa.ItemHeight = 18;
            this.lResa.Location = new System.Drawing.Point(38, 262);
            this.lResa.MultiColumn = true;
            this.lResa.Name = "lResa";
            this.lResa.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lResa.Size = new System.Drawing.Size(389, 130);
            this.lResa.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.tbMail);
            this.panel1.Controls.Add(this.tbAdresse);
            this.panel1.Controls.Add(this.tbTel);
            this.panel1.Controls.Add(this.tbPrenom);
            this.panel1.Controls.Add(this.tbNom);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 222);
            this.panel1.TabIndex = 7;
            // 
            // tbMail
            // 
            this.tbMail.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbMail.Location = new System.Drawing.Point(144, 178);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(213, 27);
            this.tbMail.TabIndex = 10;
            // 
            // tbAdresse
            // 
            this.tbAdresse.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbAdresse.Location = new System.Drawing.Point(144, 146);
            this.tbAdresse.Name = "tbAdresse";
            this.tbAdresse.Size = new System.Drawing.Size(213, 27);
            this.tbAdresse.TabIndex = 9;
            // 
            // tbTel
            // 
            this.tbTel.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbTel.Location = new System.Drawing.Point(144, 112);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(213, 27);
            this.tbTel.TabIndex = 8;
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbPrenom.Location = new System.Drawing.Point(144, 77);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(213, 27);
            this.tbPrenom.TabIndex = 7;
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.LemonChiffon;
            this.tbNom.Location = new System.Drawing.Point(144, 44);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(213, 27);
            this.tbNom.TabIndex = 6;
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.Salmon;
            this.btnFermer.Location = new System.Drawing.Point(73, 409);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(140, 41);
            this.btnFermer.TabIndex = 8;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnModifier.Location = new System.Drawing.Point(243, 409);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(140, 41);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(466, 474);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lResa);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lResa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.TextBox tbAdresse;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnModifier;
    }
}