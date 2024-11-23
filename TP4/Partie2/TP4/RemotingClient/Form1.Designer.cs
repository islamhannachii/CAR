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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.TextBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.category = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enseignantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.experience = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.compter = new System.Windows.Forms.Button();
            this.compterBox = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.matricule = new System.Windows.Forms.TextBox();
            this.matriculeLable = new System.Windows.Forms.Label();
            this.ajouter_Enseigne = new System.Windows.Forms.Button();
            this.afficher_enseigne = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cousrs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(459, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categorie";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(102, 96);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(234, 26);
            this.code.TabIndex = 5;
            this.code.TextChanged += new System.EventHandler(this.code_TextChanged);
            // 
            // designation
            // 
            this.designation.Location = new System.Drawing.Point(575, 92);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(234, 26);
            this.designation.TabIndex = 6;
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(128, 145);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(234, 26);
            this.volume.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter un cours";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "Afficher un cours";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(47, 382);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 62;
            this.table.RowTemplate.Height = 28;
            this.table.Size = new System.Drawing.Size(560, 187);
            this.table.TabIndex = 11;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.category.Location = new System.Drawing.Point(575, 143);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(234, 28);
            this.category.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coursToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coursToolStripMenuItem
            // 
            this.coursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enseignantsToolStripMenuItem});
            this.coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            this.coursToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.coursToolStripMenuItem.Text = "Cours";
            // 
            // enseignantsToolStripMenuItem
            // 
            this.enseignantsToolStripMenuItem.Name = "enseignantsToolStripMenuItem";
            this.enseignantsToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.enseignantsToolStripMenuItem.Text = "Enseignants";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enseigant:";
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(566, 244);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(234, 26);
            this.prenom.TabIndex = 18;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(106, 244);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(234, 26);
            this.nom.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Prenom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nom:";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(566, 290);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(234, 26);
            this.telephone.TabIndex = 22;
            this.telephone.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(106, 290);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(234, 26);
            this.email.TabIndex = 21;
            this.email.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Telephone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Email:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(178, 330);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(164, 26);
            this.experience.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Experience";
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "PROFESSEUR",
            "MCA",
            "MCB",
            "MAA"});
            this.grade.Location = new System.Drawing.Point(572, 329);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(188, 28);
            this.grade.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Grade:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(760, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 60);
            this.button3.TabIndex = 28;
            this.button3.Text = "Afficher un enseignant";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(760, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 58);
            this.button4.TabIndex = 27;
            this.button4.Text = "Ajouter un enseigant";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // compter
            // 
            this.compter.Location = new System.Drawing.Point(636, 520);
            this.compter.Name = "compter";
            this.compter.Size = new System.Drawing.Size(101, 49);
            this.compter.TabIndex = 29;
            this.compter.Text = "Compter";
            this.compter.UseVisualStyleBackColor = true;
            this.compter.Click += new System.EventHandler(this.compter_Click);
            // 
            // compterBox
            // 
            this.compterBox.Location = new System.Drawing.Point(760, 531);
            this.compterBox.Name = "compterBox";
            this.compterBox.Size = new System.Drawing.Size(106, 26);
            this.compterBox.TabIndex = 30;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(790, 589);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(101, 49);
            this.Exit.TabIndex = 31;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // matricule
            // 
            this.matricule.Location = new System.Drawing.Point(567, 208);
            this.matricule.Name = "matricule";
            this.matricule.Size = new System.Drawing.Size(234, 26);
            this.matricule.TabIndex = 33;
            // 
            // matriculeLable
            // 
            this.matriculeLable.AutoSize = true;
            this.matriculeLable.Location = new System.Drawing.Point(453, 208);
            this.matriculeLable.Name = "matriculeLable";
            this.matriculeLable.Size = new System.Drawing.Size(73, 20);
            this.matriculeLable.TabIndex = 32;
            this.matriculeLable.Text = "Matricule";
            // 
            // ajouter_Enseigne
            // 
            this.ajouter_Enseigne.Location = new System.Drawing.Point(897, 382);
            this.ajouter_Enseigne.Name = "ajouter_Enseigne";
            this.ajouter_Enseigne.Size = new System.Drawing.Size(105, 58);
            this.ajouter_Enseigne.TabIndex = 34;
            this.ajouter_Enseigne.Text = "Ajouter Enseigne";
            this.ajouter_Enseigne.UseVisualStyleBackColor = true;
            this.ajouter_Enseigne.Click += new System.EventHandler(this.ajouter_Enseigne_Click);
            // 
            // afficher_enseigne
            // 
            this.afficher_enseigne.Location = new System.Drawing.Point(897, 444);
            this.afficher_enseigne.Name = "afficher_enseigne";
            this.afficher_enseigne.Size = new System.Drawing.Size(105, 58);
            this.afficher_enseigne.TabIndex = 35;
            this.afficher_enseigne.Text = "Afficher Enseigne";
            this.afficher_enseigne.UseVisualStyleBackColor = true;
            this.afficher_enseigne.Click += new System.EventHandler(this.afficher_enseigne_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(857, 165);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 63);
            this.button5.TabIndex = 36;
            this.button5.Text = "Supprimer Enseignant";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(857, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 63);
            this.button6.TabIndex = 37;
            this.button6.Text = "Supprmier Cours";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(897, 508);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 61);
            this.button7.TabIndex = 38;
            this.button7.Text = "Join enseigne";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(857, 253);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 63);
            this.button8.TabIndex = 39;
            this.button8.Text = "Supprimer Enseigne";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 649);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.afficher_enseigne);
            this.Controls.Add(this.ajouter_Enseigne);
            this.Controls.Add(this.matricule);
            this.Controls.Add(this.matriculeLable);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.compterBox);
            this.Controls.Add(this.compter);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
            this.Controls.Add(this.table);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.TextBox designation;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enseignantsToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox experience;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button compter;
        private System.Windows.Forms.TextBox compterBox;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox matricule;
        private System.Windows.Forms.Label matriculeLable;
        private System.Windows.Forms.Button ajouter_Enseigne;
        private System.Windows.Forms.Button afficher_enseigne;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

