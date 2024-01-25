using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session1
{
    public partial class RegisterForm : Form1
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("notepad.exe", Application.StartupPath + "\\Terms.txt");
            checkBox1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text).Trim() == "")
            {
                MessageBox.Show("กรุณาใส่ username");
                textBox1.Focus();
                return;
            }
            if ((textBox2.Text).Trim() == "")
            {
                MessageBox.Show("กรุณาใส่ชื่อ");
                textBox2.Focus();
                return;
            }
            if(dateTimePicker1.Text == "/ /")
            {
                MessageBox.Show("กรุณาใส่วันเดือนปีเกิด");
                dateTimePicker1.Focus();
                return;
            }
            if ((textBox3.Text).Trim() == "")
            {
                MessageBox.Show("กรุณาใส่ password");
                textBox4.Focus();
                return;
            }
            if ((textBox4.Text).Trim() == "")
            {
                MessageBox.Show("กรุณาใส่ retype password");
                textBox4.Focus();
                return;
            }
            if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("กรุณาใส่ password ให้ตรงกัน");
                textBox4.Focus();
                return;
            }
            if (!(radioButton1.Checked || radioButton2.Checked))
            {
                MessageBox.Show("กรุณาเลือกเพศ");
                radioButton1.Focus();
                return;
            }
            if (numericUpDown1.Value <= 0)
            {
                MessageBox.Show("กรุณาเลือกจำนวนครอบครัว");
                numericUpDown1.Focus();
                return;
            }
            if (!checkBox1.Checked)
            {
                MessageBox.Show("กรุณาอ่านข้อตกลงก่อน");
                return;
            }
            var p = db.Users.SingleOrDefault(x => x.Username == textBox1.Text);
            if (p != null)
            {
                MessageBox.Show("มีชื่อนี้แล้ว กรุณาใส่ username ใหม่");
                textBox1.Focus();
                return;
            }

            User add = new User();
            add.Username = textBox1.Text;
            add.UserTypeID = 2;
            add.Password = textBox3.Text;
            add.FullName = textBox2.Text;
            add.BirthDate = dateTimePicker1.Value;
            add.FamilyCount = (int)numericUpDown1.Value;
            add.Gender = radioButton1.Checked ? false : true;
            db.Users.InsertOnSubmit(add);
            db.SubmitChanges();
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form p in Application.OpenForms)
            {
                if (p.Name == "LoginForm")
                {
                    p.Show();
                    break;
                }
            }
        }
    }
}
