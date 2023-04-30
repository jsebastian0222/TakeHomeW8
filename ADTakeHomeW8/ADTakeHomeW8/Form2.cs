using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ADTakeHomeW8
{
    public partial class Form2 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionstring = "server=localhost;uid=root;pwd=123;database=premier_league";
        string query;

        DataTable dtTeam = new DataTable();
        DataTable dtPlayer = new DataTable();
        DataTable dtPemain = new DataTable();
        DataTable dtPlayerid = new DataTable();
        DataTable dtCard = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);

            comboBoxTeam.DataSource = dtTeam;
            comboBoxTeam.DisplayMember = "team_name";
        }
        private void playerid(string namaplayer)
        {
            dtPlayerid = new DataTable();
            query = $"SELECT player_id\r\nFROM player\r\nWhere player_name='{namaplayer}';";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPlayerid);
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pilih = comboBoxTeam.Text;
            dtPlayer = new DataTable();
            query = $"SELECT p.player_name as'player'\r\nfrom player p,premier_league.team t \r\nwhere p.team_id=t.team_id and t.team_name='{pilih}' ;";
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPlayer);

            comboBoxPlayer.DataSource = dtPlayer;
            comboBoxPlayer.DisplayMember = "player";

            comboBoxPlayer.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string teamName = comboBoxTeam.Text;
            string playerName = comboBoxPlayer.Text;

            string positionQuery = "SELECT CASE " +
                                   "WHEN playing_pos = 'G' THEN 'GoalKeeper' " +
                                   "WHEN playing_pos = 'M' THEN 'MidFielder' " +
                                   "WHEN playing_pos = 'D' THEN 'Defender' " +
                                   "ELSE 'Forward' " +
                                   "END as 'Position' " +
                                   "FROM player " +
                                   $"WHERE player_name = '{playerName}'";

            string query = "SELECT p.player_name, t.team_name, (" + positionQuery + "), n.nation, p.team_number " +
                           "FROM player p, nationality n, team t " +
                           $"WHERE p.team_id = t.team_id AND p.nationality_id = n.nationality_id AND p.player_name = '{playerName}' AND t.team_name = '{teamName}'";

            dtPemain = new DataTable();
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPemain);

            labelname.Text = dtPemain.Rows[0]["player_name"].ToString();
            labelteam.Text = dtPemain.Rows[0]["team_name"].ToString();
            labelpos.Text = dtPemain.Rows[0]["Position"].ToString();
            labelnationality.Text = dtPemain.Rows[0]["nation"].ToString();
            labelnum.Text = dtPemain.Rows[0]["team_number"].ToString();

            playerid(playerName);
            string playerId = dtPlayerid.Rows[0][0].ToString();

            query = $"SELECT type, COUNT(type) as count FROM dmatch WHERE player_id='{playerId}' GROUP BY type;";

            dtCard = new DataTable();
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtCard);

            int yellowCards = 0;
            int redCards = 0;
            int goals = 0;
            int penalties = 0;

            for (int i = 0; i < dtCard.Rows.Count; i++)
            {
                string type = dtCard.Rows[i]["type"].ToString();
                int count = Convert.ToInt32(dtCard.Rows[i]["count"]);

                switch (type)
                {
                    case "CY":
                        yellowCards = count;
                        break;
                    case "CR":
                        redCards = count;
                        break;
                    case "GO":
                        goals = count;
                        break;
                    case "PM":
                        penalties = count;
                        break;
                }
            }

            labelredcard.Text = redCards.ToString();
            labelyellowcard.Text = yellowCards.ToString();
            labelgoal.Text = goals.ToString();
            labelpenalty.Text = penalties.ToString();

        }
    }
}
