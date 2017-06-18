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
    public partial class Store : Form
    {
        public
        Panel[] store_panel = new Panel[26];
        Button[] store_btn = new Button[26];
        Label[,] store_label = new Label[26, 2];
        Panel[] item_panel = new Panel[26];
        Label[] item_image = new Label[26];
        Label[,] item_label = new Label[26, 2];
        Label money = new Label();

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

            /**********************************store**********************************/
            /************init panel*************/
            for (i = 0; i < 26; i++)
            {
                store_panel[i] = new Panel();
                store_panel[i].Height = 90;
                store_panel[i].Width = 200;
                store_panel[i].BackColor = SystemColors.AppWorkspace;
                store_panel[i].MouseEnter += flowLayoutPanel1_MouseEnter;
                //store_panel[i].Location = new Point(15 + i / 2 * 140, 340 + i % 2 * 110);
                flowLayoutPanel1.Controls.Add(store_panel[i]);
            }

            /************init button*************/
            for (i = 0; i < 26; i++)
            {
                store_btn[i] = new Button();
                store_btn[i].Height = 70;
                store_btn[i].Width = 70;
                store_btn[i].Location = new Point(9, 9);
                store_btn[i].BackColor = Color.Transparent;
                store_btn[i].FlatStyle = FlatStyle.Popup;
                store_btn[i].Name = i.ToString();
                store_panel[i].Controls.Add(store_btn[i]);
            }

            /************init label*************/
            for (i = 0; i < 26; i++)
            {
                store_label[i, 0] = new Label();
                store_label[i, 1] = new Label();

                store_label[i, 0].Height = 15;
                store_label[i, 0].Width = 100;
                store_label[i, 0].Location = new Point(90, 25);
                store_label[i, 0].Text = "字母" + Convert.ToChar(i + 65) + "的種子";
                store_panel[i].Controls.Add(store_label[i, 0]);

                store_label[i, 1].Height = 15;
                store_label[i, 1].Width = 100;
                store_label[i, 1].Location = new Point(90, 50);
                store_label[i, 1].Text = "200元";
                store_panel[i].Controls.Add(store_label[i, 1]);
            }

            /**********************************item***********************************/
            /************init panel*************/
            for (i = 0; i < 26; i++)
            {
                item_panel[i] = new Panel();
                item_panel[i].Height = 90;
                item_panel[i].Width = 200;
                item_panel[i].BackColor = SystemColors.AppWorkspace;
                item_panel[i].MouseEnter += flowLayoutPanel2_MouseEnter;
                //item_panel[i].Location = new Point(15 + i / 2 * 140, 340 + i % 2 * 110);
                flowLayoutPanel2.Controls.Add(item_panel[i]);
            }

            /************init image*************/
            for (i = 0; i < 26; i++)
            {
                item_image[i] = new Label();
                item_image[i].Height = 70;
                item_image[i].Width = 70;
                item_image[i].Location = new Point(9, 9);
                item_image[i].BackColor = Color.Transparent;
                item_image[i].FlatStyle = FlatStyle.Popup;
                item_image[i].Name = i.ToString();
                //store_btn[i].Click += new EventHandler(store_btn_Click);
                item_panel[i].Controls.Add(item_image[i]);
            }

            /************init label*************/
            for (i = 0; i < 26; i++)
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
            int i;

            /**********************************store**********************************/
            /************load button*************/
            for (i = 0; i < 26; i++)
            {
                store_btn[i].Image = ((Form1)this.Owner).item_img[0];
                //store_btn[i].Click += new EventHandler(store_btn_Click);
            }

            /**********************************item***********************************/
            /************load image*************/
            for (i = 0; i < 26; i++)
            {
                item_image[i].Image = ((Form1)this.Owner).item_img[0];
                //store_btn[i].Click += new EventHandler(store_btn_Click);
            }

            /************load label*************/
            for (i = 0; i < 26; i++)
            {
                item_label[i, 0].Text = "道具名稱";

                item_label[i, 1].Text = "數量";
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
    }
}
