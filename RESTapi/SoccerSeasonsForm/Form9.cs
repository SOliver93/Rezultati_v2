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
    public partial class FormDeleteUser : Form
    {
        private readonly FormEditUsers FormUserList;
        public string ID;
        public string Password;
        public string Username;
        public string Role;
        public FormDeleteUser(FormEditUsers FormUser)
        {
            FormUserList = FormUser;
            InitializeComponent();
        }
        public FormEditUsers WindowsFormUser { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Users oUser = new Users();
            oUser.nUserID = Int32.Parse(ID);
            oUser.sUsername = Username;
            oUser.sPassword = Password;
            oUser.sRole = Role;
            REST REST = new REST();
            REST.DeleteUser(oUser);
            this.FormUserList.dataGridViewUsers.DataSource = REST.GetUsers();
            this.Hide();
        }
    }
}
