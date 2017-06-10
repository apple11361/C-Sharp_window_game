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
        Item item_form = new Item();
        Store store_form = new Store();
        int[] pot = new int[12];
        Button[] pot_btn = new Button[12]; 

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

            /************load pot************/
            for(i=0;i<12;i++)
            {
                pot_btn[i] = new Button();
                pot_btn[i].Height = 70;
                pot_btn[i].Width = 70;
                pot_btn[i].Location = new Point(15 + i / 2 * 140, 340 + i % 2 * 110);
                pot_btn[i].BackColor = Color.Transparent;
                pot_btn[i].FlatStyle = FlatStyle.Popup;
                pot_btn[i].Name = i.ToString();
                pot_btn[i].Text = pot_btn[i].Name;
                pot_btn[i].Click += new EventHandler(pot_btn_Click);
                this.farm_panel.Controls.Add(pot_btn[i]);
            }

            /**********set form owner*********/
            item_form.Owner = this;
            store_form.Owner = this;
        }

        private void Store_Click(object sender, EventArgs e)
        {

        }

        private void pot_btn_Click(object sender, EventArgs e)
        {
            if(pot[int.Parse(((Button)sender).Name)] == 0)
            {
                item_form.ShowDialog();
            }
        }
    }
}
