using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlokForm
{
    public partial class fmAvtor : Form
    {
        SqlDataReader read;
        SqlCommand cmd;
        SqlConnection conect = BDUtils.GetDBConnection2();

        static int counter = 0; //статическое поле формы

        public fmAvtor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (string.IsNullOrEmpty(txtlog.Text))
            //{
            //    MessageBox.Show("Введите Email");
            //    txtlog.Focus();
            //    return;
            //}
            //else if (string.IsNullOrEmpty(txtPassword.Text))
            //{
            //    MessageBox.Show("Введите пароль");
            //    txtPassword.Focus();
            //    return;
            //}
            //else
            //{
            //    counter++;
            //    conect.Open();

            //    cmd = new SqlCommand(@"SELECT [Password],[Role] FROM [USERS] WHERE Login='" + txtlog.Text + "'", conect);

            //    try
            //    {
            //        read = cmd.ExecuteReader();
            //        read.Read();
            //        counter++;
            //        if (txtPassword.Text == read[0].ToString())
            //        {
            //            Program.Email = txtlog.Text;
            //            Program.Password = txtPassword.Text;
            //            Program.Role = read[1].ToString();
            //            switch (Program.Role)
            //            {
            //                case "Заказчик":
            //                    fmVhod zakaachik = new fmVhod();
            //                    zakaachik.Show();
            //                    break;
            //            }
            //        }
            //        else
            //        { 
            //            MessageBox.Show("Связка логин-пароль введены неверно\nПроверьте введеные вами данные и повторите попытку");
            //            txtlog.Focus();
            //            read.Close();
            //        }

            //    }
            //    catch
            //    {
            //        if (counter >= 3) // лимит превышен
            //        {
            //            tm.Interval = 5000;
            //            tm.Start();
            //            txtlog.Enabled = false; //блокируем текстбокс
            //            txtPassword.Enabled = false;
            //            lblBlok.Visible = true;
            //            lblBlok.Text = "Форма заблокирована на 5 секунд";
            //            lblBlok.BringToFront();
            //            this.FormBorderStyle = FormBorderStyle.None;

            //        }

            //    }
            //    finally
            //    {
            //        //MessageBox.Show("Пользователь с таким логином не зарегистрирован в системе\nПроверьте введённые данные и повторите попытку");
            //        txtlog.Focus();
            //        conect.Close();
            //    }

            //}
            fmVhod vhod = new fmVhod();
            vhod.Show();

        }

        private void tm_Tick(object sender, EventArgs e)
        {
            tm.Stop();
            
            MessageBox.Show("повторите попытку заново!");
            txtlog.Enabled = true;
            txtPassword.Enabled = true;
            counter = 0;
            lblBlok.Visible = false;
            lblBlok.Text = "";
            lblBlok.SendToBack();
            this.FormBorderStyle = FormBorderStyle.Sizable;

        }
    }
}
