namespace TP1_Partie2

{
    partial class CalculatriceForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatriceForm));
            point = new Button();
            plus = new Button();
            egale = new Button();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            moins = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            star = new Button();
            inverse = new Button();
            num7 = new Button();
            num8 = new Button();
            num9 = new Button();
            division = new Button();
            pourcent = new Button();
            fleche = new Button();
            CE = new Button();
            c = new Button();
            PlusMoins = new Button();
            racine = new Button();
            MC = new Button();
            MR = new Button();
            MS = new Button();
            MPlus = new Button();
            MMoins = new Button();
            num0 = new Button();
            Resultat = new TextBox();
            toolStrip1 = new ToolStrip();
            toolStripSplitButton1 = new ToolStripSplitButton();
            standardToolStripMenuItem = new ToolStripMenuItem();
            historiqueToolStripMenuItem = new ToolStripMenuItem();
            toolStripSplitButton2 = new ToolStripSplitButton();
            ediToolStripMenuItem = new ToolStripMenuItem();
            historiqueToolStripMenuItem1 = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // point
            // 
            point.Location = new Point(275, 488);
            point.Name = "point";
            point.Size = new Size(114, 58);
            point.TabIndex = 2;
            point.Text = ".";
            point.UseVisualStyleBackColor = true;
            point.Click += Point;
            // 
            // plus
            // 
            plus.Location = new Point(393, 488);
            plus.Name = "plus";
            plus.Size = new Size(114, 58);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += Operation_Click;
            // 
            // egale
            // 
            egale.Location = new Point(511, 424);
            egale.Name = "egale";
            egale.Size = new Size(114, 122);
            egale.TabIndex = 4;
            egale.Text = "=";
            egale.UseVisualStyleBackColor = true;
            egale.Click += Egale;
            // 
            // num1
            // 
            num1.Location = new Point(39, 424);
            num1.Name = "num1";
            num1.Size = new Size(114, 58);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += Ecrire;
            // 
            // num2
            // 
            num2.Location = new Point(157, 424);
            num2.Name = "num2";
            num2.Size = new Size(114, 58);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += Ecrire;
            // 
            // num3
            // 
            num3.Location = new Point(275, 424);
            num3.Name = "num3";
            num3.Size = new Size(114, 58);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += Ecrire;
            // 
            // moins
            // 
            moins.Location = new Point(393, 424);
            moins.Name = "moins";
            moins.Size = new Size(114, 58);
            moins.TabIndex = 3;
            moins.Text = "-";
            moins.UseVisualStyleBackColor = true;
            moins.Click += Operation_Click;
            // 
            // num4
            // 
            num4.Location = new Point(39, 360);
            num4.Name = "num4";
            num4.Size = new Size(114, 58);
            num4.TabIndex = 0;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += Ecrire;
            // 
            // num5
            // 
            num5.Location = new Point(157, 360);
            num5.Name = "num5";
            num5.Size = new Size(114, 58);
            num5.TabIndex = 1;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += Ecrire;
            // 
            // num6
            // 
            num6.Location = new Point(275, 360);
            num6.Name = "num6";
            num6.Size = new Size(114, 58);
            num6.TabIndex = 2;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += Ecrire;
            // 
            // star
            // 
            star.Location = new Point(393, 360);
            star.Name = "star";
            star.Size = new Size(114, 58);
            star.TabIndex = 3;
            star.Text = "*";
            star.UseVisualStyleBackColor = true;
            star.Click += Operation_Click;
            // 
            // inverse
            // 
            inverse.Location = new Point(511, 360);
            inverse.Name = "inverse";
            inverse.Size = new Size(114, 58);
            inverse.TabIndex = 4;
            inverse.Text = "1/x";
            inverse.UseVisualStyleBackColor = true;
            inverse.Click += Operation_Click;
            // 
            // num7
            // 
            num7.Location = new Point(39, 296);
            num7.Name = "num7";
            num7.Size = new Size(114, 58);
            num7.TabIndex = 0;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += Ecrire;
            // 
            // num8
            // 
            num8.Location = new Point(157, 296);
            num8.Name = "num8";
            num8.Size = new Size(114, 58);
            num8.TabIndex = 1;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += Ecrire;
            // 
            // num9
            // 
            num9.Location = new Point(275, 296);
            num9.Name = "num9";
            num9.Size = new Size(114, 58);
            num9.TabIndex = 2;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += Ecrire;
            // 
            // division
            // 
            division.Location = new Point(393, 296);
            division.Name = "division";
            division.Size = new Size(114, 58);
            division.TabIndex = 3;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += Operation_Click;
            // 
            // pourcent
            // 
            pourcent.Location = new Point(511, 296);
            pourcent.Name = "pourcent";
            pourcent.Size = new Size(114, 58);
            pourcent.TabIndex = 4;
            pourcent.Text = "%";
            pourcent.UseVisualStyleBackColor = true;
            pourcent.Click += Operation_Click;
            // 
            // fleche
            // 
            fleche.Location = new Point(39, 232);
            fleche.Name = "fleche";
            fleche.Size = new Size(114, 58);
            fleche.TabIndex = 0;
            fleche.Text = "←";
            fleche.UseVisualStyleBackColor = true;
            fleche.Click += SupprimerDernierCaractere;
            // 
            // CE
            // 
            CE.Location = new Point(157, 232);
            CE.Name = "CE";
            CE.Size = new Size(114, 58);
            CE.TabIndex = 1;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = true;
            CE.Click += MisAZero;
            // 
            // c
            // 
            c.Location = new Point(275, 232);
            c.Name = "c";
            c.Size = new Size(114, 58);
            c.TabIndex = 2;
            c.Text = "C";
            c.UseVisualStyleBackColor = true;
            c.Click += SupprimerTextActuel;
            // 
            // PlusMoins
            // 
            PlusMoins.Enabled = false;
            PlusMoins.Location = new Point(393, 232);
            PlusMoins.Name = "PlusMoins";
            PlusMoins.Size = new Size(114, 58);
            PlusMoins.TabIndex = 3;
            PlusMoins.Text = "±";
            PlusMoins.UseVisualStyleBackColor = true;
            PlusMoins.Click += Egale;
            // 
            // racine
            // 
            racine.Location = new Point(511, 232);
            racine.Name = "racine";
            racine.Size = new Size(114, 58);
            racine.TabIndex = 4;
            racine.Text = "√";
            racine.UseVisualStyleBackColor = true;
            racine.Click += Operation_Click;
            // 
            // MC
            // 
            MC.Enabled = false;
            MC.Location = new Point(39, 168);
            MC.Name = "MC";
            MC.Size = new Size(114, 58);
            MC.TabIndex = 0;
            MC.Text = "MC";
            MC.UseVisualStyleBackColor = true;
            MC.Click += Ecrire;
            // 
            // MR
            // 
            MR.Enabled = false;
            MR.Location = new Point(157, 168);
            MR.Name = "MR";
            MR.Size = new Size(114, 58);
            MR.TabIndex = 1;
            MR.Text = "MR";
            MR.UseVisualStyleBackColor = true;
            MR.Click += MisAZero;
            // 
            // MS
            // 
            MS.Enabled = false;
            MS.Location = new Point(275, 168);
            MS.Name = "MS";
            MS.Size = new Size(114, 58);
            MS.TabIndex = 2;
            MS.Text = "MS";
            MS.UseVisualStyleBackColor = true;
            MS.Click += MisAZero;
            // 
            // MPlus
            // 
            MPlus.Enabled = false;
            MPlus.Location = new Point(393, 168);
            MPlus.Name = "MPlus";
            MPlus.Size = new Size(114, 58);
            MPlus.TabIndex = 3;
            MPlus.Text = "M+";
            MPlus.UseVisualStyleBackColor = true;
            MPlus.Click += Egale;
            // 
            // MMoins
            // 
            MMoins.Enabled = false;
            MMoins.Location = new Point(511, 168);
            MMoins.Name = "MMoins";
            MMoins.Size = new Size(114, 58);
            MMoins.TabIndex = 4;
            MMoins.Text = "M-";
            MMoins.UseVisualStyleBackColor = true;
            MMoins.Click += Operation_Click;
            // 
            // num0
            // 
            num0.Location = new Point(39, 488);
            num0.Name = "num0";
            num0.Size = new Size(232, 58);
            num0.TabIndex = 0;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += Ecrire;
            // 
            // Resultat
            // 
            Resultat.Location = new Point(39, 107);
            Resultat.Name = "Resultat";
            Resultat.RightToLeft = RightToLeft.Yes;
            Resultat.Size = new Size(586, 31);
            Resultat.TabIndex = 5;
            Resultat.Text = "0";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSplitButton1, toolStripSplitButton2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(666, 34);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, historiqueToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(108, 29);
            toolStripSplitButton1.Text = "Affichage";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(196, 34);
            standardToolStripMenuItem.Text = "Standard";
            // 
            // historiqueToolStripMenuItem
            // 
            historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            historiqueToolStripMenuItem.Size = new Size(196, 34);
            historiqueToolStripMenuItem.Text = "Historique";
            // 
            // toolStripSplitButton2
            // 
            toolStripSplitButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripSplitButton2.DropDownItems.AddRange(new ToolStripItem[] { ediToolStripMenuItem, historiqueToolStripMenuItem1 });
            toolStripSplitButton2.Image = (Image)resources.GetObject("toolStripSplitButton2.Image");
            toolStripSplitButton2.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton2.Name = "toolStripSplitButton2";
            toolStripSplitButton2.Size = new Size(63, 29);
            toolStripSplitButton2.Text = "Edit";
            // 
            // ediToolStripMenuItem
            // 
            ediToolStripMenuItem.Name = "ediToolStripMenuItem";
            ediToolStripMenuItem.Size = new Size(196, 34);
            ediToolStripMenuItem.Text = "Edition";
            // 
            // historiqueToolStripMenuItem1
            // 
            historiqueToolStripMenuItem1.Name = "historiqueToolStripMenuItem1";
            historiqueToolStripMenuItem1.Size = new Size(196, 34);
            historiqueToolStripMenuItem1.Text = "Historique";
            // 
            // CalculatriceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 577);
            Controls.Add(toolStrip1);
            Controls.Add(Resultat);
            Controls.Add(MMoins);
            Controls.Add(racine);
            Controls.Add(pourcent);
            Controls.Add(inverse);
            Controls.Add(egale);
            Controls.Add(MPlus);
            Controls.Add(PlusMoins);
            Controls.Add(division);
            Controls.Add(star);
            Controls.Add(moins);
            Controls.Add(plus);
            Controls.Add(MS);
            Controls.Add(c);
            Controls.Add(num9);
            Controls.Add(num6);
            Controls.Add(num3);
            Controls.Add(point);
            Controls.Add(MR);
            Controls.Add(MC);
            Controls.Add(CE);
            Controls.Add(fleche);
            Controls.Add(num8);
            Controls.Add(num7);
            Controls.Add(num5);
            Controls.Add(num4);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(num0);
            Name = "CalculatriceForm";
            Text = "Calculatrice";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button point;
        private Button plus;
        private Button egale;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button moins;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button star;
        private Button inverse;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button division;
        private Button pourcent;
        private Button fleche;
        private Button CE;
        private Button c;
        private Button PlusMoins;
        private Button racine;
        private Button MC;
        private Button MR;
        private Button MS;
        private Button MPlus;
        private Button MMoins;
        private Button num0;
        private TextBox Resultat;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem historiqueToolStripMenuItem;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem ediToolStripMenuItem;
        private ToolStripMenuItem historiqueToolStripMenuItem1;
    }
}
