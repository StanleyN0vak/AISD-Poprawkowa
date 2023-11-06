namespace Sortowanie
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
            this.SelectBubble = new System.Windows.Forms.Button();
            this.SelectSort = new System.Windows.Forms.Button();
            this.SelectInsert = new System.Windows.Forms.Button();
            this.SelectMerch = new System.Windows.Forms.Button();
            this.SelectQuick = new System.Windows.Forms.Button();
            this.Dane = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.generuj = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectBubble
            // 
            this.SelectBubble.Location = new System.Drawing.Point(105, 360);
            this.SelectBubble.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectBubble.Name = "SelectBubble";
            this.SelectBubble.Size = new System.Drawing.Size(81, 31);
            this.SelectBubble.TabIndex = 0;
            this.SelectBubble.Text = "SB";
            this.SelectBubble.UseVisualStyleBackColor = true;
            this.SelectBubble.Click += new System.EventHandler(this.SelectBubble_Click);
            // 
            // SelectSort
            // 
            this.SelectSort.Location = new System.Drawing.Point(197, 360);
            this.SelectSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectSort.Name = "SelectSort";
            this.SelectSort.Size = new System.Drawing.Size(81, 31);
            this.SelectSort.TabIndex = 1;
            this.SelectSort.Text = "SS";
            this.SelectSort.UseVisualStyleBackColor = true;
            this.SelectSort.Click += new System.EventHandler(this.SelectSort_Click);
            // 
            // SelectInsert
            // 
            this.SelectInsert.Location = new System.Drawing.Point(290, 360);
            this.SelectInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectInsert.Name = "SelectInsert";
            this.SelectInsert.Size = new System.Drawing.Size(81, 31);
            this.SelectInsert.TabIndex = 2;
            this.SelectInsert.Text = "SI";
            this.SelectInsert.UseVisualStyleBackColor = true;
            this.SelectInsert.Click += new System.EventHandler(this.SelectInsert_Click);
            // 
            // SelectMerch
            // 
            this.SelectMerch.Location = new System.Drawing.Point(382, 360);
            this.SelectMerch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectMerch.Name = "SelectMerch";
            this.SelectMerch.Size = new System.Drawing.Size(81, 31);
            this.SelectMerch.TabIndex = 3;
            this.SelectMerch.Text = "SM";
            this.SelectMerch.UseVisualStyleBackColor = true;
            this.SelectMerch.Click += new System.EventHandler(this.SelectMerch_Click);
            // 
            // SelectQuick
            // 
            this.SelectQuick.Location = new System.Drawing.Point(475, 360);
            this.SelectQuick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectQuick.Name = "SelectQuick";
            this.SelectQuick.Size = new System.Drawing.Size(81, 31);
            this.SelectQuick.TabIndex = 4;
            this.SelectQuick.Text = "SQ";
            this.SelectQuick.UseVisualStyleBackColor = true;
            this.SelectQuick.Click += new System.EventHandler(this.SelectQuick_Click);
            // 
            // Dane
            // 
            this.Dane.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dane.Location = new System.Drawing.Point(58, 46);
            this.Dane.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Dane.Name = "Dane";
            this.Dane.Size = new System.Drawing.Size(114, 27);
            this.Dane.TabIndex = 5;
            this.Dane.TextChanged += new System.EventHandler(this.Dane_TextChanged);
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(58, 274);
            this.Wynik.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(114, 27);
            this.Wynik.TabIndex = 6;
            this.Wynik.TextChanged += new System.EventHandler(this.Wynik_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(321, 58);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // nud
            // 
            this.nud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud.Enabled = false;
            this.nud.Location = new System.Drawing.Point(496, 46);
            this.nud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(137, 27);
            this.nud.TabIndex = 8;
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // generuj
            // 
            this.generuj.Enabled = false;
            this.generuj.Location = new System.Drawing.Point(517, 85);
            this.generuj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(86, 31);
            this.generuj.TabIndex = 9;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            this.generuj.Click += new System.EventHandler(this.generuj_Click);
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(517, 281);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(42, 20);
            this.czas.TabIndex = 10;
            this.czas.Text = "Czas:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(567, 281);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(18, 20);
            this.time.TabIndex = 11;
            this.time.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 462);
            this.Controls.Add(this.time);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Dane);
            this.Controls.Add(this.SelectQuick);
            this.Controls.Add(this.SelectMerch);
            this.Controls.Add(this.SelectInsert);
            this.Controls.Add(this.SelectSort);
            this.Controls.Add(this.SelectBubble);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SelectBubble;
        private Button SelectSort;
        private Button SelectInsert;
        private Button SelectMerch;
        private Button SelectQuick;
        private TextBox Dane;
        private TextBox Wynik;
        private CheckBox checkBox1;
        private NumericUpDown nud;
        private Button generuj;
        private Label czas;
        private Label time;
    }
}