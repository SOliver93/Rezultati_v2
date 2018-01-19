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
        public SoccerSeasonsForm()
        {
            InitializeComponent();

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
                string sUrl = dataGridViewSeasons.Rows[e.RowIndex].Cells[9].Value.ToString();
                FormLeague FormLeague = new FormLeague(this,sUrl);                              
                FormLeague.Show();                
            }

            else if (dataGridViewSeasons.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {
                string sUrl2 = dataGridViewSeasons.Rows[e.RowIndex].Cells[10].Value.ToString();
                FixturesForm FixturesForm = new FixturesForm(this, sUrl2);
                FixturesForm.Show();
            }

            else if (dataGridViewSeasons.CurrentCell.ColumnIndex.Equals(14) && e.RowIndex != -1)
            {
                string sUrl3 = dataGridViewSeasons.Rows[e.RowIndex].Cells[11].Value.ToString();
                TeamsForm TeamsForm = new TeamsForm(this, sUrl3);
                TeamsForm.Show();
            }
        }
        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
