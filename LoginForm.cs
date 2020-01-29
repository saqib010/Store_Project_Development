using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            //Add Supplier Activated, Test it
          //  pnl_change_pass.Visible = false;
            InitializeComponent();
            pnl_change_pass.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ///////////////////////////////////////////////////////////////////////////////////
        /* Validate user account*/
        private void logInButton_Click(object sender, EventArgs e)
        {
            if (text_username.Text != "" && IsAlphas_Only(text_username.Text) && text_password.Text != "")
            {
                Store.Login_Class log = new Store.Login_Class();

                if (log.validate(text_username.Text, text_password.Text))
                {
                    Store.Loading_Page lp = new Store.Loading_Page();
                    lp.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            // }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
         }
        ///////////////////////////////////////////////////////////////////////////////////
        /*
         * checking alphanumeric
         */
        private static bool IsAlphas_Only(string str)
        {
            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                    return false;
            }

            return true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            text_username.Text = "";
            text_password.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_change_pass_Click(object sender, EventArgs e)
        {
            pnl_change_pass.SetBounds(92, 23, 643, 350);
            pnl_change_pass.Visible = true;

        }

        private void btn_chng_pass_back_Click(object sender, EventArgs e)
        {
            pnl_change_pass.Visible = false;
        }

        private void btn_chng_pass_update_Click(object sender, EventArgs e)
        {
            if (txt_user.Text != "" && IsAlphas_Only(txt_user.Text) && txt_oldpass.Text != "" && txt_newpass.Text != "")
            {
                if (!txt_oldpass.Text.Equals(txt_newpass.Text))
                {
                    Store.Login_Class log = new Store.Login_Class();

                    if (log.update(txt_user.Text, txt_oldpass.Text, txt_newpass.Text))
                    {
                        MessageBox.Show("Password changed successfully ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnl_change_pass.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("username or oldpassword is incorrent ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("oldpassword and newpassword sholud not be same ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
                   
            }
            // }
            else
            {
                MessageBox.Show("please enter correct username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
            }
        }
    }
}
