namespace NewVoyage
{
    partial class FormVoyage
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
            this.lDestination = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnResa = new System.Windows.Forms.Button();
            this.lblPlDispo = new System.Windows.Forms.Label();
            this.lblTaxe = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDateR = new System.Windows.Forms.Label();
            this.lblDateD = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lReservations = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lDestination
            // 
            this.lDestination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lDestination.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDestination.FormattingEnabled = true;
            this.lDestination.ItemHeight = 26;
            this.lDestination.Location = new System.Drawing.Point(63, 117);
            this.lDestination.Name = "lDestination";
            this.lDestination.Size = new System.Drawing.Size(213, 186);
            this.lDestination.TabIndex = 0;
            this.lDestination.SelectedIndexChanged += new System.EventHandler(this.lDestination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selectionnez une destination:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lDestination);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(44, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 347);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinations";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnResa);
            this.groupBox2.Controls.Add(this.lblPlDispo);
            this.groupBox2.Controls.Add(this.lblTaxe);
            this.groupBox2.Controls.Add(this.lblPrix);
            this.groupBox2.Controls.Add(this.lblDateR);
            this.groupBox2.Controls.Add(this.lblDateD);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(405, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(436, 347);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations sur le voyage";
            // 
            // btnResa
            // 
            this.btnResa.BackColor = System.Drawing.Color.Gold;
            this.btnResa.Enabled = false;
            this.btnResa.Location = new System.Drawing.Point(146, 277);
            this.btnResa.Name = "btnResa";
            this.btnResa.Size = new System.Drawing.Size(129, 40);
            this.btnResa.TabIndex = 11;
            this.btnResa.Text = "Reserver";
            this.btnResa.UseVisualStyleBackColor = false;
            this.btnResa.Click += new System.EventHandler(this.btnResa_Click);
            // 
            // lblPlDispo
            // 
            this.lblPlDispo.AutoSize = true;
            this.lblPlDispo.Location = new System.Drawing.Point(233, 222);
            this.lblPlDispo.Name = "lblPlDispo";
            this.lblPlDispo.Size = new System.Drawing.Size(0, 22);
            this.lblPlDispo.TabIndex = 10;
            // 
            // lblTaxe
            // 
            this.lblTaxe.AutoSize = true;
            this.lblTaxe.Location = new System.Drawing.Point(233, 180);
            this.lblTaxe.Name = "lblTaxe";
            this.lblTaxe.Size = new System.Drawing.Size(0, 22);
            this.lblTaxe.TabIndex = 9;
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(233, 139);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(0, 22);
            this.lblPrix.TabIndex = 8;
            // 
            // lblDateR
            // 
            this.lblDateR.AutoSize = true;
            this.lblDateR.Location = new System.Drawing.Point(233, 96);
            this.lblDateR.Name = "lblDateR";
            this.lblDateR.Size = new System.Drawing.Size(0, 22);
            this.lblDateR.TabIndex = 7;
            // 
            // lblDateD
            // 
            this.lblDateD.AutoSize = true;
            this.lblDateD.Location = new System.Drawing.Point(233, 55);
            this.lblDateD.Name = "lblDateD";
            this.lblDateD.Size = new System.Drawing.Size(0, 22);
            this.lblDateD.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Places Disponibles: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Taxe: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Prix du billet: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date Retour: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Départ: ";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(168, 386);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 20);
            this.lblWarning.TabIndex = 5;
            // 
            // lReservations
            // 
            this.lReservations.BackColor = System.Drawing.Color.Khaki;
            this.lReservations.Font = new System.Drawing.Font("Cascadia Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.lReservations.FormattingEnabled = true;
            this.lReservations.ItemHeight = 17;
            this.lReservations.Location = new System.Drawing.Point(44, 409);
            this.lReservations.Name = "lReservations";
            this.lReservations.Size = new System.Drawing.Size(797, 140);
            this.lReservations.TabIndex = 6;
            // 
            // FormVoyage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(909, 618);
            this.Controls.Add(this.lReservations);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblWarning);
            this.Name = "FormVoyage";
            this.Text = "FormVoyage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVoyage_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPlDispo;
        private System.Windows.Forms.Label lblTaxe;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDateR;
        private System.Windows.Forms.Label lblDateD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnResa;
        private System.Windows.Forms.ListBox lReservations;
    }
}

