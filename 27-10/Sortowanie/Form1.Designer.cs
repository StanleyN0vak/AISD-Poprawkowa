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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.generuj = new System.Windows.Forms.Button();
            this.czas = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectBubble
            // 
            this.SelectBubble.Location = new System.Drawing.Point(172, 384);
            this.SelectBubble.Name = "SelectBubble";
            this.SelectBubble.Size = new System.Drawing.Size(71, 23);
            this.SelectBubble.TabIndex = 0;
            this.SelectBubble.Text = "SB";
            this.SelectBubble.UseVisualStyleBackColor = true;
            this.SelectBubble.Click += new System.EventHandler(this.SelectBubble_Click);
            // 
            // SelectSort
            // 
            this.SelectSort.Location = new System.Drawing.Point(253, 384);
            this.SelectSort.Name = "SelectSort";
            this.SelectSort.Size = new System.Drawing.Size(71, 23);
            this.SelectSort.TabIndex = 1;
            this.SelectSort.Text = "SS";
            this.SelectSort.UseVisualStyleBackColor = true;
            // 
            // SelectInsert
            // 
            this.SelectInsert.Location = new System.Drawing.Point(334, 384);
            this.SelectInsert.Name = "SelectInsert";
            this.SelectInsert.Size = new System.Drawing.Size(71, 23);
            this.SelectInsert.TabIndex = 2;
            this.SelectInsert.Text = "SI";
            this.SelectInsert.UseVisualStyleBackColor = true;
            // 
            // SelectMerch
            // 
            this.SelectMerch.Location = new System.Drawing.Point(415, 384);
            this.SelectMerch.Name = "SelectMerch";
            this.SelectMerch.Size = new System.Drawing.Size(71, 23);
            this.SelectMerch.TabIndex = 3;
            this.SelectMerch.Text = "SM";
            this.SelectMerch.UseVisualStyleBackColor = true;
            // 
            // SelectQuick
            // 
            this.SelectQuick.Location = new System.Drawing.Point(496, 384);
            this.SelectQuick.Name = "SelectQuick";
            this.SelectQuick.Size = new System.Drawing.Size(71, 23);
            this.SelectQuick.TabIndex = 4;
            this.SelectQuick.Text = "SQ";
            this.SelectQuick.UseVisualStyleBackColor = true;
            // 
            // Dane
            // 
            this.Dane.Location = new System.Drawing.Point(133, 79);
            this.Dane.Name = "Dane";
            this.Dane.Size = new System.Drawing.Size(100, 23);
            this.Dane.TabIndex = 5;
            this.Dane.TextChanged += new System.EventHandler(this.Dane_TextChanged);
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(133, 250);
            this.Wynik.Name = "Wynik";
            this.Wynik.Size = new System.Drawing.Size(100, 23);
            this.Wynik.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(363, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(516, 79);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 23);
            this.numericUpDown1.TabIndex = 8;
            // 
            // generuj
            // 
            this.generuj.Location = new System.Drawing.Point(535, 108);
            this.generuj.Name = "generuj";
            this.generuj.Size = new System.Drawing.Size(75, 23);
            this.generuj.TabIndex = 9;
            this.generuj.Text = "Generuj";
            this.generuj.UseVisualStyleBackColor = true;
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(516, 258);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(34, 15);
            this.czas.TabIndex = 10;
            this.czas.Text = "Czas:";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(560, 258);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(16, 15);
            this.time.TabIndex = 11;
            this.time.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.time);
            this.Controls.Add(this.czas);
            this.Controls.Add(this.generuj);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.Dane);
            this.Controls.Add(this.SelectQuick);
            this.Controls.Add(this.SelectMerch);
            this.Controls.Add(this.SelectInsert);
            this.Controls.Add(this.SelectSort);
            this.Controls.Add(this.SelectBubble);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private NumericUpDown numericUpDown1;
        private Button generuj;
        private Label czas;
        private Label time;
    }
}