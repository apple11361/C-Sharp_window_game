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
using System.Media;

namespace Plant_Word
{
    public partial class Quest : Form
    {
        SoundPlayer quest_finish = new SoundPlayer();
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

            /*****事件聲音，只能.wav*****/
            quest_finish.SoundLocation = "../../sounds/quest_finish.wav";

            /*****init panel*****/
            for (int i = 0; i < 5; i++) 
            {
                quest_panel[i] = new Panel();
                quest_panel[i].Height = 90;
                quest_panel[i].Width = 390;
                quest_panel[i].BackColor = SystemColors.AppWorkspace;
                flowLayoutPanel1.Controls.Add(quest_panel[i]);
            }

            /*****init button*****/
            for (int i = 0; i < 5; i++) 
            {
                quest_btn[i] = new Button();
                quest_btn[i].Height = 70;
                quest_btn[i].Width = 70;
                quest_btn[i].Location = new Point(310, 10);
                quest_btn[i].BackColor = Color.Transparent;
                quest_btn[i].Text = "完成";
                quest_btn[i].Font = f;
                quest_btn[i].Enabled = false;
                quest_btn[i].Visible = false;
                quest_btn[i].Name = i.ToString();
                quest_btn[i].Click += new EventHandler(quest_btn_Click);
                quest_panel[i].Controls.Add(quest_btn[i]);
            }


            /*****init label*****/
            for (int i = 0; i < 5; i++)
            {
                quest_label[i] = new Label();

                quest_label[i].Height = 30;
                quest_label[i].Width = 200;
                quest_label[i].Font = f;
                quest_label[i].Location = new Point(15, 15);
                quest_panel[i].Controls.Add(quest_label[i]);
            }
        }

        void load()
        {
            int i, j;

            /****************load my_quest***************/
            for (i = 0, j = 0; i < 5; i++)
            {
                quest_btn[i].Visible = false;
                quest_btn[i].Name = "-1";

                quest_label[i].Name = "-1";
                quest_label[i].Text = null;

                for (; j < 100; j++)
                {
                    if (((Form1)(this.Owner)).my_quest[j] > 0)
                    {
                        quest_btn[i].Name = j.ToString();
                        quest_btn[i].Visible = true;
                        if (check_quest(((Form1)(this.Owner)).quest_list[j]))
                            quest_btn[i].Enabled = true;
                        else
                            quest_btn[i].Enabled = false;

                        quest_label[i].Name = j.ToString();
                        quest_label[i].Text = "完成收集單字: \"" + ((Form1)(this.Owner)).quest_list[j] + "\"";
                        j++;
                        break;
                    }
                }
            }
        }

        bool check_quest(string quest)
        {
            int i;
            quest = quest.ToLower();
            int[] char_num = new int[26];
            char[] quest_char = new char[1];

            using (StringReader sr = new StringReader(quest))
            {
                for(i=0;i<quest.Length;i++)
                {
                    sr.Read(quest_char, 0, 1);
                    char_num[Convert.ToInt32(quest_char[0]) - Convert.ToInt32('a')]++;
                }

                for(i=0;i<26;i++)
                {
                    if (((Form1)this.Owner).my_item[i + 54] < char_num[i])
                        break;
                }

                if (i == 26)
                    return true;
                else
                    return false;
            }
        }

        /*****************完成被點擊****************/
        private void quest_btn_Click(object sender, EventArgs e)
        {
            int i;
            int[] char_num = new int[26];
            char[] quest_char = new char[1];

            int quest_id = int.Parse(((Button)sender).Name);
            string quest_str = (((Form1)(this.Owner)).quest_list[quest_id]).ToLower();

            ((Form1)(this.Owner)).my_quest[quest_id] = 0;
            ((Form1)(this.Owner)).my_achievement[quest_id] = 1;
            ((Form1)(this.Owner)).money += 600;

            for (i=0;i<quest_id;i++)                    //越後面任務錢越多
                ((Form1)(this.Owner)).money += 50;

            using (StringReader sr = new StringReader(quest_str))
            {
                for (i = 0; i < quest_str.Length; i++)
                {
                    sr.Read(quest_char, 0, 1);
                    char_num[Convert.ToInt32(quest_char[0]) - Convert.ToInt32('a')]++;
                }

                for (i = 0; i < 26; i++)
                {
                    ((Form1)this.Owner).my_item[i + 54] -= char_num[i];
                }
            }

            quest_finish.Play();
            load();
        }
    }
}
