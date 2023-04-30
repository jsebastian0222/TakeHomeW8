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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ADTakeHomeW8
{
    public partial class Form3 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        string connectionstring = "server=localhost;uid=root;pwd=123;database=premier_league";
        string query;

        DataTable dtTeam = new DataTable();
        DataTable dtDate = new DataTable();
        DataTable dtHome = new DataTable();
        DataTable dtAway = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtMatchDetail = new DataTable();
        string pilih = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            query = "SELECT team_name FROM premier_league.team;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);

            comboBoxTeam.DataSource = dtTeam;
            comboBoxTeam.DisplayMember = "team_name";
        }

        private void GantiLabel()
        {
            if (comboBoxDate.SelectedIndex != -1)
            {
                DataRowView rowView = (DataRowView)comboBoxDate.SelectedItem;
                labelhome.Text = rowView["t1"].ToString();
                labelaway.Text = rowView["t2"].ToString();
            }
        }

        private void comboBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtDate = new DataTable();
            pilih = comboBoxTeam.Text;
            query = $"SELECT m.match_date as 'tanggal', t1.team_name as't1',t2.team_name as't2',m.match_id as'ID'\r\nFROM team t1,team t2, premier_league.match m\r\nWHERE (t1.team_name='{pilih}' or t2.team_name='{pilih}') AND t1.team_id=m.team_home AND t2.team_id=m.team_away;";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtDate);

            comboBoxDate.DataSource = dtDate;
            comboBoxDate.DisplayMember = "tanggal";
            GantiLabel();
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtMatch = new DataTable();
            query = $"select t1.team_name as 't1', t2.team_name as 't2' \r\nfrom premier_league.match m, team t1, team t2 \r\nwhere m.team_home = t1.team_id and m.team_away = t2.team_id and m.match_id = '{comboBoxDate.SelectedValue.ToString()}';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMatch);
            GantiLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtHome = new DataTable();
            string query = "SELECT t.team_name, p.player_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position'\r\nFROM player p, team t\r\nWHERE p.team_id=t.team_id AND t.team_name='" + labelhome.Text + "';";
            MySqlConnection sqlConnection = new MySqlConnection(connectionstring);
            MySqlCommand sqlCommand = new MySqlCommand(query, sqlConnection);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtHome);
            dataGridViewHome.DataSource = dtHome;

            DataTable dtAway = new DataTable();
            query = "SELECT t.team_name, p.player_name,if(p.playing_pos='G','GoalKeeper',if(p.playing_pos='M','MidFielder',if(p.playing_pos='D','Defender','Forward')))as'Position'\r\nFROM player p, team t\r\nWHERE p.team_id=t.team_id AND t.team_name='" + labelaway.Text + "';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtAway);
            dataGridViewaway.DataSource = dtAway;

            DataTable dtMatchDetail = new DataTable();
            query = "SELECT d.minute as'minute',t.team_name as'team name',p.player_name as'player name',if(d.type='CY','Yellow Card',if(d.type='CR','Red Card',if(d.type='GO','Goal',if(d.type='GP','Goal Penalty',if(d.type='GW','Own GOal','Penalty Miss'))))) as 'type'\r\nFROM dmatch d,team t,player p\r\nWHERE d.team_id=t.team_id AND d.player_id=p.player_id AND d.match_id='" + comboBoxDate.SelectedValue.ToString() + "';";
            sqlConnection = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtMatchDetail);
            dataGridViewDetails.DataSource = dtMatchDetail;
        
        }
    }
}
