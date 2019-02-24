namespace EducationApp
{
    partial class MasterControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MasterGridView = new System.Windows.Forms.DataGridView();
            this.SwitchBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.ItemNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNameKanatxt = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DisplayBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterGridView
            // 
            this.MasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MasterGridView.Location = new System.Drawing.Point(43, 104);
            this.MasterGridView.Name = "MasterGridView";
            this.MasterGridView.RowTemplate.Height = 27;
            this.MasterGridView.Size = new System.Drawing.Size(1400, 600);
            this.MasterGridView.TabIndex = 0;
            // 
            // SwitchBtn
            // 
            this.SwitchBtn.Location = new System.Drawing.Point(1306, 20);
            this.SwitchBtn.Name = "SwitchBtn";
            this.SwitchBtn.Size = new System.Drawing.Size(174, 63);
            this.SwitchBtn.TabIndex = 1;
            this.SwitchBtn.Text = "切り替えボタン";
            this.SwitchBtn.UseVisualStyleBackColor = true;
            this.SwitchBtn.Click += new System.EventHandler(this.SwitchBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(880, 729);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(120, 49);
            this.RegisterBtn.TabIndex = 2;
            this.RegisterBtn.Text = "新規";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1023, 729);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(120, 49);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "削除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1161, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "中止/再開";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(1341, 729);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(120, 49);
            this.ConfirmBtn.TabIndex = 5;
            this.ConfirmBtn.Text = "確定";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "マスタ管理画面";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Location = new System.Drawing.Point(40, 30);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(62, 18);
            this.ItemName.TabIndex = 7;
            this.ItemName.Text = "商品名";
            // 
            // ItemNametxt
            // 
            this.ItemNametxt.Location = new System.Drawing.Point(108, 27);
            this.ItemNametxt.Multiline = true;
            this.ItemNametxt.Name = "ItemNametxt";
            this.ItemNametxt.Size = new System.Drawing.Size(341, 40);
            this.ItemNametxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "商品名カナ";
            // 
            // ItemNameKanatxt
            // 
            this.ItemNameKanatxt.Location = new System.Drawing.Point(584, 30);
            this.ItemNameKanatxt.Multiline = true;
            this.ItemNameKanatxt.Name = "ItemNameKanatxt";
            this.ItemNameKanatxt.Size = new System.Drawing.Size(341, 40);
            this.ItemNameKanatxt.TabIndex = 10;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(952, 27);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 18);
            this.Price.TabIndex = 11;
            this.Price.Text = "単価";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1002, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 40);
            this.textBox1.TabIndex = 12;
            // 
            // DisplayBtn
            // 
            this.DisplayBtn.Location = new System.Drawing.Point(678, 729);
            this.DisplayBtn.Name = "DisplayBtn";
            this.DisplayBtn.Size = new System.Drawing.Size(120, 49);
            this.DisplayBtn.TabIndex = 13;
            this.DisplayBtn.Text = "表示";
            this.DisplayBtn.UseVisualStyleBackColor = true;
            this.DisplayBtn.Click += new System.EventHandler(this.DisplayBtn_Click);
            // 
            // MasterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DisplayBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.ItemNameKanatxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemNametxt);
            this.Controls.Add(this.ItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.SwitchBtn);
            this.Controls.Add(this.MasterGridView);
            this.Name = "MasterControl";
            this.Size = new System.Drawing.Size(1500, 800);
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MasterGridView;
        private System.Windows.Forms.Button SwitchBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.TextBox ItemNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNameKanatxt;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DisplayBtn;
    }
}
