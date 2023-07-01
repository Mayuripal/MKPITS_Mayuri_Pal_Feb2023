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
    public partial class Popup : Form
    {
        public string Name;
        public string Age;
        public string Mob;
        public Popup(string Name, string Age, string Mob)
        {
            InitializeComponent();
            this.Name = Name;
            this.Age = Age;
            this.Mob = Mob;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Popup_Load(object sender, EventArgs e)
        {
            this.label1.Text = this.Name;
            this.label2.Text = this.Age;
            this.labelName.Text = this.Mob;
        }
    }
}
