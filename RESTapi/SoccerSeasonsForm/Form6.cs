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
    public partial class FormUserLogin : Form
    {
        public FormUserLogin()
        {
            InitializeComponent();

        }        
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repository\RESTapi\SoccerSeasonsForm\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Role From Login Where Username='" + textBoxUserName.Text + "' and Password='" + textBoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                SoccerSeasonsForm ss = new SoccerSeasonsForm(dt.Rows[0][0].ToString());
                ss.Show();
            }
            else
            {
                MessageBox.Show("Prijava nije uspjela!");
            }
        }
    }
}
