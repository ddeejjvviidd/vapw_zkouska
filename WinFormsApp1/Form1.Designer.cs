namespace WinFormsApp1
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
            listBox1 = new ListBox();
            popis_knih = new Label();
            button1 = new Button();
            button2 = new Button();
            knihovna = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(440, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 334);
            listBox1.TabIndex = 0;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // popis_knih
            // 
            popis_knih.AutoSize = true;
            popis_knih.Location = new Point(440, 9);
            popis_knih.Name = "popis_knih";
            popis_knih.Size = new Size(37, 15);
            popis_knih.TabIndex = 1;
            popis_knih.Text = "Knihy";
            // 
            // button1
            // 
            button1.Location = new Point(440, 384);
            button1.Name = "button1";
            button1.Size = new Size(105, 54);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(565, 384);
            button2.Name = "button2";
            button2.Size = new Size(105, 54);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // knihovna
            // 
            knihovna.FormattingEnabled = true;
            knihovna.ItemHeight = 15;
            knihovna.Location = new Point(47, 39);
            knihovna.Name = "knihovna";
            knihovna.Size = new Size(230, 334);
            knihovna.TabIndex = 4;
            knihovna.MouseClick += knihovna_MouseClick;
            knihovna.MouseDoubleClick += knihovna_MouseDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Umisteni";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 448);
            Controls.Add(label1);
            Controls.Add(knihovna);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(popis_knih);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label popis_knih;
        private Button button1;
        private Button button2;
        private ListBox knihovna;
        private Label label1;
    }
}
