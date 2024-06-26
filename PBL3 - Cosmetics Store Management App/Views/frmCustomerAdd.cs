﻿using PBL3___Cosmetics_Store_Management_App.Controllers;
using PBL3___Cosmetics_Store_Management_App.Entities;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PBL3___Cosmetics_Store_Management_App.View
{
    public partial class frmCustomerAdd : Form
    {
        public Customer current_customer = null;
        public delegate void MyDel();
        public MyDel reload { get; set; }
        public frmCustomerAdd()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Do not leave any field empty!", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Customer CurCustomer = new Customer();
            CurCustomer.customer_name = txtName.Text.ToString();
            CurCustomer.customer_phone = txtPhone.Text.ToString();
            List<Customer> CC = CustomerController.Instance.ffind(CurCustomer);
            if (CC.Count == 0)
            {
                CustomerController.Instance.add(CurCustomer);
                current_customer = CurCustomer;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("This phone number is registered");
            }
            
            this.Dispose();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
