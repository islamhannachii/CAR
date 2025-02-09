namespace Presentation
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
            this.txtValeur1 = new System.Windows.Forms.TextBox();
            this.txtValeur2 = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.btnHistorique = new System.Windows.Forms.Button();
            this.listHistorique = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValeur1
            // 
            this.txtValeur1.Location = new System.Drawing.Point(113, 31);
            this.txtValeur1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValeur1.Name = "txtValeur1";
            this.txtValeur1.Size = new System.Drawing.Size(214, 22);
            this.txtValeur1.TabIndex = 0;
            // 
            // txtValeur2
            // 
            this.txtValeur2.Location = new System.Drawing.Point(113, 63);
            this.txtValeur2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValeur2.Name = "txtValeur2";
            this.txtValeur2.Size = new System.Drawing.Size(214, 22);
            this.txtValeur2.TabIndex = 1;
            // 
            // cmbOperation
            // 
            this.cmbOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "sqrt",
            "pow",
            "%",
            "frac"});
            this.cmbOperation.Location = new System.Drawing.Point(113, 95);
            this.cmbOperation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(214, 24);
            this.cmbOperation.TabIndex = 2;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(113, 128);
            this.btnCalculer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(215, 28);
            this.btnCalculer.TabIndex = 3;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(113, 164);
            this.txtResultat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.ReadOnly = true;
            this.txtResultat.Size = new System.Drawing.Size(214, 22);
            this.txtResultat.TabIndex = 4;
            // 
            // btnHistorique
            // 
            this.btnHistorique.Location = new System.Drawing.Point(16, 208);
            this.btnHistorique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHistorique.Name = "btnHistorique";
            this.btnHistorique.Size = new System.Drawing.Size(311, 28);
            this.btnHistorique.TabIndex = 5;
            this.btnHistorique.Text = "Afficher Historique";
            this.btnHistorique.Click += new System.EventHandler(this.btnHistorique_Click);
            // 
            // listHistorique
            // 
            this.listHistorique.FormattingEnabled = true;
            this.listHistorique.ItemHeight = 16;
            this.listHistorique.Location = new System.Drawing.Point(16, 244);
            this.listHistorique.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listHistorique.Name = "listHistorique";
            this.listHistorique.Size = new System.Drawing.Size(311, 260);
            this.listHistorique.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valeur 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valeur 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opération:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Résultat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listHistorique);
            this.Controls.Add(this.btnHistorique);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtValeur2);
            this.Controls.Add(this.txtValeur1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calculatrice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValeur1;
        private System.Windows.Forms.TextBox txtValeur2;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Button btnHistorique;
        private System.Windows.Forms.ListBox listHistorique;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}