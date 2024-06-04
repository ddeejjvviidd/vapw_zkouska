using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormKniha : Form
    {
        private string nazev;
        private int pocetStran;
        private DateTime vydani;
        bookshelf umisteni;

        private Form1 parent;

        public FormKniha(string nazev, int pocetStran, DateTime vydani, bookshelf umisteni, Form1 parent)
        {
            InitializeComponent();

            this.nazev = nazev;
            this.pocetStran = pocetStran;
            this.vydani = vydani;
            this.umisteni = umisteni;
            this.parent = parent;
        }

        public string get_name()
        {
            return nazev;
        }

        public bookshelf get_location()
        {
            return umisteni;
        }

        public void update_ui()
        {
            kniha_nazev.Text = nazev;
            kniha_pocet_stran.Text = pocetStran.ToString();
            //kniha_datum_vydani.Text = vydani.ToString();
            kniha_datetimepicker.Value = vydani;

            kniha_misto.DataSource = Enum.GetValues(typeof(bookshelf));
            kniha_misto.SelectedItem = umisteni;
        }

        private void FormKniha_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void kniha_zrusit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void kniha_ulozit_Click(object sender, EventArgs e)
        {
            this.nazev = kniha_nazev.Text;
            this.pocetStran = int.Parse(kniha_pocet_stran.Text);
            //this.vydani = DateTime.Parse(kniha_datum_vydani.Text);
            this.vydani = kniha_datetimepicker.Value.Date;
            this.umisteni = (bookshelf)kniha_misto.SelectedItem;

            parent.UpdateListBox();

            Hide();
        }


    }
}
