using Market.ORM.Entity;
using Market.ORM.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketWinFormUI
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        #region ForumMove
        int mouseX, mouseY;
        bool mouseMove;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove)
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMove = false;
        }
        #endregion
        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(178, 8, 55);
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            EmployeesORM employeesORM = new EmployeesORM();
            Employees employees = new Employees();
            employees.Username = txtUsername.Text;
            employees.Pass = txtPassword.Text;

            Employees online = employeesORM.Login(employees);
            if(online != null)
            {
                EmployeesORM.onlineUser = online;
                MainFrm mainMenuFrm = new MainFrm();
                this.Hide();
                mainMenuFrm.ShowDialog();
            }
            else
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlış !!!");
        }


    }
}
