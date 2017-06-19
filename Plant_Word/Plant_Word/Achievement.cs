using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plant_Word
{
    public partial class Achievement : Form
    {
        public Achievement()
        {
            InitializeComponent();
        }

        private void Achievement_Load(object sender, EventArgs e)
        {
            int i, j = 1;

            label2.Text = "";

            for(i=0;i<10;i++)
            {
                if(((Form1)(this.Owner)).my_achievement[i]==1)
                {
                    label2.Text += "\n" + j.ToString() + ". " + ((Form1)(this.Owner)).quest_list[i];
                    j++;
                }
            }
        }
    }
}
