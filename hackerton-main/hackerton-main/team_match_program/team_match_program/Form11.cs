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
    public partial class frmdisplay : Form
    {
        public frmdisplay(List<Form1.Team> teamlist, Form1.Myinfo myinfo, string enemy)
        {
            InitializeComponent();
            for (int i = 0; i < teamlist[myinfo.teamnum].nickname.Count; i++)
            {
                dataGridView1.Rows.Add(teamlist[myinfo.teamnum].nickname[i], teamlist[myinfo.teamnum].Win[i], teamlist[myinfo.teamnum].Defeat[i]);
            }
            for (int i = 0; i < teamlist.Count; i++)
            {
                if (teamlist[i].TeamName == enemy)
                {
                    for (int j = 0; j < teamlist[i].nickname.Count; j++)
                    {
                        dataGridView2.Rows.Add(teamlist[i].nickname[j], teamlist[i].Win[j], teamlist[i].Defeat[j]);
                    }
                }
            }
            textBox1.Text = enemy;
            textBox2.Text = teamlist[myinfo.teamnum].TeamName;
        }

        private void frmdisplay_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
