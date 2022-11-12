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
    public partial class frmLogin : Form
    {
        public string inputID = "";
        public string inputPass = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null)
            {
                inputID = textBox1.Text;
                inputPass = textBox2.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("아이디 및 비밀번호를 입력해주세요.");
            }
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;

            }
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
