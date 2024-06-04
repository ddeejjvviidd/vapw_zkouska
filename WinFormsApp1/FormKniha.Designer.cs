namespace WinFormsApp1
{
    partial class FormKniha
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
            kniha_ulozit = new Button();
            kniha_zrusit = new Button();
            label1 = new Label();
            kniha_nazev = new TextBox();
            kniha_pocet_stran = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            kniha_misto = new ComboBox();
            kniha_datetimepicker = new DateTimePicker();
            SuspendLayout();
            // 
            // kniha_ulozit
            // 
            kniha_ulozit.Location = new Point(23, 361);
            kniha_ulozit.Name = "kniha_ulozit";
            kniha_ulozit.Size = new Size(109, 58);
            kniha_ulozit.TabIndex = 0;
            kniha_ulozit.Text = "Ulozit";
            kniha_ulozit.UseVisualStyleBackColor = true;
            kniha_ulozit.Click += kniha_ulozit_Click;
            // 
            // kniha_zrusit
            // 
            kniha_zrusit.Location = new Point(147, 361);
            kniha_zrusit.Name = "kniha_zrusit";
            kniha_zrusit.Size = new Size(109, 58);
            kniha_zrusit.TabIndex = 1;
            kniha_zrusit.Text = "Zrusit";
            kniha_zrusit.UseVisualStyleBackColor = true;
            kniha_zrusit.Click += kniha_zrusit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Nazev";
            // 
            // kniha_nazev
            // 
            kniha_nazev.Location = new Point(23, 56);
            kniha_nazev.Name = "kniha_nazev";
            kniha_nazev.Size = new Size(233, 23);
            kniha_nazev.TabIndex = 3;
            // 
            // kniha_pocet_stran
            // 
            kniha_pocet_stran.Location = new Point(23, 122);
            kniha_pocet_stran.Name = "kniha_pocet_stran";
            kniha_pocet_stran.Size = new Size(233, 23);
            kniha_pocet_stran.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Pocet stran";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 165);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 6;
            label3.Text = "Datum vydani";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 238);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Umisteni";
            // 
            // kniha_misto
            // 
            kniha_misto.FormattingEnabled = true;
            kniha_misto.Location = new Point(23, 269);
            kniha_misto.Name = "kniha_misto";
            kniha_misto.Size = new Size(233, 23);
            kniha_misto.TabIndex = 10;
            // 
            // kniha_datetimepicker
            // 
            kniha_datetimepicker.Location = new Point(23, 192);
            kniha_datetimepicker.Name = "kniha_datetimepicker";
            kniha_datetimepicker.Size = new Size(233, 23);
            kniha_datetimepicker.TabIndex = 11;
            // 
            // FormKniha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 450);
            Controls.Add(kniha_datetimepicker);
            Controls.Add(kniha_misto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(kniha_pocet_stran);
            Controls.Add(label2);
            Controls.Add(kniha_nazev);
            Controls.Add(label1);
            Controls.Add(kniha_zrusit);
            Controls.Add(kniha_ulozit);
            Name = "FormKniha";
            Text = "FormKniha";
            FormClosing += FormKniha_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kniha_ulozit;
        private Button kniha_zrusit;
        private Label label1;
        private TextBox kniha_nazev;
        private TextBox kniha_pocet_stran;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox kniha_misto;
        private DateTimePicker kniha_datetimepicker;
    }
}