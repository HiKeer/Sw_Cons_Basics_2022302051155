namespace WinFormsApp
{
    partial class FormAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BinCustomerSrc = new BindingSource(components);
            订单号 = new Label();
            BinOrderSrc = new BindingSource(components);
            BinDetailSrc = new BindingSource(components);
            客户名 = new Label();
            创建订单 = new Button();
            添加明细 = new Button();
            明细号 = new Label();
            货物号 = new Label();
            货物名 = new Label();
            单价 = new Label();
            数量 = new Label();
            客户号 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            修改订单 = new Button();
            ((System.ComponentModel.ISupportInitialize)BinCustomerSrc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinOrderSrc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinDetailSrc).BeginInit();
            SuspendLayout();
            // 
            // BinCustomerSrc
            // 
            BinCustomerSrc.DataSource = typeof(OrderApp.Customer);
            // 
            // 订单号
            // 
            订单号.AutoSize = true;
            订单号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            订单号.Location = new Point(56, 138);
            订单号.Name = "订单号";
            订单号.Size = new Size(114, 41);
            订单号.TabIndex = 1;
            订单号.Text = "订单号";
            // 
            // BinOrderSrc
            // 
            BinOrderSrc.DataSource = typeof(OrderApp.Order);
            // 
            // BinDetailSrc
            // 
            BinDetailSrc.DataMember = "Details";
            BinDetailSrc.DataSource = BinOrderSrc;
            // 
            // 客户名
            // 
            客户名.AutoSize = true;
            客户名.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            客户名.Location = new Point(56, 306);
            客户名.Name = "客户名";
            客户名.Size = new Size(114, 41);
            客户名.TabIndex = 5;
            客户名.Text = "客户名";
            // 
            // 创建订单
            // 
            创建订单.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            创建订单.Location = new Point(56, 51);
            创建订单.Name = "创建订单";
            创建订单.Size = new Size(186, 60);
            创建订单.TabIndex = 7;
            创建订单.Text = "创建订单";
            创建订单.UseVisualStyleBackColor = true;
            创建订单.Click += 创建订单_Click;
            // 
            // 添加明细
            // 
            添加明细.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            添加明细.Location = new Point(56, 380);
            添加明细.Name = "添加明细";
            添加明细.Size = new Size(188, 60);
            添加明细.TabIndex = 8;
            添加明细.Text = "添加明细";
            添加明细.UseVisualStyleBackColor = true;
            添加明细.Click += 添加明细_Click;
            // 
            // 明细号
            // 
            明细号.AutoSize = true;
            明细号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            明细号.Location = new Point(56, 474);
            明细号.Name = "明细号";
            明细号.Size = new Size(114, 41);
            明细号.TabIndex = 9;
            明细号.Text = "明细号";
            // 
            // 货物号
            // 
            货物号.AutoSize = true;
            货物号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            货物号.Location = new Point(54, 555);
            货物号.Name = "货物号";
            货物号.Size = new Size(114, 41);
            货物号.TabIndex = 11;
            货物号.Text = "货物号";
            // 
            // 货物名
            // 
            货物名.AutoSize = true;
            货物名.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            货物名.Location = new Point(56, 639);
            货物名.Name = "货物名";
            货物名.Size = new Size(114, 41);
            货物名.TabIndex = 13;
            货物名.Text = "货物名";
            // 
            // 单价
            // 
            单价.AutoSize = true;
            单价.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            单价.Location = new Point(69, 723);
            单价.Name = "单价";
            单价.Size = new Size(82, 41);
            单价.TabIndex = 15;
            单价.Text = "单价";
            // 
            // 数量
            // 
            数量.AutoSize = true;
            数量.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            数量.Location = new Point(69, 800);
            数量.Name = "数量";
            数量.Size = new Size(82, 41);
            数量.TabIndex = 17;
            数量.Text = "数量";
            // 
            // 客户号
            // 
            客户号.AutoSize = true;
            客户号.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            客户号.Location = new Point(54, 223);
            客户号.Name = "客户号";
            客户号.Size = new Size(114, 41);
            客户号.TabIndex = 19;
            客户号.Text = "客户号";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 138);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 38);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 38);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 309);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 38);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(225, 474);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(283, 38);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(225, 558);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(283, 38);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(225, 639);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(283, 38);
            textBox6.TabIndex = 25;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(225, 723);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(283, 38);
            textBox7.TabIndex = 26;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(225, 800);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(283, 38);
            textBox8.TabIndex = 27;
            // 
            // 修改订单
            // 
            修改订单.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            修改订单.Location = new Point(277, 51);
            修改订单.Name = "修改订单";
            修改订单.Size = new Size(185, 60);
            修改订单.TabIndex = 28;
            修改订单.Text = "修改订单";
            修改订单.UseVisualStyleBackColor = true;
            修改订单.Click += 修改订单_Click;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 902);
            Controls.Add(修改订单);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(客户号);
            Controls.Add(数量);
            Controls.Add(单价);
            Controls.Add(货物名);
            Controls.Add(货物号);
            Controls.Add(明细号);
            Controls.Add(添加明细);
            Controls.Add(创建订单);
            Controls.Add(客户名);
            Controls.Add(订单号);
            Name = "FormAdd";
            Text = "FormAdd";
            ((System.ComponentModel.ISupportInitialize)BinCustomerSrc).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinOrderSrc).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinDetailSrc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource BinCustomerSrc;
        private Label 订单号;
        private BindingSource BinOrderSrc;
        private BindingSource BinDetailSrc;
        private Label 客户名;
        private Button 创建订单;
        private Button 添加明细;
        private Label 明细号;
        private Label 货物号;
        private Label 货物名;
        private Label 单价;
        private Label 数量;
        private Label 客户号;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Button 修改订单;
    }
}