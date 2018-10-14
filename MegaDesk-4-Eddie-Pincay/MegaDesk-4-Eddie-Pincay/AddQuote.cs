using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace MegaDesk_4_Eddie_Pincay
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            
            ArrayList materials = new ArrayList();
            int enumlenght = Enum.GetValues(typeof(Desk.desktopMaterials)).Length;
            Array materialNames = Enum.GetValues(typeof(Desk.desktopMaterials));

            for (int i = 0; i < enumlenght; i++)
            {
                materials.Add(materialNames.GetValue(i));
            }

            this.Material.DataSource = materials;
        }

        private void cancelQuoteButto(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            error1.Visible = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point (.)
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //message with is a different
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                validateNumber(24, 96, Int32.Parse(width.Text));
            }
        }

        private void validateNumber(int a, int b, int value)
        {
            if (value >= a && value <= b)
            {

            }
            else
            {
                error1.Text = "It's only between " + a + " - " + b + " inches";
                error1.Visible = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            error1.Visible = false;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point (.) 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //message with is a different
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                validateNumber(12, 48, Int32.Parse(depth.Text));
            }
        }

        public string getDate()
        {
            return this.dateTimePicker1.Text;
        }

        public int getDeskWidth()
        {
            return Convert.ToInt32(this.width.Text);
        }

        public int getDeskDepth()
        {
            return Convert.ToInt32(this.depth.Text);
        }

        public int getDeskDrawers()
        {
            return Convert.ToInt32(this.DeskDrawers.Text);
        }

        public String getClientName()
        {
            return this.clientName.Text;
        }

        public int getRushDays()
        {
            return Convert.ToInt32(this.rushDays.Text);
        }

        public string getMaterial()
        {
            return this.Material.Text;
        }

        public void setSize(int size)
        {
            this.size.Text = string.Format("{0:n0}", size.ToString());
        }

        public void setPrice(int price)
        {
            this.Price.Text = "$" + string.Format("{0:n0}", price.ToString());
        }

        public void setDate(string date)
        {
            this.dateTimePicker1.Text = date;
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //Date
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // Display the date as "27 Feb 2012".  
            dateTimePicker1.CustomFormat = "dd MMM yyyy";
            this.dateTimePicker1.Enabled = false;
        }

        private void saveQuote_Click(object sender, EventArgs e)
        {
            SaveQuote deskQuote = new SaveQuote();
            deskQuote.saveQuote(this);
            this.saveQuote.Enabled = false;
            System.Windows.Forms.MessageBox.Show("The quote save successfully");
        }

    }
}
