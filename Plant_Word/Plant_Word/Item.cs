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
        int item_num = 36; //item 總數


        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            init();
        }

        void init()
        {

            //
            for (int i = 0; i < item_num; i++)
            {
                item_btn[i] = new Button();
                item_btn[i].Height = 70;
                item_btn[i].Width = 70;
            //    item_btn[i].Location = new Point(15 + i / 2 * 140, 340 + i % 2 * 110);
                item_btn[i].BackColor = Color.Transparent;
                item_btn[i].FlatStyle = FlatStyle.Popup;
            //    item_btn[i].BackgroundImage = "";             //image
                item_btn[i].Text = (i+1).ToString();                //item  amount
                item_btn[i].TextAlign = ContentAlignment.BottomRight;
            //    item_btn[i].Name = i.ToString();
            //    item_btn[i].Click += new EventHandler(pot_btn_Click);
                this.flowLayoutPanel1.Controls.Add(item_btn[i]);
            }

        }


    }
}
