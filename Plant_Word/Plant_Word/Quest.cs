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
    public partial class Quest : Form
    {
        public 
        Panel[] quest_panel = new Panel[5];
        Button[] quest_btn = new Button[5];
        Label[] quest_label = new Label[5];
        string[] quest_detail = new string[5];

        public Quest()
        {
            InitializeComponent();
            init();
        }

        private void Quest_Load(object sender, EventArgs e)
        {
            load();
        }

        void init()
        {
            FontFamily fm = new FontFamily("微軟正黑體");
            Font f = new Font(fm, 13, FontStyle.Regular);
            /*****init panel*****/
            for (int i = 0; i < 2; i++) 
            {
                quest_panel[i] = new Panel();
                quest_panel[i].Height = 90;
                quest_panel[i].Width = 390;
                quest_panel[i].BackColor = SystemColors.AppWorkspace;
                flowLayoutPanel1.Controls.Add(quest_panel[i]);
            }

            /*****init button*****/
            for (int i = 0; i < 2; i++) 
            {
                quest_btn[i] = new Button();
                quest_btn[i].Height = 70;
                quest_btn[i].Width = 70;
                quest_btn[i].Location = new Point(310, 10);
                quest_btn[i].BackColor = Color.Transparent;
                quest_btn[i].Text = "完成";
                quest_btn[i].Font = f;
                quest_btn[i].Enabled = false;
                quest_btn[i].Name = i.ToString();
                quest_panel[i].Controls.Add(quest_btn[i]);
            }


            /*****init label*****/
            for (int i = 0; i < 2; i++)
            {
                quest_label[i] = new Label();

                quest_label[i].Height = 30;
                quest_label[i].Width = 100;
                quest_label[i].Font = f;
                quest_label[i].Location = new Point(15, 15);
                quest_panel[i].Controls.Add(quest_label[i]);
            }
        }

        void load()
        {
            /*****load button*****/
            for (int i = 0; i < 2; i++)
            {

            }

            /*****load label*****/
            for (int i = 0; i < 2; i++)
            {
                quest_label[i].Text = i.ToString();
            }
        }

    }
}
