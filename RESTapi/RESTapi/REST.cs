using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace RESTapi
{
    public class REST
    {
        public List<SoccerSeason> lSeasons = new List<SoccerSeason>();
        public List<LeagueTable> lLeague = new List<LeagueTable>();
        public List<Fixtures> lFixtures = new List<Fixtures>();
        public List<Teams> lTeams = new List<Teams>();
        public List<Players> lPlayers = new List<Players>();
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            var Response = webresponse.StatusCode;                        
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
            enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }
        public List<SoccerSeason> GetSoccerSeasons()
        {
            List<SoccerSeason> lRESTSeasons = new List<SoccerSeason>();
            string sUrl = System.Configuration.ConfigurationManager.AppSettings["RestApiUrl"];
            string sJson = CallRestMethod(sUrl);
            JArray aJson = JArray.Parse(sJson);
            foreach (JObject item in aJson)
            {                  
                string ID = (string)item.GetValue("id");
                string Caption = (string)item.GetValue("caption");
                string League = (string)item.GetValue("league");
                string Year = (string)item.GetValue("year");
                string CurrentMatchday = (string)item.GetValue("currentMatchday");
                string NumberOfMatchdays = (string)item.GetValue("numberOfMatchdays");
                string NumberOfTeams = (string)item.GetValue("numberOfTeams");
                string NumberOfGames = (string)item.GetValue("numberOfGames");
                string LastUpdated = (string)item.GetValue("lastUpdated");
                string LeagueTable = (string)item["_links"]["leagueTable"]["href"];
                string Fixtures = (string)item["_links"]["fixtures"]["href"];
                string Teams = (string)item["_links"]["teams"]["href"];
                lRESTSeasons.Add(new SoccerSeason
                {
                    sID = ID,
                    sCaption = Caption,
                    sLeague = League,
                    sYear = Year,
                    sCurrentMatchday = CurrentMatchday,
                    sNumberOfMatchdays = NumberOfMatchdays,
                    sNumberOfTeams = NumberOfTeams,
                    sNumberOfGames = NumberOfGames,
                    sLastUpdated = LastUpdated,
                    sLeagueTable = LeagueTable,
                    sFixtures = Fixtures,
                    sTeams = Teams
                });
            }
            return lRESTSeasons;
        }
        public List<LeagueTable> GetLeagueTable(string sUrl)
        {
            Debug.WriteLine(sUrl);                      
            string sJson = CallRestMethod(sUrl);
            JObject oJson = JObject.Parse(sJson);
            var oLeagueTable = oJson["standing"].ToList();
            List<LeagueTable> lRESTLeague = new List<LeagueTable>();
            for (int i = 0; i < oLeagueTable.Count; i++)
            {
                lRESTLeague.Add(new LeagueTable
                {
                    sPosition = (string)oLeagueTable[i]["position"],
                    sTeamName = (string)oLeagueTable[i]["teamName"],
                    sGamesPlayed = (string)oLeagueTable[i]["playedGames"],
                    sPoints = (string)oLeagueTable[i]["points"],
                    sGoals = (string)oLeagueTable[i]["goals"],
                    sGoalsAgainst = (string)oLeagueTable[i]["goalsAgainst"],
                    sGoalDifference = (string)oLeagueTable[i]["goalDifference"],
                    sWins = (string)oLeagueTable[i]["wins"],
                    sDraws = (string)oLeagueTable[i]["draws"],
                    sLosses = (string)oLeagueTable[i]["losses"]
                });
            }            
            return lRESTLeague;
        }

        public List<Fixtures> GetFixtures(string sUrl2)
        {
            Debug.WriteLine(sUrl2);
            string sJson = CallRestMethod(sUrl2);
            JObject oJson = JObject.Parse(sJson);
            var oFixtures = oJson["fixtures"].ToList();
            List<Fixtures> lRESTFixtures = new List<Fixtures>();
            for (int i = 0; i < oFixtures.Count; i++)
            {
                lRESTFixtures.Add(new Fixtures
                {
                    sFixtureDate = (string)oFixtures[i]["date"],
                    sFixtureMatchday = (string)oFixtures[i]["matchday"],
                    sHomeTeamName = (string)oFixtures[i]["homeTeamName"],
                    sAwayTeamName = (string)oFixtures[i]["awayTeamName"],
                    sGoalsHomeTeam = (string)oFixtures[i]["result"]["goalsHomeTeam"],
                    sGoalsAwayTeam = (string)oFixtures[i]["result"]["goalsAwayTeam"],                    
                });
            }
            return lRESTFixtures;
        }

        public List<Teams> GetTeams(string sUrl3)
        {
            Debug.WriteLine(sUrl3);
            string sJson = CallRestMethod(sUrl3);
            JObject oJson = JObject.Parse(sJson);
            var oTeams = oJson["teams"].ToList();
            List<Teams> lRESTTeams = new List<Teams>();
            for (int i = 0; i < oTeams.Count; i++)
            {
                lRESTTeams.Add(new Teams
                {
                    sTeamName = (string)oTeams[i]["name"],
                    sPlayers = (string)oTeams[i]["_links"]["players"]["href"],
            });
            }
            return lRESTTeams;
        }

        public List<Players> GetPlayers(string sUrl4)
        {
            Debug.WriteLine(sUrl4);
            string sJson = CallRestMethod(sUrl4);
            JObject oJson = JObject.Parse(sJson);
            var oPlayers = oJson["players"].ToList();
            List<Players> lRESTPlayers = new List<Players>();
            for (int i = 0; i < oPlayers.Count; i++)
            {
                lRESTPlayers.Add(new Players
                {
                    sPName = (string)oPlayers[i]["name"],
                    sPosition = (string)oPlayers[i]["position"],
                    sjerseyNumber = (string)oPlayers[i]["jerseyNumber"],
                    sdateOfBirth = (string)oPlayers[i]["dateOfBirth"],
                    snationality = (string)oPlayers[i]["nationality"],
                    scontractUntil = (string)oPlayers[i]["contractUntil"],                    
            });
            }
            return lRESTPlayers;
        }

        public List<Users> GetUsers()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repository\RESTapi\SoccerSeasonsForm\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Users", con);
            DataTable dt = new DataTable();           
            sda.Fill(dt);
            List<Users> lRESTUsers = new List<Users>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lRESTUsers.Add(new Users
                {
                    nUserID = (int)dt.Rows[i]["Id"],
                    sUsername = (string)dt.Rows[i]["Username"],
                    sPassword = (string)dt.Rows[i]["Password"],
                    sRole = (string)dt.Rows[i]["Role"]
                });
            }
            return lRESTUsers;
        } 
        
        public void DeleteUser(Users oUser)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repository\RESTapi\SoccerSeasonsForm\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM Users WHERE Id='" + oUser.nUserID + "'", con);
            DataTable dt = new DataTable();            
            sda.Fill(dt);
            dt.AcceptChanges();
        }
        public void EditUser(Users oUser)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repository\RESTapi\SoccerSeasonsForm\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("UPDATE Users SET Username='" + oUser.sUsername + "', Password= '" + oUser.sPassword + "', Role='" + oUser.sRole + "' WHERE Id=" + oUser.nUserID, con);
            DataTable dt = new DataTable();            
            sda.Fill(dt);
            dt.AcceptChanges();
        }
        public void AddUser(Users oUser)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repository\RESTapi\SoccerSeasonsForm\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda2 = new SqlDataAdapter("Select * From Users", con2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            List<Users> lRESTUsers = new List<Users>();
            int n = 1;
            int IdCount;
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                n = n + 1;
            }
            IdCount = n;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Repository\RESTapi\SoccerSeasonsForm\Login.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO Users (Id, Username, Password, Role) VALUES ('" + IdCount + "', '" + oUser.sUsername + "', '" + oUser.sPassword + "', '" + oUser.sRole + "' );", con);
            DataTable dt = new DataTable();            
            sda.Fill(dt);
            dt.AcceptChanges();
        }        
    }        
                   
}

