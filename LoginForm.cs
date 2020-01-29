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
            //Changed
            InitializeComponent();
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
    }
}
