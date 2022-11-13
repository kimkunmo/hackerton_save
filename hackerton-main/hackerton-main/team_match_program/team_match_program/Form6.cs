using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace team_match_program
{
    public partial class frmTeamJoin : Form
    {
        List<Form1.Team> _teamlist;
        Form1.Myinfo _myinfo;
        string teamname;
        public frmTeamJoin(List<Form1.Team> teamlist, Form1.Myinfo myinfo)
        {
            _myinfo = myinfo;
            _teamlist = teamlist;
            InitializeComponent();
        }

        private void frmTeamJoin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teamname = textBox1.Text;
            for (int i = 0; i < _teamlist.Count; i++)
            {
                if (teamname == _teamlist[i].TeamName)
                {
                    MessageBox.Show("가입 성공");
                    _teamlist[i].nickname.Add(_myinfo.nickname);
                    _teamlist[i].Win.Add(_myinfo.Win);
                    _teamlist[i].Defeat.Add(_myinfo.Defeat);
                    _myinfo.teamnum = _teamlist[i].TeamNum;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            teamname = textBox1.Text;
            for (int i = 0; i < _teamlist.Count; i++)
            {
                if (teamname == _teamlist[i].TeamName)
                {
                    for (int j = 0; j < _teamlist[i].nickname.Count; j++)
                    {
                        dataGridView1.Rows.Add(_teamlist[i].nickname[j], _teamlist[i].Win[j], _teamlist[i].Defeat[j]);
                    }
                }
            }
        }
    }
}
