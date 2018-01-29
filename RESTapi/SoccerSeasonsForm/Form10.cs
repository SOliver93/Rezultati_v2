using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RESTapi;

namespace SoccerSeasonsForm
{
    public partial class FormEditUserInfo : Form
    {
        private readonly FormEditUsers FormUserList;
        public FormEditUserInfo(FormEditUsers FormUser)
        {
            FormUserList = FormUser;
            InitializeComponent();
        }

        public FormEditUsers WindowsFormUser { get; private set; }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            Users oUser = new Users();
            oUser.nUserID = Int32.Parse(textBoxEditId.Text);
            oUser.sUsername = inptEditUsername.Text;
            oUser.sPassword = inptEditPassword.Text;
            oUser.sRole = inptEditRole.Text;            
            REST REST = new REST();
            REST.EditUser(oUser);
            this.FormUserList.dataGridViewUsers.DataSource = REST.GetUsers();
            this.Hide();
        }
    }
}
