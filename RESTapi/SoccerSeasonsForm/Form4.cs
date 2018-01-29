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
    public partial class TeamsForm : Form
    {
        private readonly SoccerSeasonsForm TeamsFormList;
        public string LeagueLink3;
        public TeamsForm(SoccerSeasonsForm TeamsForm, string sUrl3)
        {
            LeagueLink3 = sUrl3;
            TeamsFormList = TeamsForm;
            InitializeComponent();

            REST Teams = new REST();
            List<Teams> lTeams = Teams.GetTeams(LeagueLink3);
            dataGridViewTeams.DataSource = lTeams;

            DataGridViewImageColumn oTablicaButton = new DataGridViewImageColumn();
            oTablicaButton.Image = Image.FromFile("D:/Repository/RESTapi/SoccerSeasonsForm/player.png");
            oTablicaButton.Width = 20;
            oTablicaButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTeams.Columns.Add(oTablicaButton);

            dataGridViewTeams.AutoGenerateColumns = false;
        }
        public SoccerSeasonsForm WindowsFormUser { get; private set; }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTeams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTeams.Rows[e.RowIndex].Selected = true;
            if (dataGridViewTeams.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
            {
                try
                {
                    string sUrl4 = dataGridViewTeams.Rows[e.RowIndex].Cells[1].Value.ToString();
                    FormPlayers FormPlayers = new FormPlayers(this, sUrl4);
                    FormPlayers.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
