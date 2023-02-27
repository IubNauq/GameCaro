using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GameCaro
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        string UserDatafilePath;
        public Form2()
        {
            dt.Columns.Add("Username", typeof(string));
            dt.Columns.Add("Password", typeof(string));
            dt.Columns.Add("Score", typeof(string));

            UserDatafilePath = "ManageUserData.txt";

            if (File.Exists(UserDatafilePath))
            {
                string[] a = File.ReadAllLines(UserDatafilePath);
                string[] s;
                for (int i = 0; i < a.Length; ++i)
                {
                    s = a[i].Split(' ');
                    dt.Rows.Add(s[0], s[1], s[2]);
                }
            }
            else
            {
                MessageBox.Show("Can't read file");
            }

            InitializeComponent();
        }

        public string GetCurUsername()
        {
            return textBox_Username.Text;
        }

        public void AddScoreforPlayer(string username)
        {
            DataRow[] dr = dt.Select("Username='" + textBox_Username.Text + "'");
            int num = int.Parse(dr[0]["Score"].ToString());
            num++;
            dr[0]["Score"] = num;

            string data = "";
            foreach (DataRow row in dt.Rows)
            {
                data += row["Username"] + " " + row["Password"] + " " + row["Score"] + "\n";
            }
            File.WriteAllText(UserDatafilePath, data);
        }

        public string GetDataUsername()
        {
            string res = "";

            DataView dv = dt.DefaultView;
            dv.Sort = "Score DESC";
            dt = dv.ToTable();

            int index = 1;
            foreach (DataRow row in dt.Rows)
            {
                if (index == 9)
                    break;
                res += row["Username"] + "\n";
                index++;
            }
            return res;
        }

        public string GetDataScore()
        {
            string res = "";

            int index = 1;
            foreach (DataRow row in dt.Rows)
            {
                if (index == 9) 
                    break;
                res += row["Score"] + "\n";
                index++;
            }
            return res;
        }

        private void button_SignIn_Click(object sender, EventArgs e)
        {
            DataRow[] dr = dt.Select("Username='" + textBox_Username.Text + "'");
            if (dr.Length != 0)
            {
                if (dr[0]["Password"].ToString() == textBox_Password.Text)
                {
                    Form1 f1 = new Form1(this);
                    f1.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Wrong Password!!!");
                }
            }
            else
            {
                MessageBox.Show("Wrong Username!!!");
            }

        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            DataRow[] dr = dt.Select("Username='" + textBox_Username.Text + "'");
            if (dr.Length != 0)
            {
                MessageBox.Show("The username is existed!!!");
            }
            else if (textBox_Username.Text.Contains(' ') || textBox_Username.Text == "")
            {
                MessageBox.Show("Invalid Username!!!");
            }
            else if (textBox_Password.Text.Contains(' ') || textBox_Password.Text == "")
            {
                MessageBox.Show("Invalid Password!!!");
            }
            else
            {
                dt.Rows.Add(textBox_Username.Text, textBox_Password.Text, 0);

                string data = "";
                foreach (DataRow row in dt.Rows)
                {
                    data += row["Username"] + " " + row["Password"] + " " + row["Score"] + "\n";
                }
                File.WriteAllText(UserDatafilePath, data);

                MessageBox.Show("Register Success!!!");
            }

        }
    }
}
