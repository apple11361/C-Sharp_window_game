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
    public partial class Item : Form
    {
        public
        int[] item = new int[36];
        Button[] item_btn = new Button[36];
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

            /****************init button*****************/
            for (i = 0; i < item_num; i++)
            {
                item_btn[i] = new Button();
                item_btn[i].Height = 70;
                item_btn[i].Width = 70;
                item_btn[i].BackColor = Color.Transparent;
                item_btn[i].FlatStyle = FlatStyle.Popup;
                item_btn[i].TextAlign = ContentAlignment.BottomLeft;
                //item_btn[i].Click += new EventHandler(pot_btn_Click);
                this.flowLayoutPanel1.Controls.Add(item_btn[i]);
            }
        }

        void load()
        {
            int i, j;

            /****************load my_item***************/
            for (i = 0, j = 0; i < item_num; i++)
            {
                for (; j < 100; j++)
                {
                    if (((Form1)(this.Owner)).my_item[j] != 0)
                    {
                        if (j >= 2 && j <= 27)
                        {
                            item_btn[i].Image = ((Form1)this.Owner).item_img[0];
                            item_btn[i].Text = ((Form1)(this.Owner)).all_item_name[j] + "種子  " + ((Form1)(this.Owner)).my_item[j].ToString() + "個";
                            j++;
                            break;
                        }
                    }
                }
            }
        }
    }
}
