namespace GSB {
    partial class FrmPraticienAjout {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nomChamp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prenomChamp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rueChamp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telChamp = new System.Windows.Forms.TextBox();
            this.mailChamp = new System.Windows.Forms.TextBox();
            this.villeChamp = new System.Windows.Forms.ComboBox();
            this.lesTypesBox = new System.Windows.Forms.ComboBox();
            this.lesSpecialitesBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(809, 64);
            this.lblTitre.Text = "Ajout d\'un praticien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.Red;
            this.btnAjouter.Location = new System.Drawing.Point(346, 336);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(139, 27);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nomChamp
            // 
            this.nomChamp.Location = new System.Drawing.Point(88, 109);
            this.nomChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nomChamp.Name = "nomChamp";
            this.nomChamp.Size = new System.Drawing.Size(258, 20);
            this.nomChamp.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prénom";
            // 
            // prenomChamp
            // 
            this.prenomChamp.Location = new System.Drawing.Point(486, 109);
            this.prenomChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prenomChamp.Name = "prenomChamp";
            this.prenomChamp.Size = new System.Drawing.Size(243, 20);
            this.prenomChamp.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Rue";
            // 
            // rueChamp
            // 
            this.rueChamp.Location = new System.Drawing.Point(88, 154);
            this.rueChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rueChamp.Name = "rueChamp";
            this.rueChamp.Size = new System.Drawing.Size(641, 20);
            this.rueChamp.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ville";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(483, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Spécialité";
            // 
            // telChamp
            // 
            this.telChamp.Location = new System.Drawing.Point(88, 249);
            this.telChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.telChamp.Name = "telChamp";
            this.telChamp.Size = new System.Drawing.Size(258, 20);
            this.telChamp.TabIndex = 30;
            // 
            // mailChamp
            // 
            this.mailChamp.Location = new System.Drawing.Point(486, 249);
            this.mailChamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mailChamp.Name = "mailChamp";
            this.mailChamp.Size = new System.Drawing.Size(243, 20);
            this.mailChamp.TabIndex = 31;
            // 
            // villeChamp
            // 
            this.villeChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.villeChamp.FormattingEnabled = true;
            this.villeChamp.Location = new System.Drawing.Point(121, 186);
            this.villeChamp.Name = "villeChamp";
            this.villeChamp.Size = new System.Drawing.Size(608, 21);
            this.villeChamp.TabIndex = 32;
            // 
            // lesTypesBox
            // 
            this.lesTypesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesTypesBox.FormattingEnabled = true;
            this.lesTypesBox.Location = new System.Drawing.Point(88, 297);
            this.lesTypesBox.Name = "lesTypesBox";
            this.lesTypesBox.Size = new System.Drawing.Size(258, 21);
            this.lesTypesBox.TabIndex = 33;
            // 
            // lesSpecialitesBox
            // 
            this.lesSpecialitesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesSpecialitesBox.FormattingEnabled = true;
            this.lesSpecialitesBox.Location = new System.Drawing.Point(486, 297);
            this.lesSpecialitesBox.Name = "lesSpecialitesBox";
            this.lesSpecialitesBox.Size = new System.Drawing.Size(243, 21);
            this.lesSpecialitesBox.TabIndex = 34;
            // 
            // FrmPraticienAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 422);
            this.Controls.Add(this.lesSpecialitesBox);
            this.Controls.Add(this.lesTypesBox);
            this.Controls.Add(this.villeChamp);
            this.Controls.Add(this.mailChamp);
            this.Controls.Add(this.telChamp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rueChamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenomChamp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomChamp);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Name = "FrmPraticienAjout";
            this.Text = "FrmPraticienAjout";
            this.Load += new System.EventHandler(this.FrmPraticienAjout_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnAjouter, 0);
            this.Controls.SetChildIndex(this.nomChamp, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.prenomChamp, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.rueChamp, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.telChamp, 0);
            this.Controls.SetChildIndex(this.mailChamp, 0);
            this.Controls.SetChildIndex(this.villeChamp, 0);
            this.Controls.SetChildIndex(this.lesTypesBox, 0);
            this.Controls.SetChildIndex(this.lesSpecialitesBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox nomChamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prenomChamp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rueChamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telChamp;
        private System.Windows.Forms.TextBox mailChamp;
        private System.Windows.Forms.ComboBox villeChamp;
        private System.Windows.Forms.ComboBox lesTypesBox;
        private System.Windows.Forms.ComboBox lesSpecialitesBox;
    }
}