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
    public partial class Standards : Form
    {
        public Standards()
        {
            InitializeComponent();
        }

        DAL.SchoolDBEntities DB = new DAL.SchoolDBEntities();
        private void Standards_Load(object sender, EventArgs e)
        {
            this.standardBindingSource.DataSource = DB.Standard.ToList();
        }

        private void standardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DB.SaveChanges();
        }
    }
}
