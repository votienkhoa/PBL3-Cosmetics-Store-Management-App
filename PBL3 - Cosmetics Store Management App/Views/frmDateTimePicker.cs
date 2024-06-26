﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Cosmetics_Store_Management_App.Views
{
    public partial class frmDateTimePicker : Form
    {
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }

        public frmDateTimePicker()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            StartDate = dateTimePickerStart.Value;
            EndDate = dateTimePickerEnd.Value;

            if (EndDate < StartDate)
            {
                MessageBox.Show("End date must be after start date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
