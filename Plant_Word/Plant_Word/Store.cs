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
        
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            init();
        }

        void init()
        {
            int i;

            /************load panel*************/
            for(i = 0; i < 26; i++)
            {
                store_panel[i] = new Panel();
                store_panel[i].Height = 90;
                store_panel[i].Width = 200;
                store_panel[i].BackColor = SystemColors.AppWorkspace;
                store_panel[i].Location = new Point(15 + i / 2 * 140, 340 + i % 2 * 110);
                flowLayoutPanel1.Controls.Add(store_panel[i]);
            }

            /************load button*************/
            for (i = 0; i < 26; i++)
            {
                store_btn[i] = new Button();
                store_btn[i].Height = 80;
                store_btn[i].Width = 80;
                store_btn[i].Location = new Point(4, 4);
                store_btn[i].BackColor = Color.Transparent;
                store_btn[i].FlatStyle = FlatStyle.Popup;
                store_btn[i].Name = i.ToString();
                //store_btn[i].Click += new EventHandler(pot_btn_Click);
                store_panel[i].Controls.Add(store_btn[i]);
            }

            /************load label*************/
            for (i = 0; i < 26; i++)
            {
                store_label[i, 0] = new Label();
                store_label[i, 1] = new Label();

                store_label[i, 0].Height = 15;
                store_label[i, 0].Width = 100;
                store_label[i, 0].Location = new Point(90, 25);
                store_label[i, 0].Text = "道具名稱：";
                store_panel[i].Controls.Add(store_label[i, 0]);

                store_label[i, 1].Height = 15;
                store_label[i, 1].Width = 100;
                store_label[i, 1].Location = new Point(90, 50);
                store_label[i, 1].Text = "金額";
                store_panel[i].Controls.Add(store_label[i, 1]);
            }
        }
    }
}
