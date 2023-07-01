using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FendalPrep
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxName.Clear();
            this.textBoxMobileNo.Clear();
            this.textBoxAge.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Popup popup = new Popup(this.textBoxName.Text, this.textBoxAge.Text, this.textBoxMobileNo.Text);
            popup.Show();

            
        }

        private void SaveData()
        {
            textBoxName.Text=Name.ToString();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
