namespace Plant_Word
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Store = new System.Windows.Forms.Button();
            this.Quest = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.Button();
            this.Achievement = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.farm_panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Store
            // 
            this.Store.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Store.Location = new System.Drawing.Point(45, 3);
            this.Store.Margin = new System.Windows.Forms.Padding(45, 3, 45, 3);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(120, 35);
            this.Store.TabIndex = 1;
            this.Store.Text = "商店";
            this.Store.UseVisualStyleBackColor = true;
            this.Store.Click += new System.EventHandler(this.Store_Click);
            // 
            // Quest
            // 
            this.Quest.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Quest.Location = new System.Drawing.Point(255, 3);
            this.Quest.Margin = new System.Windows.Forms.Padding(45, 3, 45, 3);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(120, 35);
            this.Quest.TabIndex = 2;
            this.Quest.Text = "任務";
            this.Quest.UseVisualStyleBackColor = true;
            this.Quest.Click += new System.EventHandler(this.Quest_Click);
            // 
            // Item
            // 
            this.Item.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Item.Location = new System.Drawing.Point(465, 3);
            this.Item.Margin = new System.Windows.Forms.Padding(45, 3, 45, 3);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(120, 35);
            this.Item.TabIndex = 3;
            this.Item.Text = "道具";
            this.Item.UseVisualStyleBackColor = true;
            this.Item.Click += new System.EventHandler(this.Item_Click);
            // 
            // Achievement
            // 
            this.Achievement.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Achievement.Location = new System.Drawing.Point(675, 3);
            this.Achievement.Margin = new System.Windows.Forms.Padding(45, 3, 45, 3);
            this.Achievement.Name = "Achievement";
            this.Achievement.Size = new System.Drawing.Size(120, 35);
            this.Achievement.TabIndex = 4;
            this.Achievement.Text = "成就";
            this.Achievement.UseVisualStyleBackColor = true;
            this.Achievement.Click += new System.EventHandler(this.Achievement_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.Store);
            this.flowLayoutPanel2.Controls.Add(this.Quest);
            this.flowLayoutPanel2.Controls.Add(this.Item);
            this.flowLayoutPanel2.Controls.Add(this.Achievement);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(75, 20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(840, 44);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // farm_panel
            // 
            this.farm_panel.BackColor = System.Drawing.Color.Transparent;
            this.farm_panel.Location = new System.Drawing.Point(100, 160);
            this.farm_panel.Name = "farm_panel";
            this.farm_panel.Size = new System.Drawing.Size(800, 550);
            this.farm_panel.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Plant_Word.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.farm_panel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "菜英文";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Store;
        private System.Windows.Forms.Button Quest;
        private System.Windows.Forms.Button Item;
        private System.Windows.Forms.Button Achievement;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel farm_panel;
        private System.Windows.Forms.Timer timer1;
    }
}

