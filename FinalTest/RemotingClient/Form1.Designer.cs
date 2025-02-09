namespace RemotingClient
{
    partial class Form1
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.titre = new System.Windows.Forms.TextBox();
            this.langue = new System.Windows.Forms.TextBox();
            this.annee = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.matricule = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lableee = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ajouter catalogue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Annee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Langue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titre";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(122, 232);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(197, 26);
            this.code.TabIndex = 7;
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(485, 235);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(197, 26);
            this.titre.TabIndex = 8;
            // 
            // langue
            // 
            this.langue.Location = new System.Drawing.Point(122, 288);
            this.langue.Name = "langue";
            this.langue.Size = new System.Drawing.Size(197, 26);
            this.langue.TabIndex = 9;
            // 
            // annee
            // 
            this.annee.Location = new System.Drawing.Point(520, 288);
            this.annee.Name = "annee";
            this.annee.Size = new System.Drawing.Size(134, 26);
            this.annee.TabIndex = 10;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(120, 155);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(197, 26);
            this.prenom.TabIndex = 17;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(485, 102);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(197, 26);
            this.nom.TabIndex = 16;
            // 
            // matricule
            // 
            this.matricule.Location = new System.Drawing.Point(120, 99);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(197, 26);
            this.matricule.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nom";
            // 
            // lableee
            // 
            this.lableee.AutoSize = true;
            this.lableee.Location = new System.Drawing.Point(46, 155);
            this.lableee.Name = "lableee";
            this.lableee.Size = new System.Drawing.Size(64, 20);
            this.lableee.TabIndex = 12;
            this.lableee.Text = "Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Matricule";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 65);
            this.button1.TabIndex = 18;
            this.button1.Text = "Afficher xml";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lableee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.annee);
            this.Controls.Add(this.langue);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox titre;
        private System.Windows.Forms.TextBox langue;
        private System.Windows.Forms.TextBox annee;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox matricule;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lableee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}

