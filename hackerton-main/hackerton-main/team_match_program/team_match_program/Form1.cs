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
            public int TeamNum { get; set; }
            public string TeamName { get; set; }
            public string adminNickname { get; set; }
            public List<string> nickname = new List<string>();
            public List<int> Win = new List<int>();
            public List<int> Defeat = new List<int>();
        }

        public class Myinfo
        {
            public int teamnum { get; set; }
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
            myinfo.teamnum = -1;
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
            userinfo.id.Add("1");
            userinfo.passward.Add("1");
            userinfo.nickname.Add("tester");
            userinfo.Win.Add(0);
            userinfo.Defeat.Add(0);
            Team t = new Team();
            t.TeamName = "test01";
            t.TeamNum = 0;
            t.adminNickname = "김근모01";
            t.nickname.Add("김근모01");
            t.Defeat.Add(0);
            t.Win.Add(3);
            t.nickname.Add("테스터1");
            t.Defeat.Add(1);
            t.Win.Add(3);
            t.nickname.Add("테스터2");
            t.Defeat.Add(0);
            t.Win.Add(7);
            t.nickname.Add("테스터3");
            t.Defeat.Add(0);
            t.Win.Add(3);
            t.nickname.Add("테스터6");
            t.Defeat.Add(6);
            t.Win.Add(8);
            TeamList.Add(t);

            t = new Team();
            t.TeamName = "test02";
            t.TeamNum = 1;
            t.adminNickname = "최재원";
            t.nickname.Add("최재원");
            t.Defeat.Add(2);
            t.Win.Add(1);
            t.nickname.Add("테스터9");
            t.Defeat.Add(9);
            t.Win.Add(1);
            t.nickname.Add("테스터24");
            t.Defeat.Add(3);
            t.Win.Add(5);
            t.nickname.Add("테스터11");
            t.Defeat.Add(2);
            t.Win.Add(7);
            t.nickname.Add("테스터26");
            t.Defeat.Add(4);
            t.Win.Add(10);
            TeamList.Add(t);

            t = new Team();
            t.TeamName = "test03";
            t.TeamNum = 2;
            t.adminNickname = "박근민";
            t.nickname.Add("박근민");
            t.Defeat.Add(3);
            t.Win.Add(10);
            t.nickname.Add("테스터30");
            t.Defeat.Add(32);
            t.Win.Add(21);
            t.nickname.Add("테스터29");
            t.Defeat.Add(3);
            t.Win.Add(1);
            t.nickname.Add("테스터35");
            t.Defeat.Add(0);
            t.Win.Add(0);
            t.nickname.Add("테스터42");
            t.Defeat.Add(6);
            t.Win.Add(0);
            TeamList.Add(t);

            t = new Team();
            t.TeamName = "test04";
            t.TeamNum = 3;
            t.adminNickname = "양두영";
            t.nickname.Add("양두영");
            t.Defeat.Add(6);
            t.Win.Add(3);
            t.nickname.Add("테스터56");
            t.Defeat.Add(4);
            t.Win.Add(5);
            t.nickname.Add("테스터68");
            t.Defeat.Add(9);
            t.Win.Add(3);
            t.nickname.Add("테스터86");
            t.Defeat.Add(8);
            t.Win.Add(3);
            t.nickname.Add("테스터81");
            t.Defeat.Add(7);
            t.Win.Add(4);
            TeamList.Add(t);
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
                                        myinfo.Win = userinfo.Win[j];
                                        myinfo.Defeat = userinfo.Defeat[j];
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
            if (myinfo.teamnum != -1)
            {
                MessageBox.Show("이미 소속된 팀이 있습니다.");
            }
            else if (myinfo.teamnum == -1)
            {
                frmTeamCreate create = new frmTeamCreate();
                DialogResult crResult = create.ShowDialog();
                if (crResult == DialogResult.OK)
                {
                    Team team = new Team();
                    team.TeamNum = TeamList.Count;


                    team.TeamName = create.name;
                    team.adminNickname = myinfo.nickname;
                    team.nickname.Add(myinfo.nickname);
                    team.Win.Add(myinfo.Win);
                    team.Defeat.Add(myinfo.Defeat);
                    TeamList.Add(team);
                    myinfo.teamnum = team.TeamNum;
                    frmTeamManagement_admin admin = new frmTeamManagement_admin(ref myinfo, ref team);
                    DialogResult adResult = admin.ShowDialog();
                }
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (myinfo.teamnum != -1)
            {
                MessageBox.Show("이미 소속된 팀이 있습니다.");
            }
            else
            {
                frmTeamJoin join = new frmTeamJoin(TeamList, myinfo);
                DialogResult jResult = join.ShowDialog();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myinfo.teamnum == -1)
            {
                MessageBox.Show("소속된 팀이 없습니다.");
            }
            else if (TeamList[myinfo.teamnum].adminNickname != myinfo.nickname)
            {
                MessageBox.Show("팀 매칭은 방장만이 사용할 수 있습니다.");
            }
            else
            {
                frmmatching match = new frmmatching(TeamList, myinfo);
                DialogResult mResult = match.ShowDialog();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (myinfo.teamnum == -1)
            {
                MessageBox.Show("가입된 팀이 없습니다! 팀을 생성하거나, 가입하여 주십시오!");
            }
            if (myinfo.teamnum != -1 && myinfo.nickname == TeamList[myinfo.teamnum].adminNickname)
            {
                Team team = TeamList[myinfo.teamnum];
                frmTeamManagement_admin admin = new frmTeamManagement_admin(ref myinfo, ref team);
                DialogResult adResult = admin.ShowDialog();
            }
            else if (myinfo.teamnum != -1 && myinfo.nickname != TeamList[myinfo.teamnum].adminNickname)
            {
                Team team = TeamList[myinfo.teamnum];
                frmTeamManagement normal = new frmTeamManagement(team);
                DialogResult noResult = normal.ShowDialog();
            }
        }
    }
}
