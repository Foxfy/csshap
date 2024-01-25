using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace session1
{
    public partial class MainForm : Form1
    {
        public MainForm()
        {
            InitializeComponent();
            fmanage = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.currenUser = "";
            Properties.Settings.Default.dataUser = "";
            Properties.Settings.Default.Save();
            currenLogin = null;
            userData = null;
            flogin.Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        List<long> whereAttracton(string str = "")
        {
            var list = (from itemAttraction in db.ItemAttractions
                        join attraction in db.Attractions on itemAttraction.AttractionID equals attraction.ID

                        where
                        attraction.Name.Contains(str)
                        select
                        itemAttraction.ItemID).ToList();

            return list;
        }
       
       

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
  
      
      
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void textBox1_Layout(object sender, LayoutEventArgs e)
        {
          
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
         
        }
     

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
