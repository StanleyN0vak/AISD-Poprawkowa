namespace Formsy
{
    partial class Form1
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
            this.LiczbyN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gen = new System.Windows.Forms.Button();
            this.SB = new System.Windows.Forms.Button();
            this.SS = new System.Windows.Forms.Button();
            this.SI = new System.Windows.Forms.Button();
            this.SM = new System.Windows.Forms.Button();
            this.SQ = new System.Windows.Forms.Button();
            this.Rezultat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // LiczbyN
            // 
            this.LiczbyN.Location = new System.Drawing.Point(133, 98);
            this.LiczbyN.Name = "LiczbyN";
            this.LiczbyN.Size = new System.Drawing.Size(100, 23);
            this.LiczbyN.TabIndex = 0;
            this.LiczbyN.TextChanged += new System.EventHandler(this.LiczbyN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(509, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Czas:";
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(553, 256);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(16, 15);
            this.czas.TabIndex = 3;
            this.czas.Text = "...";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(323, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(497, 98);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 5;
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(516, 149);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 6;
            this.gen.Text = "Generuj";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // SB
            // 
            this.SB.Location = new System.Drawing.Point(73, 359);
            this.SB.Name = "SB";
            this.SB.Size = new System.Drawing.Size(75, 23);
            this.SB.TabIndex = 7;
            this.SB.Text = "SB";
            this.SB.UseVisualStyleBackColor = true;
            this.SB.Click += new System.EventHandler(this.SB_Click);
            // 
            // SS
            // 
            this.SS.Location = new System.Drawing.Point(201, 359);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(75, 23);
            this.SS.TabIndex = 8;
            this.SS.Text = "SS";
            this.SS.UseVisualStyleBackColor = true;
            this.SS.Click += new System.EventHandler(this.SS_Click);
            // 
            // SI
            // 
            this.SI.Location = new System.Drawing.Point(344, 359);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(75, 23);
            this.SI.TabIndex = 9;
            this.SI.Text = "SI";
            this.SI.UseVisualStyleBackColor = true;
            this.SI.Click += new System.EventHandler(this.SI_Click);
            // 
            // SM
            // 
            this.SM.Location = new System.Drawing.Point(483, 359);
            this.SM.Name = "SM";
            this.SM.Size = new System.Drawing.Size(75, 23);
            this.SM.TabIndex = 10;
            this.SM.Text = "SM";
            this.SM.UseVisualStyleBackColor = true;
            this.SM.Click += new System.EventHandler(this.SM_Click);
            // 
            // SQ
            // 
            this.SQ.Location = new System.Drawing.Point(628, 359);
            this.SQ.Name = "SQ";
            this.SQ.Size = new System.Drawing.Size(75, 23);
            this.SQ.TabIndex = 11;
            this.SQ.Text = "SQ";
            this.SQ.UseVisualStyleBackColor = true;
            // 
            // Rezultat
            // 
            this.Rezultat.AutoSize = true;
            this.Rezultat.Location = new System.Drawing.Point(164, 256);
            this.Rezultat.Name = "Rezultat";
            this.Rezultat.Size = new System.Drawing.Size(38, 15);
            this.Rezultat.TabIndex = 12;
            this.Rezultat.Text = "wynik";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rezultat);
            this.Controls.Add(this.SQ);
            this.Controls.Add(this.SM);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.SS);
            this.Controls.Add(this.SB);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LiczbyN);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox LiczbyN;
        private Label label1;
        private Label czas;
        private CheckBox checkBox1;
        private NumericUpDown numericUpDown1;
        private Button gen;
        private Button SB;
        private Button SS;
        private Button SI;
        private Button SM;
        private Button SQ;
        private Label Rezultat;
    }
}