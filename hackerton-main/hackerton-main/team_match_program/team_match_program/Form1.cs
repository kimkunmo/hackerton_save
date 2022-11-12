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
    public partial class Form1 : Form
    {
        public class Team
        {
            public string TeamName { get; set; }
            public string adminNickname { get; set; }
            public List<string> nickname = new List<string>();
            public List<int> Win = new List<int>();
            public List<int> Defeat = new List<int>();
        }

        public class Myinfo
        {
            public string nickname { get; set; }
            public string id { get; set; }
            public string passward { get; set; }
            public int Win { get; set; }
            public int Defeat { get; set; }
        }

        public class UserInfo
        {
            public List<string> nickname = new List<string>();
            public List<string> id = new List<string>();
            public List<string> passward = new List<string>();
            public List<int> Win = new List<int>();
            public List<int> Defeat = new List<int>();
        }
        public List<Team> TeamList = new List<Team>();
        
        Myinfo myinfo = new Myinfo();
        UserInfo userinfo = new UserInfo();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            userinfo.nickname.Add("김근모01");
            userinfo.id.Add("asdf");
            userinfo.passward.Add("asdf");
            userinfo.Win.Add(3);
            userinfo.Defeat.Add(0);
            userinfo.nickname.Add("최재원");
            userinfo.id.Add("1234");
            userinfo.passward.Add("1234");
            userinfo.Win.Add(2);
            userinfo.Defeat.Add(1);
            Team team = new Team();
            userinfo.id.Add("1");
            userinfo.passward.Add("1");
            userinfo.nickname.Add("tester");
            userinfo.Win.Add(0);
            userinfo.Defeat.Add(0);
            bool flag = false;
            while (true)
            {
                frmLogin login = new frmLogin();
                DialogResult drResult = login.ShowDialog();
                if (drResult == DialogResult.Cancel)
                {
                    MessageBox.Show("로그인이 취소되었습니다. 프로그램을 종료합니다.");

                    login.Close();
                    Close();
                    break;
                }
                if (drResult == DialogResult.No)
                {
                    frmSignUp signup = new frmSignUp();
                    DialogResult sresult = signup.ShowDialog();
                    if (sresult == DialogResult.OK)
                    {
                        foreach (string username in userinfo.id)
                        {
                            if (username == signup.NewID)
                            {
                                MessageBox.Show("실패");
                                flag = true;
                            }
                        }
                        foreach (string username in userinfo.passward)
                        {
                            if (username == signup.NewPass)
                            {
                                MessageBox.Show("실패");
                                flag = true;
                            }
                        }
                        if (!flag)
                        {
                            userinfo.id.Add(signup.NewID);
                            userinfo.passward.Add(signup.NewPass);
                            userinfo.nickname.Add(signup.NickName);
                            userinfo.Win.Add(0);
                            userinfo.Defeat.Add(0);
                        }
                        else
                        {
                            MessageBox.Show("회원가입 실패");
                        }
                    }
                }
                
                else if (drResult == DialogResult.OK)
                {
                    for (int i = 0; i < userinfo.id.Count; i++)
                    {
                        if (userinfo.id[i] == login.inputID && userinfo.passward[i] == login.inputPass)
                        {
                            MessageBox.Show("성공");
                            frmOption option = new frmOption();
                            DialogResult oresult = option.ShowDialog();
                            if (oresult == DialogResult.OK)
                            {
                                myinfo.id = login.inputID;
                                myinfo.passward = login.inputPass;
                                for (int j = 0; j < userinfo.nickname.Count; j++)
                                {
                                    if (userinfo.passward[j] == myinfo.passward)
                                    {
                                        myinfo.nickname = userinfo.nickname[j];
                                    }
                                }
                                

                            }
                                goto EXITFOR;
                        }
                    }

                }
            }
        EXITFOR:
            MessageBox.Show("프로그램 실행");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeamCreate create = new frmTeamCreate();
            DialogResult crResult = create.ShowDialog();
            if (crResult == DialogResult.OK)
            {
                Team team = new Team();
                team.TeamName = create.name;
                team.adminNickname = myinfo.nickname;
                team.nickname.Add(myinfo.nickname);
                team.Win.Add(myinfo.Win);
                team.Defeat.Add(myinfo.Defeat);
                frmTeamManagement_admin admin = new frmTeamManagement_admin(myinfo, team);
                DialogResult adResult = admin.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
