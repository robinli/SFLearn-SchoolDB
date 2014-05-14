﻿using System;
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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        DAL.SchoolDBEntities DB = new DAL.SchoolDBEntities();
        private void Teachers_Load(object sender, EventArgs e)
        {
            this.teacherBindingSource.DataSource = DB.Teacher.ToList();
        }
        private void teacherBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            DB.SaveChanges();
        }
    }
}
