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
    public partial class Item : Form
    {
        SoundPlayer push = new SoundPlayer();
        int[] item = new int[36];
        Button[] item_btn = new Button[36];
        Label money = new Label();
        int item_num = 36;                      //item 總數


        public Item()
        {
            InitializeComponent();
            init();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            load();
        }

        void init()
        {
            int i;

            /*****事件聲音，只能.wav*****/
            push.SoundLocation = "../../sounds/push.wav";

            /****************init button*****************/
            for (i = 0; i < item_num; i++)
            {
                item_btn[i] = new Button();
                item_btn[i].Height = 70;
                item_btn[i].Width = 70;
                item_btn[i].BackColor = Color.Transparent;
                item_btn[i].FlatStyle = FlatStyle.Popup;
                item_btn[i].TextAlign = ContentAlignment.BottomLeft;
                item_btn[i].Name = "-1";
                item_btn[i].Click += new EventHandler(item_btn_Click);
                this.flowLayoutPanel1.Controls.Add(item_btn[i]);
            }

            /************init money*************/
            FontFamily fm = new FontFamily("微軟正黑體");
            Font f = new Font(fm, 13, FontStyle.Regular);

            money.Height = 25;
            money.Width = 200;
            money.Location = new Point(550, 50);
            money.Font = f;
            this.Controls.Add(money);
        }

        void load()
        {
            int i, j;

            /****************load my_item***************/
            for (i = 0, j = 0; i < item_num; i++)
            {

                item_btn[i].Name = "-1";
                item_btn[i].Image = null;
                item_btn[i].Text = null;

                for (; j < 100; j++)
                {
                    if (((Form1)(this.Owner)).my_item[j] > 0)
                    {
                        if (j >= 2 && j <= 27)          //2~27是種子
                        {
                            item_btn[i].Name = j.ToString();
                            item_btn[i].Image = ((Form1)this.Owner).item_img[0];
                            item_btn[i].Text = ((Form1)(this.Owner)).all_item_name[j] + "種子  " + ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                        else if(j >= 54 && j <= 79)      //54~79是長完的字母
                        {
                            item_btn[i].Name = j.ToString();
                            item_btn[i].Image = ((Form1)this.Owner).item_img[j-26];
                            item_btn[i].Text = ((Form1)(this.Owner)).all_item_name[j-52] + "字母  " + ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                        else if (j >= 80)               //道具
                        {
                            item_btn[i].Name = j.ToString();
                            item_btn[i].Image = ((Form1)this.Owner).item_img[j - 26];
                            /*****load label*****/
                            item_btn[i].Text = ((Form1)(this.Owner)).all_item_name[j - 26] + "  " + ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                    }
                }
            }

            /************load money*************/
            money.Text = "目前擁有金錢：" + ((Form1)(this.Owner)).money.ToString();
        }

        /*****************道具被點擊****************/
        private void item_btn_Click(object sender, EventArgs e)
        {
            int item_id = int.Parse(((Button)sender).Name);
            int click_button_id = ((Form1)(this.Owner)).item_click_flag;
            int pot_state = ((Form1)(this.Owner)).pot[click_button_id];

            if (click_button_id == -1)                                  //不是由花盆觸發
                return;

            if (pot_state == 0)     //可種
            {
                if (item_id >= 2 && item_id <= 27)                      //2~27是種子
                {
                    ((Form1)(this.Owner)).pot[click_button_id] = item_id;
                    ((Form1)(this.Owner)).fresh_pot();

                    ((Form1)(this.Owner)).my_item[item_id]--;           //道具欄數量減少
                    load();                                             //刷新畫面
                    push.Play();                                        //種植聲音
                    this.Close();                                       //有種植自動關閉視窗
                }
            }
            else if (pot_state >= 2 && pot_state <= 53)                  //可用生長激素
            {
                if (item_id == 80)                                      //80是生長激素
                {
                    if (pot_state >= 2 && pot_state <= 27)
                    {
                        ((Form1)(this.Owner)).pot[click_button_id] += 52;
                    }
                    else
                    {
                        ((Form1)(this.Owner)).pot[click_button_id] += 26;
                    }

                    ((Form1)(this.Owner)).my_item[item_id]--;           //道具欄數量減少
                    load();                                             //刷新畫面
                    this.Close();                                       //使用道具自動關閉視窗
                }
            }
        }
    }
}
