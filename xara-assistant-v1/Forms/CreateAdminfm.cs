using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xara_assistant_v1.Models.Helper;
using xara_assistant_v1.Models.ViewModels;
using xara_assistant_v1.Services.Core;

namespace xara_assistant_v1.Forms
{
    public partial class CreateAdminfm : Form
    {
        private readonly ICore _core;

        public CreateAdminfm(ICore core)
        {
            InitializeComponent();
            _core = core;
        }
        private void UpdateForm()
        {
            PasswordTxtBox.Text = string.Empty;
            RePasswordTxtBox.Text = string.Empty;
            UsernameTxtBox.Text = string.Empty;
        }
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            var createUser = new CreateUserVm()
            {
                Password = PasswordTxtBox.Text.ToString(),
                RePassword = RePasswordTxtBox.Text.ToString(),
                Username = UsernameTxtBox.Text.ToString(),
            };


            if (createUser.Password != createUser.RePassword)
            {
                var message = "Repassword and Password!";
                MessageBox.Show(message);
                Thread.Sleep(500);
                 
                UpdateForm();
            }


            // time to create user
            var dataMessage = _core.CreateUser(createUser);
            if(dataMessage.ErrorId < 0 )
            {
                MessageBox.Show(dataMessage.Message);
                UpdateForm();
            }


            MessageBox.Show("Done");
            Thread.Sleep(500);

            UpdateForm();
            this.Close();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
