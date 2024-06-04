using System.Collections.Generic;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<FormKniha> knihy;

        public Form1()
        {
            InitializeComponent();

            knihy = new List<FormKniha>();

            knihy.Add(new FormKniha("1984", 250, new DateTime(1949, 1, 1), bookshelf.A1, this));
            knihy.Add(new FormKniha("Farma zvirat", 250, new DateTime(1955, 1, 1), bookshelf.A1, this));
            knihy.Add(new FormKniha("Harry Potter", 300, new DateTime(2000, 1, 1), bookshelf.A1, this));
            knihy.Add(new FormKniha("451 stupòù Fahrenheita", 250, new DateTime(1980, 1, 1), bookshelf.A1, this));

            knihy.Add(new FormKniha("Lord of the Rings", 500, new DateTime(2001, 1, 1), bookshelf.B2, this));
            knihy.Add(new FormKniha("Posledni aristokratka", 200, new DateTime(2010, 1, 1), bookshelf.B2, this));

            knihy.Add(new FormKniha("Game of Thrones", 700, new DateTime(2002, 1, 1), bookshelf.C3, this));

            knihy.Add(new FormKniha("Game of Thrones", 700, new DateTime(2002, 1, 1), bookshelf.D4, this));


            knihovna.DataSource = Enum.GetValues(typeof(bookshelf));
            knihovna.SelectedIndex = 0;

            UpdateListBox();
        }

        public void UpdateListBox()
        {
            listBox1.Items.Clear();

            foreach (FormKniha kniha in knihy)
            {
                if (knihovna.SelectedItem != null)
                {
                    if (kniha.get_location() == (bookshelf)knihovna.SelectedItem)
                    {
                        listBox1.Items.Add(kniha.get_name());
                    }
                }
                else
                {
                    listBox1.Items.Add(kniha.get_name());
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FormKniha selected = knihy[listBox1.SelectedIndex];
            selected.Show();
            selected.update_ui();


            /*
            FormKniha selected = null;

            string selectedName = listBox1.SelectedValue?.ToString();

            foreach (FormKniha kniha in knihy)
            {
                if (kniha.get_name() == selectedName)
                {
                    selected = kniha;
                    break;
                }
            }


            //select the exact listed item from the listbox, they may not be listed all
            if (selected != null) {
                
            }
            */
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            knihy.Add(new FormKniha("New Book", 0, DateTime.Now, bookshelf.A1, this));

            UpdateListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormKniha selected = knihy[listBox1.SelectedIndex];
            knihy.Remove(selected);
            selected.Close();

            UpdateListBox();
        }

        private void knihovna_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UpdateListBox();
        }

        private void knihovna_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateListBox();
        }
    }
}
