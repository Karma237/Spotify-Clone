using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchSongsForSpecificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm BF = new SearchForm();
            this.Hide();
            BF.Show();
        }

        private void button2_Click(object sender, EventArgs e) //logout
        {
            RegisterForm RF = new RegisterForm();
            this.Hide();
            RF.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void byCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm BF = new SearchForm();
            this.Hide();
            BF.Show();
        }

        private void bySongIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm BF = new SearchForm();
            this.Hide();
            BF.Show();
        }

        private void viewLibraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call yousra's report (but first: right click on the project name -> add -> existing item -> add only form.cs ale by-view al report bt3k + crystalReport.rpt)
            /* EX:
             *  FormName  XX = new FormName();       "FormName asm ale feha al report"
             *  this.Hide();
             *  XX.Show();
             *  
             *  PLEASE NOTE: 3'yry namespace bt3 al form.cs ale ht3mlelha include to (namespace pro) in both form.cs & form.designer.cs 
             */
        }
        private void editPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call omar's report (but first: right click on the project name -> add -> existing item -> add only form.cs)
            /* EX:
             *  FormName  XX = new FormName();       "FormName asm ale feha al report"
             *  this.Hide();
             *  XX.Show();
             *  PLEASE NOTE, to solve l error : 3'yry namespace bt3 al form.cs ale ht3mlelha include to (namespace pro) in both form.cs & form.designer.cs 
             */
        }
        private void likeSongToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DisconnectedMode  XX = new DisconnectedMode();
             this.Hide();
             XX.Show();      
        }
    }
}
