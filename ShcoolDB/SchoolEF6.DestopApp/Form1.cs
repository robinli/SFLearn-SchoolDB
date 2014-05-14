using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolEF6.DestopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button_Click(object sender, EventArgs e)
        {
            this.OpenForm(((Button)sender).Text);
        }

        public void OpenForm(string formName)
        {
            object obj = Activator.CreateInstance(
                Type.GetType(string.Format("SchoolEF6.DestopApp.{0}, SchoolEF6.DestopApp", formName), true));
            Form newForm = (Form)obj;
            newForm.ShowDialog();
        }
    }
}
