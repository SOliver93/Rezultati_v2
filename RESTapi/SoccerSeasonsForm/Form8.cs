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
using RESTapi;

namespace SoccerSeasonsForm
{
    public partial class AddUser : Form
    {
        private readonly FormEditUsers FormUserList;
        public AddUser(FormEditUsers FormUser)
        {
            FormUserList = FormUser;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            Users oUser = new Users();           
            oUser.sUsername = textBoxAddUsername.Text;
            oUser.sPassword = textBoxAddPassword.Text;
            oUser.sRole = textBoxPrivilege.Text;           
            REST REST = new REST();
            REST.AddUser(oUser);
            this.FormUserList.dataGridViewUsers.DataSource = REST.GetUsers();
            this.Hide();
        }
    }
}
