using System.Windows.Forms;
using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;

namespace RemotingClient
{

    partial class Client : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button point;
        private Button plus;
        private Button egale;
        private Button moins;
        private Button num1;
        private Button num2;
        private Button num3;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button star;
        private Button num7;
        private Button num8;
        private Button num9;
        private Button c;
        private Button CE;
        private Button inverse;
        private Button num0;
        private Button division;
        private Button pourcent;
        private Button fleche;
        private Button PlusMoins;
        private Button racine;
         private Button MC;
           private Button MR;
           private Button MS;
           private Button MPlus;
           private Button MMoins;
        private TextBox Resultat;
        private ToolStrip toolStrip1;
         private ToolStripSplitButton toolStripSplitButton1;
          private ToolStripMenuItem  standardToolStripMenuItem;
          private ToolStripMenuItem historiqueToolStripMenuItem;
          private ToolStripMenuItem toolStripSplitButton2;
          private ToolStripMenuItem ediToolStripMenuItem;
          private ToolStripMenuItem historiqueToolStripMenuItem1;
        //private ToolStripMenuItem toolStrip1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        
        private void InitializeComponent()
        {
            this.point = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.egale = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.star = new System.Windows.Forms.Button();
            this.inverse = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.pourcent = new System.Windows.Forms.Button();
            this.fleche = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.PlusMoins = new System.Windows.Forms.Button();
            this.racine = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.MPlus = new System.Windows.Forms.Button();
            this.MMoins = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Resultat = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(253, 619);
            this.point.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(89, 61);
            this.point.TabIndex = 2;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Point);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(350, 619);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(89, 61);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Operation_Click);
            // 
            // egale
            // 
            this.egale.Location = new System.Drawing.Point(447, 535);
            this.egale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.egale.Name = "egale";
            this.egale.Size = new System.Drawing.Size(89, 145);
            this.egale.TabIndex = 4;
            this.egale.Text = "=";
            this.egale.UseVisualStyleBackColor = true;
            this.egale.Click += new System.EventHandler(this.Egale);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(46, 535);
            this.num1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(89, 61);
            this.num1.TabIndex = 0;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.Ecrire);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(156, 535);
            this.num2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(89, 61);
            this.num2.TabIndex = 1;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.Ecrire);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(253, 535);
            this.num3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(89, 61);
            this.num3.TabIndex = 2;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.Ecrire);
            // 
            // moins
            // 
            this.moins.Location = new System.Drawing.Point(350, 535);
            this.moins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(89, 61);
            this.moins.TabIndex = 3;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = true;
            this.moins.Click += new System.EventHandler(this.Operation_Click);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(46, 437);
            this.num4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(89, 61);
            this.num4.TabIndex = 0;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.Ecrire);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(156, 437);
            this.num5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(89, 61);
            this.num5.TabIndex = 1;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.Ecrire);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(253, 437);
            this.num6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(89, 61);
            this.num6.TabIndex = 2;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.Ecrire);
            // 
            // star
            // 
            this.star.Location = new System.Drawing.Point(350, 437);
            this.star.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(89, 61);
            this.star.TabIndex = 3;
            this.star.Text = "*";
            this.star.UseVisualStyleBackColor = true;
            this.star.Click += new System.EventHandler(this.Operation_Click);
            // 
            // inverse
            // 
            this.inverse.Location = new System.Drawing.Point(447, 437);
            this.inverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(89, 61);
            this.inverse.TabIndex = 4;
            this.inverse.Text = "1/x";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.Click += new System.EventHandler(this.Operation_Click);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(46, 338);
            this.num7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(89, 61);
            this.num7.TabIndex = 0;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.Ecrire);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(156, 338);
            this.num8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(89, 61);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.Ecrire);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(253, 338);
            this.num9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(89, 61);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.Ecrire);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(350, 338);
            this.division.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(89, 61);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Operation_Click);
            // 
            // pourcent
            // 
            this.pourcent.Location = new System.Drawing.Point(447, 338);
            this.pourcent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pourcent.Name = "pourcent";
            this.pourcent.Size = new System.Drawing.Size(89, 61);
            this.pourcent.TabIndex = 4;
            this.pourcent.Text = "%";
            this.pourcent.UseVisualStyleBackColor = true;
            this.pourcent.Click += new System.EventHandler(this.Operation_Click);
            // 
            // fleche
            // 
            this.fleche.Location = new System.Drawing.Point(46, 240);
            this.fleche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fleche.Name = "fleche";
            this.fleche.Size = new System.Drawing.Size(89, 61);
            this.fleche.TabIndex = 0;
            this.fleche.Text = "←";
            this.fleche.UseVisualStyleBackColor = true;
            this.fleche.Click += new System.EventHandler(this.SupprimerDernierCaractere);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(156, 240);
            this.CE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(89, 61);
            this.CE.TabIndex = 1;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.MisAZero);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(253, 240);
            this.c.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(89, 61);
            this.c.TabIndex = 2;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.SupprimerTextActuel);
            // 
            // PlusMoins
            // 
            this.PlusMoins.Location = new System.Drawing.Point(350, 240);
            this.PlusMoins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PlusMoins.Name = "PlusMoins";
            this.PlusMoins.Size = new System.Drawing.Size(89, 61);
            this.PlusMoins.TabIndex = 3;
            this.PlusMoins.Text = "+/-";
            this.PlusMoins.UseVisualStyleBackColor = true;
            this.PlusMoins.Click += new System.EventHandler(this.Operation_Click);
            // 
            // racine
            // 
            this.racine.Location = new System.Drawing.Point(447, 240);
            this.racine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.racine.Name = "racine";
            this.racine.Size = new System.Drawing.Size(89, 61);
            this.racine.TabIndex = 4;
            this.racine.Text = "√";
            this.racine.UseVisualStyleBackColor = true;
            this.racine.Click += new System.EventHandler(this.Operation_Click);
            // 
            // MC
            // 
            this.MC.Enabled = false;
            this.MC.Location = new System.Drawing.Point(46, 141);
            this.MC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(89, 61);
            this.MC.TabIndex = 0;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            // 
            // MR
            // 
            this.MR.Enabled = false;
            this.MR.Location = new System.Drawing.Point(156, 141);
            this.MR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(89, 61);
            this.MR.TabIndex = 1;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            // 
            // MS
            // 
            this.MS.Enabled = false;
            this.MS.Location = new System.Drawing.Point(253, 141);
            this.MS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(89, 61);
            this.MS.TabIndex = 2;
            this.MS.Text = "MS";
            this.MS.UseVisualStyleBackColor = true;
            // 
            // MPlus
            // 
            this.MPlus.Enabled = false;
            this.MPlus.Location = new System.Drawing.Point(350, 141);
            this.MPlus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MPlus.Name = "MPlus";
            this.MPlus.Size = new System.Drawing.Size(89, 61);
            this.MPlus.TabIndex = 3;
            this.MPlus.Text = "M+";
            this.MPlus.UseVisualStyleBackColor = true;
            // 
            // MMoins
            // 
            this.MMoins.Enabled = false;
            this.MMoins.Location = new System.Drawing.Point(447, 141);
            this.MMoins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MMoins.Name = "MMoins";
            this.MMoins.Size = new System.Drawing.Size(89, 61);
            this.MMoins.TabIndex = 4;
            this.MMoins.Text = "M-";
            this.MMoins.UseVisualStyleBackColor = true;
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(46, 619);
            this.num0.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(199, 61);
            this.num0.TabIndex = 0;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.Ecrire);
            // 
            // Resultat
            // 
            this.Resultat.Location = new System.Drawing.Point(31, 85);
            this.Resultat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resultat.Name = "Resultat";
            this.Resultat.ReadOnly = true;
            this.Resultat.Size = new System.Drawing.Size(505, 26);
            this.Resultat.TabIndex = 0;
            this.Resultat.Text = "0";
            this.Resultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(594, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.historiqueToolStripMenuItem});
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(66, 22);
            this.toolStripSplitButton1.Text = "Mode";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.standardToolStripMenuItem.Text = "Standard";
            // 
            // historiqueToolStripMenuItem
            // 
            this.historiqueToolStripMenuItem.Name = "historiqueToolStripMenuItem";
            this.historiqueToolStripMenuItem.Size = new System.Drawing.Size(196, 34);
            this.historiqueToolStripMenuItem.Text = "Historique";
            // 
            // ediToolStripMenuItem
            // 
            this.ediToolStripMenuItem.Name = "ediToolStripMenuItem";
            this.ediToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ediToolStripMenuItem.Text = "Edi";
            // 
            // historiqueToolStripMenuItem1
            // 
            this.historiqueToolStripMenuItem1.Name = "historiqueToolStripMenuItem1";
            this.historiqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.historiqueToolStripMenuItem1.Text = "Historique";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 706);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.Resultat);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.MMoins);
            this.Controls.Add(this.MPlus);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.racine);
            this.Controls.Add(this.PlusMoins);
            this.Controls.Add(this.c);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.fleche);
            this.Controls.Add(this.pourcent);
            this.Controls.Add(this.division);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.star);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.moins);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.egale);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client";
            this.Text = "Calculatrice";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        // Your other methods and logic go here
    }
}

