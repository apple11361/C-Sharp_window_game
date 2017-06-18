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
    public partial class Form1 : Form
    {
        public Image[] item_img = new Image[1000];          //所有道具圖片
        public string[] all_item_name = new string[100];    //所有道具名稱

        Item item_form = new Item();                        //道具欄視窗
        Store store_form = new Store();                     //商店視窗
        Quest quest_form = new Quest();                     //任務視窗

        /**********main_window***********/
        public int money;                                   //金錢
        public int[] my_item = new int[100];                //擁有道具列表
        int[] pot = new int[12];                            //記錄花盆內容
        Button[] pot_btn = new Button[12];                  //顯示花盆內容

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        public void init()
        {
            int i;

            /**********set form owner*********/
            item_form.Owner = this;
            store_form.Owner = this;
            quest_form.Owner = this;

            /************load pot************/
            for (i=0;i<12;i++)
            {
                pot_btn[i] = new Button();
                pot_btn[i].Height = 70;
                pot_btn[i].Width = 70;
                pot_btn[i].Location = new Point(15 + i / 2 * 140, 340 + i % 2 * 110);
                pot_btn[i].BackColor = Color.Transparent;
                pot_btn[i].FlatStyle = FlatStyle.Popup;
                pot_btn[i].Name = i.ToString();
                pot_btn[i].Click += new EventHandler(pot_btn_Click);
                this.farm_panel.Controls.Add(pot_btn[i]);
            }

            /*********load images**********/
            item_img[0] = Image.FromFile("../../images/item/seed_item.jpg");
            item_img[1] = Image.FromFile("../../images/item/seed_pot.jpg");
            item_img[2] = Image.FromFile("../../images/item/a1.png");
            item_img[3] = Image.FromFile("../../images/item/b1.png");
            item_img[4] = Image.FromFile("../../images/item/c1.png");
            item_img[5] = Image.FromFile("../../images/item/d1.png");
            item_img[6] = Image.FromFile("../../images/item/e1.png");
            item_img[7] = Image.FromFile("../../images/item/f1.png");
            item_img[8] = Image.FromFile("../../images/item/g1.png");
            item_img[9] = Image.FromFile("../../images/item/h1.png");
            item_img[10] = Image.FromFile("../../images/item/i1.png");
            item_img[11] = Image.FromFile("../../images/item/j1.png");
            item_img[12] = Image.FromFile("../../images/item/k1.png");
            item_img[13] = Image.FromFile("../../images/item/l1.png");
            item_img[14] = Image.FromFile("../../images/item/m1.png");
            item_img[15] = Image.FromFile("../../images/item/n1.png");
            item_img[16] = Image.FromFile("../../images/item/o1.png");
            item_img[17] = Image.FromFile("../../images/item/p1.png");
            item_img[18] = Image.FromFile("../../images/item/q1.png");
            item_img[19] = Image.FromFile("../../images/item/r1.png");
            item_img[20] = Image.FromFile("../../images/item/s1.png");
            item_img[21] = Image.FromFile("../../images/item/t1.png");
            item_img[22] = Image.FromFile("../../images/item/u1.png");
            item_img[23] = Image.FromFile("../../images/item/v1.png");
            item_img[24] = Image.FromFile("../../images/item/w1.png");
            item_img[25] = Image.FromFile("../../images/item/x1.png");
            item_img[26] = Image.FromFile("../../images/item/y1.png");
            item_img[27] = Image.FromFile("../../images/item/z1.png");
            item_img[28] = Image.FromFile("../../images/item/a2.png");
            item_img[29] = Image.FromFile("../../images/item/b2.png");
            item_img[30] = Image.FromFile("../../images/item/c2.png");
            item_img[31] = Image.FromFile("../../images/item/d2.png");
            item_img[32] = Image.FromFile("../../images/item/e2.png");
            item_img[33] = Image.FromFile("../../images/item/f2.png");
            item_img[34] = Image.FromFile("../../images/item/g2.png");
            item_img[35] = Image.FromFile("../../images/item/h2.png");
            item_img[36] = Image.FromFile("../../images/item/i2.png");
            item_img[37] = Image.FromFile("../../images/item/j2.png");
            item_img[38] = Image.FromFile("../../images/item/k2.png");
            item_img[39] = Image.FromFile("../../images/item/l2.png");
            item_img[40] = Image.FromFile("../../images/item/m2.png");
            item_img[41] = Image.FromFile("../../images/item/n2.png");
            item_img[42] = Image.FromFile("../../images/item/o2.png");
            item_img[43] = Image.FromFile("../../images/item/p2.png");
            item_img[44] = Image.FromFile("../../images/item/q2.png");
            item_img[45] = Image.FromFile("../../images/item/r2.png");
            item_img[46] = Image.FromFile("../../images/item/s2.png");
            item_img[47] = Image.FromFile("../../images/item/t2.png");
            item_img[48] = Image.FromFile("../../images/item/u2.png");
            item_img[49] = Image.FromFile("../../images/item/v2.png");
            item_img[50] = Image.FromFile("../../images/item/w2.png");
            item_img[51] = Image.FromFile("../../images/item/x2.png");
            item_img[52] = Image.FromFile("../../images/item/y2.png");
            item_img[53] = Image.FromFile("../../images/item/z2.png");

            /*************load item_name*************/
            all_item_name[2] = "A";
            all_item_name[3] = "B";
            all_item_name[4] = "C";
            all_item_name[5] = "D";
            all_item_name[6] = "E";
            all_item_name[7] = "F";
            all_item_name[8] = "G";
            all_item_name[9] = "H";
            all_item_name[10] = "I";
            all_item_name[11] = "J";
            all_item_name[12] = "K";
            all_item_name[13] = "L";
            all_item_name[14] = "M";
            all_item_name[15] = "N";
            all_item_name[16] = "O";
            all_item_name[17] = "P";
            all_item_name[18] = "Q";
            all_item_name[19] = "R";
            all_item_name[20] = "S";
            all_item_name[21] = "T";
            all_item_name[22] = "U";
            all_item_name[23] = "V";
            all_item_name[24] = "W";
            all_item_name[25] = "X";
            all_item_name[26] = "Y";
            all_item_name[27] = "Z";


            /*************load data*************/
            money = 5000;
            my_item[2] = 2;
            my_item[3] = 3;
            my_item[5] = 1;


        }

        /********商店被點擊*********/
        private void Store_Click(object sender, EventArgs e)
        {
            store_form.ShowDialog();
        }

        /********任務被點擊*********/
        private void Quest_Click(object sender, EventArgs e)
        {

        }

        /********道具被點擊*********/
        private void Item_Click(object sender, EventArgs e)
        {
            item_form.ShowDialog();
        }

        /*********花盆被點擊**********/
        private void pot_btn_Click(object sender, EventArgs e)
        {
            if(pot[int.Parse(((Button)sender).Name)] == 0)
            {
                item_form.ShowDialog();
            }
        }

        private void Achievement_Click(object sender, EventArgs e)
        {

        }
    }
}
