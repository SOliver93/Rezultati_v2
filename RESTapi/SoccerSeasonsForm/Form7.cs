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
    public partial class FormEditUsers : Form
    {
        
        public FormEditUsers()
        {
            InitializeComponent();                       

            REST Users = new REST();
            List<Users> lUsers = Users.GetUsers();
            dataGridViewUsers.DataSource = lUsers;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/edit.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oEditButton);

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewUsers.Columns.Add(oDeleteButton);

            dataGridViewUsers.AutoGenerateColumns = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddUser AddNewUser = new AddUser(this);
            AddNewUser.Show();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewUsers.Rows[e.RowIndex].Selected = true;
            if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormDeleteUser FormDeleteUser = new FormDeleteUser(this);
                FormDeleteUser.ID = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.Username = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormDeleteUser.Password = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormDeleteUser.Role = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormDeleteUser.Show();
            }            
            else if (dataGridViewUsers.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                FormEditUserInfo FormEditUserInfo = new FormEditUserInfo(this);
                FormEditUserInfo.textBoxEditId.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditUserInfo.inptEditUsername.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUserInfo.inptEditPassword.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUserInfo.inptEditRole.Text = dataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();               
                FormEditUserInfo.Show();
            }
        }
    }
}
