using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Plant_Word
{
    public partial class Store : Form
    {
        int store_num = 27;
        int item_num = 36;
        Panel[] store_panel = new Panel[27];
        Button[] store_btn = new Button[27];
        Label[,] store_label = new Label[27, 2];
        Panel[] item_panel = new Panel[36];
        Label[] item_image = new Label[36];
        Label[,] item_label = new Label[36, 2];
        Label money = new Label();

        /***********事件聲音***********/
        public SoundPlayer buy = new SoundPlayer();

        public Store()
        {
            InitializeComponent();
            init();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            load();
        }

        void init()
        {
            int i;

            /*****事件聲音，只能.wav*****/
            buy.SoundLocation = "../../sounds/buy.wav";

            /**********************************store**********************************/
            /************init panel*************/
            for (i = 0; i < store_num; i++)
            {
                store_panel[i] = new Panel();
                store_panel[i].Height = 90;
                store_panel[i].Width = 200;
                store_panel[i].BackColor = SystemColors.AppWorkspace;
                store_panel[i].MouseEnter += flowLayoutPanel1_MouseEnter;
                flowLayoutPanel1.Controls.Add(store_panel[i]);
            }

            /************init button*************/
            for (i = 0; i < store_num; i++)
            {
                store_btn[i] = new Button();
                store_btn[i].Height = 70;
                store_btn[i].Width = 70;
                store_btn[i].Location = new Point(9, 9);
                store_btn[i].BackColor = Color.Transparent;
                store_btn[i].FlatStyle = FlatStyle.Popup;
                store_btn[i].Name = i.ToString();
                store_panel[i].Controls.Add(store_btn[i]);
                store_btn[i].Click += new EventHandler(store_btn_Click);
            }

            /************init label*************/
            for (i = 0; i < 26; i++)
            {
                store_label[i, 0] = new Label();
                store_label[i, 1] = new Label();

                store_label[i, 0].Height = 15;
                store_label[i, 0].Width = 100;
                store_label[i, 0].Location = new Point(90, 25);
                store_panel[i].Controls.Add(store_label[i, 0]);

                store_label[i, 1].Height = 15;
                store_label[i, 1].Width = 100;
                store_label[i, 1].Location = new Point(90, 50);
                store_panel[i].Controls.Add(store_label[i, 1]);
            }
            for (i = 26; i < store_num; i++)
            {
                store_label[i, 0] = new Label();
                store_label[i, 1] = new Label();

                store_label[i, 0].Height = 15;
                store_label[i, 0].Width = 100;
                store_label[i, 0].Location = new Point(90, 25);
                store_panel[i].Controls.Add(store_label[i, 0]);

                store_label[i, 1].Height = 15;
                store_label[i, 1].Width = 100;
                store_label[i, 1].Location = new Point(90, 50);
                store_panel[i].Controls.Add(store_label[i, 1]);
            }

            /**********************************item***********************************/
            /************init panel*************/
            for (i = 0; i < item_num; i++)
            {
                item_panel[i] = new Panel();
                item_panel[i].Height = 90;
                item_panel[i].Width = 200;
                item_panel[i].BackColor = SystemColors.AppWorkspace;
                item_panel[i].MouseEnter += flowLayoutPanel2_MouseEnter;
                flowLayoutPanel2.Controls.Add(item_panel[i]);
            }

            /************init image*************/
            for (i = 0; i < item_num; i++)
            {
                item_image[i] = new Label();
                item_image[i].Height = 70;
                item_image[i].Width = 70;
                item_image[i].Location = new Point(9, 9);
                item_image[i].BackColor = Color.Transparent;
                item_image[i].FlatStyle = FlatStyle.Popup;
                item_image[i].Name = i.ToString();
                item_panel[i].Controls.Add(item_image[i]);
            }

            /************init label*************/
            for (i = 0; i < item_num; i++)
            {
                item_label[i, 0] = new Label();
                item_label[i, 1] = new Label();

                item_label[i, 0].Height = 15;
                item_label[i, 0].Width = 100;
                item_label[i, 0].Location = new Point(90, 25);
                item_panel[i].Controls.Add(item_label[i, 0]);

                item_label[i, 1].Height = 15;
                item_label[i, 1].Width = 100;
                item_label[i, 1].Location = new Point(90, 50);
                item_panel[i].Controls.Add(item_label[i, 1]);
            }

            /************init money*************/
            FontFamily fm = new FontFamily("微軟正黑體");
            Font f = new Font(fm, 13, FontStyle.Regular);

            money.Height = 25;
            money.Width = 200;
            money.Location = new Point(730, 690);
            money.Font = f;
            this.Controls.Add(money);

        }
        /************************load**************************/
        void load()
        {
            int i, j;

            /**********************************store**********************************/
            /************load button*************/
            for (i = 0; i < 26; i++)
            {
                store_btn[i].Image = ((Form1)this.Owner).item_img[0];
            }
            for(i = 26; i < store_num; i++)
            {
                store_btn[i].Image = ((Form1)this.Owner).item_img[i+28];
            }

            /************load label*************/
            for (i = 0; i < 26; i++)
            {
                store_label[i, 0].Text = "字母" + Convert.ToChar(i + 65) + "的種子";

                store_label[i, 1].Text = "200元";
            }
            for (i = 26; i < store_num; i++)
            {
                store_label[i, 0].Text = ((Form1)(this.Owner)).all_item_name[i+28];

                store_label[i, 1].Text = "600元";
            }

            /**********************************item***********************************/
            /************load image*************/
            for (i = 0, j = 0; i < item_num; i++) 
            {
                item_image[i].Name = "-1";
                item_image[i].Image = null;
                item_image[i].Text = null;
                item_label[i, 0].Text = null;
                item_label[i, 1].Text = null;

                for (; j < 100; j++) 
                {
                    if (((Form1)(this.Owner)).my_item[j] > 0)
                    {
                        if (j >= 2 && j <= 27)      //2~27是種子
                        {
                            item_image[i].Name = j.ToString();
                            item_image[i].Image = ((Form1)this.Owner).item_img[0];
                            /*****load label*****/
                            item_label[i, 0].Text = ((Form1)(this.Owner)).all_item_name[j] + "種子";
                            item_label[i, 1].Text = ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                        else if (j >= 54 && j <= 79)      //54~79是長完的字母
                        {
                            item_image[i].Name = j.ToString();
                            item_image[i].Image = ((Form1)this.Owner).item_img[j - 26];
                            /*****load label*****/
                            item_label[i, 0].Text = ((Form1)(this.Owner)).all_item_name[j - 52] + "字母";
                            item_label[i, 1].Text = ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                        else if(j>=80)              //道具
                        {
                            item_image[i].Name = j.ToString();
                            item_image[i].Image = ((Form1)this.Owner).item_img[j-26];
                            /*****load label*****/
                            item_label[i, 0].Text = ((Form1)(this.Owner)).all_item_name[j-26];
                            item_label[i, 1].Text = ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                    }
                }
            }


            /************load money*************/
            money.Text = "目前擁有金錢：" + ((Form1)(this.Owner)).money.ToString();
        }


        /******************for scroll bar****************/
        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel1.Focus();
        }

        private void flowLayoutPanel2_MouseEnter(object sender, EventArgs e)
        {
            flowLayoutPanel2.Focus();
        }

        /*****btn click*****/
        private void store_btn_Click(object sender, EventArgs e)
        {
            int btn_index = int.Parse(((Button)sender).Name);
            int how_much;

            if (btn_index >= 0 && btn_index <= 25)
                how_much = 200;
            else
                how_much = 600;

            if (((Form1)(this.Owner)).money-how_much < 0) 
            {
                //沒錢 QQ
            }
            else
            {
                if (btn_index >= 0 && btn_index <= 25)
                {
                    ((Form1)(this.Owner)).my_item[btn_index + 2]++;
                }
                else
                {
                    ((Form1)(this.Owner)).my_item[btn_index + 54]++;
                }

                ((Form1)(this.Owner)).money -= how_much;
                buy.Play();
                load();
            }
        }
    }
}
