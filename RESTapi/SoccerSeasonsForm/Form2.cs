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
    public partial class FormLeague : Form
    {
        private readonly SoccerSeasonsForm FormLeagueList;
        public string LeagueLink;
        public FormLeague(SoccerSeasonsForm FormLeague, string sUrl)
        {
            LeagueLink = sUrl;
            FormLeagueList = FormLeague;
            InitializeComponent();

            REST League = new REST();
            List<LeagueTable> lLeague = League.GetLeagueTable(LeagueLink);
            dataGridViewLeague.DataSource = lLeague;            

            List<string> lSortCriterias = new List<string>()
            {
                "‐",
                "Zabijeni golovi"                
            };
            comboBoxSortiranje.DataSource = lSortCriterias;
        }
        public SoccerSeasonsForm WindowsFormUser { get; private set; }

        private void dataGridViewLeague_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pretraga2_Click(object sender, EventArgs e)
        {
            string sPretrazi2 = (string)textBoxPretraga2.Text;
            REST League = new REST();
            List<LeagueTable> lLeague = League.GetLeagueTable(LeagueLink);
            dataGridViewLeague.DataSource = lLeague.Where(o => o.sTeamName.Contains(sPretrazi2)).ToList();
        }

        private void comboBoxSortiranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sKriterij = (string)comboBoxSortiranje.SelectedItem;
            REST League = new REST();
            List<LeagueTable> lLeague = League.GetLeagueTable(LeagueLink);
            switch (sKriterij)
            {
                case "Zabijeni golovi":
                    dataGridViewLeague.DataSource = lLeague.OrderBy(o => o.sGoals).ToList();
                    break;                
            }
        }

        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            REST League = new REST();
            List<LeagueTable> lLeague = League.GetLeagueTable(LeagueLink);
            if (checkBoxDesc.Checked == true)
            {
                dataGridViewLeague.DataSource = lLeague.OrderByDescending(o => o.sGoals).ToList();
            }
            else
            {
                dataGridViewLeague.DataSource = lLeague.OrderBy(o => o.sGoals).ToList();
            }
        }        
    }
}
