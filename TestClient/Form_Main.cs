﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRadioDemo_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(OpenTestFormMode.DemoRadio);
            testForm.ShowDialog();
        }

        private void btnCheckDemo_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm(OpenTestFormMode.DemoCheck);
            testForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Globals.client.Close();
        }
    }
}