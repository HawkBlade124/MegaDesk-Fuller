using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Fuller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitApp(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            Form mod = new AddQuote();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            Form mod = new SearchQuotes();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            Form mod = new ViewAllQuotes();
            mod.Owner = this;
            mod.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "../desk.png";
        }
    }
}
