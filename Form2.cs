﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTBYT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form4());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TBYT());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form6());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form7());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form8());
        }
    }
}
