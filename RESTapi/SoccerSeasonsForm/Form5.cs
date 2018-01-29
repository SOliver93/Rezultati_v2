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
    public partial class FormPlayers : Form
    {
        private readonly TeamsForm FormPlayersList;
        public string LeagueLink4;
        public FormPlayers(TeamsForm FormPlayers, string sUrl4)
        {
            LeagueLink4 = sUrl4;
            FormPlayersList = FormPlayers;
            InitializeComponent();

            REST Players = new REST();
            List<Players> lPlayers = Players.GetPlayers(LeagueLink4);
            dataGridViewPlayers.DataSource = lPlayers;
        }
        public TeamsForm WindowsFormUser { get; private set; }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPlayers_Click(object sender, EventArgs e)
        {
            string sPretrazi3 = (string)textBoxPlayers.Text;
            REST Players = new REST();
            List<Players> lPlayers = Players.GetPlayers(LeagueLink4);
            dataGridViewPlayers.DataSource = lPlayers.Where(o => o.sPName.Contains(sPretrazi3)).ToList();
            dataGridViewPlayers.DataSource = lPlayers.Where(o => o.sjerseyNumber.Contains(sPretrazi3)).ToList();
        }
    }
}
