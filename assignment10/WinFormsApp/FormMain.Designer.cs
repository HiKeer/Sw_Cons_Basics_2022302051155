using System.Windows.Forms;

namespace WinFormsApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            订单管理系统 = new Label();
            查询方式 = new Label();
            查询订单 = new Button();
            查询comboBox = new ComboBox();
            订单内容DataGridView = new DataGridView();
            OrderidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            createTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BinOrderSrc = new BindingSource(components);
            订单细节DataGridView = new DataGridView();
            IndexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            GoodsNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            QuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            UnitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            BinDetailSrc = new BindingSource(components);
            查询textBox = new TextBox();
            删除订单 = new Button();
            创建订单 = new Button();
            修改订单 = new Button();
            ((System.ComponentModel.ISupportInitialize)订单内容DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinOrderSrc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)订单细节DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinDetailSrc).BeginInit();
            SuspendLayout();
            // 
            // 订单管理系统
            // 
            订单管理系统.AutoSize = true;
            订单管理系统.Font = new Font("Microsoft YaHei UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            订单管理系统.Location = new Point(530, 28);
            订单管理系统.Name = "订单管理系统";
            订单管理系统.Size = new Size(283, 57);
            订单管理系统.TabIndex = 0;
            订单管理系统.Text = "订单管理系统";
            // 
            // 查询方式
            // 
            查询方式.AutoSize = true;
            查询方式.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            查询方式.Location = new Point(59, 172);
            查询方式.Name = "查询方式";
            查询方式.Size = new Size(146, 41);
            查询方式.TabIndex = 1;
            查询方式.Text = "查询方式";
            // 
            // 查询订单
            // 
            查询订单.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            查询订单.Location = new Point(45, 95);
            查询订单.Name = "查询订单";
            查询订单.Size = new Size(182, 64);
            查询订单.TabIndex = 2;
            查询订单.Text = "查询订单";
            查询订单.UseVisualStyleBackColor = true;
            查询订单.Click += 查询订单_Click;
            // 
            // 查询comboBox
            // 
            查询comboBox.FormattingEnabled = true;
            查询comboBox.Items.AddRange(new object[] { "所有订单", "订单号", "客户名", "货物名", "订单总价" });
            查询comboBox.Location = new Point(262, 174);
            查询comboBox.Name = "查询comboBox";
            查询comboBox.Size = new Size(151, 39);
            查询comboBox.TabIndex = 3;
            查询comboBox.Text = "所有订单";
            // 
            // 订单内容DataGridView
            // 
            订单内容DataGridView.AllowUserToAddRows = false;
            订单内容DataGridView.AutoGenerateColumns = false;
            订单内容DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            订单内容DataGridView.Columns.AddRange(new DataGridViewColumn[] { OrderidDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, createTimeDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn });
            订单内容DataGridView.DataSource = BinOrderSrc;
            订单内容DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            订单内容DataGridView.Location = new Point(45, 231);
            订单内容DataGridView.Name = "订单内容DataGridView";
            订单内容DataGridView.RowHeadersWidth = 82;
            订单内容DataGridView.RowTemplate.Height = 40;
            订单内容DataGridView.Size = new Size(626, 541);
            订单内容DataGridView.TabIndex = 4;
            // 
            // OrderidDataGridViewTextBoxColumn
            // 
            OrderidDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            OrderidDataGridViewTextBoxColumn.HeaderText = "订单号";
            OrderidDataGridViewTextBoxColumn.MinimumWidth = 10;
            OrderidDataGridViewTextBoxColumn.Name = "OrderidDataGridViewTextBoxColumn";
            OrderidDataGridViewTextBoxColumn.Width = 200;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerDataGridViewTextBoxColumn.HeaderText = "客户";
            customerDataGridViewTextBoxColumn.MinimumWidth = 10;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.ReadOnly = true;
            customerDataGridViewTextBoxColumn.Width = 200;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            createTimeDataGridViewTextBoxColumn.HeaderText = "创建时间";
            createTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            createTimeDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            totalPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // BinOrderSrc
            // 
            BinOrderSrc.DataSource = typeof(OrderApp.Order);
            // 
            // 订单细节DataGridView
            // 
            订单细节DataGridView.AllowUserToAddRows = false;
            订单细节DataGridView.AutoGenerateColumns = false;
            订单细节DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            订单细节DataGridView.Columns.AddRange(new DataGridViewColumn[] { IndexDataGridViewTextBoxColumn, GoodsNameDataGridViewTextBoxColumn, QuantityDataGridViewTextBoxColumn, UnitPriceDataGridViewTextBoxColumn });
            订单细节DataGridView.DataSource = BinDetailSrc;
            订单细节DataGridView.Location = new Point(713, 231);
            订单细节DataGridView.Name = "订单细节DataGridView";
            订单细节DataGridView.RowHeadersWidth = 82;
            订单细节DataGridView.RowTemplate.Height = 40;
            订单细节DataGridView.Size = new Size(622, 541);
            订单细节DataGridView.TabIndex = 5;
            // 
            // IndexDataGridViewTextBoxColumn
            // 
            IndexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            IndexDataGridViewTextBoxColumn.HeaderText = "明细号";
            IndexDataGridViewTextBoxColumn.MinimumWidth = 10;
            IndexDataGridViewTextBoxColumn.Name = "IndexDataGridViewTextBoxColumn";
            IndexDataGridViewTextBoxColumn.ReadOnly = true;
            IndexDataGridViewTextBoxColumn.Width = 200;
            // 
            // GoodsNameDataGridViewTextBoxColumn
            // 
            GoodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            GoodsNameDataGridViewTextBoxColumn.HeaderText = "货物";
            GoodsNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            GoodsNameDataGridViewTextBoxColumn.Name = "GoodsNameDataGridViewTextBoxColumn";
            GoodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            GoodsNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // QuantityDataGridViewTextBoxColumn
            // 
            QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            QuantityDataGridViewTextBoxColumn.HeaderText = "数量";
            QuantityDataGridViewTextBoxColumn.MinimumWidth = 10;
            QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn";
            QuantityDataGridViewTextBoxColumn.ReadOnly = true;
            QuantityDataGridViewTextBoxColumn.Width = 200;
            // 
            // UnitPriceDataGridViewTextBoxColumn
            // 
            UnitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            UnitPriceDataGridViewTextBoxColumn.HeaderText = "单价";
            UnitPriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            UnitPriceDataGridViewTextBoxColumn.Name = "UnitPriceDataGridViewTextBoxColumn";
            UnitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            UnitPriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // BinDetailSrc
            // 
            BinDetailSrc.DataMember = "Details";
            BinDetailSrc.DataSource = BinOrderSrc;
            // 
            // 查询textBox
            // 
            查询textBox.Location = new Point(473, 174);
            查询textBox.Name = "查询textBox";
            查询textBox.Size = new Size(390, 38);
            查询textBox.TabIndex = 6;
            // 
            // 删除订单
            // 
            删除订单.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            删除订单.Location = new Point(262, 95);
            删除订单.Name = "删除订单";
            删除订单.Size = new Size(186, 64);
            删除订单.TabIndex = 8;
            删除订单.Text = "删除订单";
            删除订单.UseVisualStyleBackColor = true;
            删除订单.Click += 删除订单_Click;
            // 
            // 创建订单
            // 
            创建订单.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            创建订单.Location = new Point(485, 95);
            创建订单.Name = "创建订单";
            创建订单.Size = new Size(186, 64);
            创建订单.TabIndex = 9;
            创建订单.Text = "创建订单";
            创建订单.UseVisualStyleBackColor = true;
            创建订单.Click += 创建订单_Click;
            // 
            // 修改订单
            // 
            修改订单.Font = new Font("Microsoft YaHei UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            修改订单.Location = new Point(713, 95);
            修改订单.Name = "修改订单";
            修改订单.Size = new Size(191, 64);
            修改订单.TabIndex = 11;
            修改订单.Text = "修改订单";
            修改订单.UseVisualStyleBackColor = true;
            修改订单.Click += 修改订单_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 806);
            Controls.Add(修改订单);
            Controls.Add(创建订单);
            Controls.Add(删除订单);
            Controls.Add(查询textBox);
            Controls.Add(订单细节DataGridView);
            Controls.Add(订单内容DataGridView);
            Controls.Add(查询comboBox);
            Controls.Add(查询订单);
            Controls.Add(查询方式);
            Controls.Add(订单管理系统);
            Name = "FormMain";
            Text = "OrderManage";
            ((System.ComponentModel.ISupportInitialize)订单内容DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinOrderSrc).EndInit();
            ((System.ComponentModel.ISupportInitialize)订单细节DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinDetailSrc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label 订单管理系统;
        private Label 查询方式;
        private Button 查询订单;
        private ComboBox 查询comboBox;
        private DataGridView 订单细节DataGridView;
        private BindingSource BinOrder;
        private BindingSource BinOrderSrc;
        private BindingSource BinDetailSrc;
        private TextBox 查询textBox;
        private DataGridViewTextBoxColumn OrderidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn IndexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn GoodsNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn QuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn UnitPriceDataGridViewTextBoxColumn;
        private Button 删除订单;
        private Button 创建订单;
        private Button 修改订单;
        private DataGridView 订单内容DataGridView;
    }
}