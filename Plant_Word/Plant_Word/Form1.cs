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
        private
        Item item_form = new Item();            //道具欄視窗
        Store store_form = new Store();         //商店視窗

        Image[] item_img = new Image[1000];    //所有道具圖片

        int[] pot = new int[12];                //記錄花盆內容
        Button[] pot_btn = new Button[12];      //顯示花盆內容

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
            

        }

        /********商店被點擊*********/
        private void Store_Click(object sender, EventArgs e)
        {

        }

        /********任務被點擊*********/
        private void Quest_Click(object sender, EventArgs e)
        {

        }

        /********道具被點擊*********/
        private void Item_Click(object sender, EventArgs e)
        {

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
