using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class FormCourseRegistration : System.Windows.Forms.Form
    {
        public FormCourseRegistration()
        {
            InitializeComponent();
            // for todays date 
            dateTimePickerPaymentDate.Value = DateTime.Now;
            dateTimePickerPaymentDate.MinDate = DateTime.Today;
        }

        private void FormCourseRegistration_Load(object sender, EventArgs e)
        {
            // 
        }
    }
}
