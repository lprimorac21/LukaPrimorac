﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        string username = "nastavnik";
        string passcode = "test";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text =="")
            {
                MessageBox.Show("Lozinka nije unesena", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                if (txtUsername.Text == username && txtPassword.Text == passcode) ;
                {
                    MessageBox.Show("Dobrodošli", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Krivi podaci", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
