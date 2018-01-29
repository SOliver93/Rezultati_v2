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
    public partial class SoccerSeasonsForm : Form
    {
        public SoccerSeasonsForm(string role)
        {
            InitializeComponent();
            labelStatus.Text = role;

            REST Seasons = new REST();
            List<SoccerSeason> lSeasons = Seasons.GetSoccerSeasons();            
            dataGridViewSeasons.DataSource = lSeasons;            

            DataGridViewImageColumn oTablicaButton = new DataGridViewImageColumn();
            oTablicaButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/table.png");            
            oTablicaButton.Width = 20;
            oTablicaButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSeasons.Columns.Add(oTablicaButton);

            DataGridViewImageColumn oTeamButton = new DataGridViewImageColumn();
            oTeamButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/team.png");
            oTeamButton.Width = 20;
            oTeamButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSeasons.Columns.Add(oTeamButton);

            DataGridViewImageColumn oUtakmicaButton = new DataGridViewImageColumn();
            oUtakmicaButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/utakmica.png");
            oUtakmicaButton.Width = 20;
            oUtakmicaButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewSeasons.Columns.Add(oUtakmicaButton);

            dataGridViewSeasons.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewSeasons.Rows[e.RowIndex].Selected = true;
            if (dataGridViewSeasons.CurrentCell.ColumnIndex.Equals(12) && e.RowIndex != -1)
            {
                try
                {
                    string sUrl = dataGridViewSeasons.Rows[e.RowIndex].Cells[9].Value.ToString();
                    FormLeague FormLeague = new FormLeague(this, sUrl);
                    FormLeague.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                            
            }

            else if (dataGridViewSeasons.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {
                try
                {
                    string sUrl2 = dataGridViewSeasons.Rows[e.RowIndex].Cells[10].Value.ToString();
                    FixturesForm FixturesForm = new FixturesForm(this, sUrl2);
                    FixturesForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            else if (dataGridViewSeasons.CurrentCell.ColumnIndex.Equals(14) && e.RowIndex != -1)
            {
                try
                {
                    string sUrl3 = dataGridViewSeasons.Rows[e.RowIndex].Cells[11].Value.ToString();
                    TeamsForm TeamsForm = new TeamsForm(this, sUrl3);
                    TeamsForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormUserLogin ful = new FormUserLogin();
            ful.Show();
        }

        private void pretraga_Click(object sender, EventArgs e)
        {
            string sPretrazi = (string)textBoxPretraga.Text;
            REST Seasons = new REST();
            List<SoccerSeason> lSeasons = Seasons.GetSoccerSeasons();
            dataGridViewSeasons.DataSource = lSeasons.Where(o => o.sCaption.Contains(sPretrazi)).ToList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (labelStatus.Text == "Admin")
            {
                FormEditUsers FormEditUsers = new FormEditUsers();
                FormEditUsers.Show();
            }
            else
            {
                MessageBox.Show("Samo administrator može uređivati korisnike!");
            }
        }

        private void SoccerSeasonForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
