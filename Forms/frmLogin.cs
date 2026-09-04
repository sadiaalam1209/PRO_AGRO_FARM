using System;
using System.Windows.Forms;
using Pro_Agro_farm.DataAccess;
using Pro_Agro_farm.Forms;

namespace Pro_Agro_farm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbRole.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string role = cmbRole.SelectedItem?.ToString().Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(role) || role == "Select Role")
            {
                lblError.Text = "Please select a role.";
                return;
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                if (role == "Admin")
                {
                    bool isValidAdmin = UserRepository.ValidateAdmin(username, password);
                    if (!isValidAdmin)
                    {
                        lblError.Text = "Invalid admin username or password.";
                        return;
                    }

                    OpenAdminPanel();
                }
                else if (role == "User")
                {
                    // Any non-empty username/password is accepted for a normal "User" role.
                    SessionCart.CustomerName = username;
                    SessionCart.SessionId = System.Guid.NewGuid().ToString();
                    OpenMainMenu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not log in: " + ex.Message, "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenMainMenu()
        {
            this.Hide();
            using (frmMainManu mainMenu = new frmMainManu())
            {
                mainMenu.ShowDialog();
            }
            this.Close();
        }

        private void OpenAdminPanel()
        {
            this.Hide();
            using (frmOrders ordersForm = new frmOrders())
            {
                ordersForm.ShowDialog();
            }
            this.Close();
        }
    }
}