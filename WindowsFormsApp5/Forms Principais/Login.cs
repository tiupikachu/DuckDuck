﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp5
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            TxtLogin.Text = Properties.Settings.Default.login;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static string login;
        public void button1_Click(object sender, EventArgs e)
        {
            carrega_login();
            
        }
        private void carrega_login()
        {
            SqlConnection con = new SqlConnection(WindowsFormsApp5.Properties.Settings.Default.DuckDuckConnectionString);
            SqlCommand cmd = new SqlCommand("s_Verifica_Login", con);
            cmd.Parameters.AddWithValue("@login", TxtLogin.Text);
            cmd.Parameters.AddWithValue("@senha", TxtSenha.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            login = TxtLogin.Text;
            con.Open();
            try
            {
                Properties.Settings.Default.login = TxtLogin.Text;
                Properties.Settings.Default.Save();
                int i = cmd.ExecuteNonQuery();
                FrmPri frmPri = new FrmPri(login);
                this.Hide();
                con.Close();
                frmPri.ShowDialog();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void FrmLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            carrega_login(); 
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                carrega_login();
            }
        }
    }

}

