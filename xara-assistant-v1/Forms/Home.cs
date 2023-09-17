using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xara_assistant_v1.Models.ViewModels;
using xara_assistant_v1.Services.Core;

namespace xara_assistant_v1.Forms
{
    public partial class Home : Form
    {
        private readonly ICore _core;
        public Home(ICore core)
        {
            InitializeComponent();
            _core = core;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var userVm = new LoginUserVm();

            userVm.Username = UsernameTxtBox.Text.ToString();
            userVm.Password = PasswordTxtBox.Text.ToString();

            // time to send data

            if (_core.IsUserLogin() == false)
            {
                _core.LoginUser(userVm);
            }

            var message = "You Are In !";
            MessageBox.Show(message);

        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            var createUser = new CreateAdminfm( _core );

            createUser.ShowDialog();
        }
    }
}
