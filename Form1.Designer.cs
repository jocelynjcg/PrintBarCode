namespace PrintBarCode
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsPrint = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.wHNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wHManDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.var4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wH = new PrintBarCode.WH();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wH)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.IsPrint,
            this.wHNoDataGridViewTextBoxColumn,
            this.wHNameDataGridViewTextBoxColumn,
            this.wHManDataGridViewTextBoxColumn,
            this.sidDataGridViewTextBoxColumn,
            this.var1DataGridViewTextBoxColumn,
            this.var2DataGridViewTextBoxColumn,
            this.var3DataGridViewTextBoxColumn,
            this.var4DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.whBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 63);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 480);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtMan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 55);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "库位信息";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(447, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "打印";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(285, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(366, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "导入";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(204, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtMan
            // 
            this.txtMan.Location = new System.Drawing.Point(570, 25);
            this.txtMan.Name = "txtMan";
            this.txtMan.Size = new System.Drawing.Size(124, 21);
            this.txtMan.TabIndex = 5;
            this.txtMan.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "库位管理员：";
            this.label3.Visible = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(262, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(225, 21);
            this.txtName.TabIndex = 3;
            this.txtName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "库位名称：";
            this.label2.Visible = false;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(70, 25);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(124, 21);
            this.txtNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "库位编号：";
            // 
            // check
            // 
            this.check.HeaderText = "选中";
            this.check.Name = "check";
            // 
            // IsPrint
            // 
            this.IsPrint.DataPropertyName = "IsPrint";
            this.IsPrint.HeaderText = "IsPrint";
            this.IsPrint.Name = "IsPrint";
            this.IsPrint.ReadOnly = true;
            this.IsPrint.Visible = false;
            // 
            // wHNoDataGridViewTextBoxColumn
            // 
            this.wHNoDataGridViewTextBoxColumn.DataPropertyName = "WH_No";
            this.wHNoDataGridViewTextBoxColumn.HeaderText = "WH_No";
            this.wHNoDataGridViewTextBoxColumn.Name = "wHNoDataGridViewTextBoxColumn";
            // 
            // wHNameDataGridViewTextBoxColumn
            // 
            this.wHNameDataGridViewTextBoxColumn.DataPropertyName = "WH_Name";
            this.wHNameDataGridViewTextBoxColumn.HeaderText = "WH_Name";
            this.wHNameDataGridViewTextBoxColumn.Name = "wHNameDataGridViewTextBoxColumn";
            // 
            // wHManDataGridViewTextBoxColumn
            // 
            this.wHManDataGridViewTextBoxColumn.DataPropertyName = "WH_Man";
            this.wHManDataGridViewTextBoxColumn.HeaderText = "WH_Man";
            this.wHManDataGridViewTextBoxColumn.Name = "wHManDataGridViewTextBoxColumn";
            // 
            // sidDataGridViewTextBoxColumn
            // 
            this.sidDataGridViewTextBoxColumn.DataPropertyName = "Sid";
            this.sidDataGridViewTextBoxColumn.HeaderText = "Sid";
            this.sidDataGridViewTextBoxColumn.Name = "sidDataGridViewTextBoxColumn";
            this.sidDataGridViewTextBoxColumn.Visible = false;
            // 
            // var1DataGridViewTextBoxColumn
            // 
            this.var1DataGridViewTextBoxColumn.DataPropertyName = "Var1";
            this.var1DataGridViewTextBoxColumn.HeaderText = "Var1";
            this.var1DataGridViewTextBoxColumn.Name = "var1DataGridViewTextBoxColumn";
            this.var1DataGridViewTextBoxColumn.Visible = false;
            // 
            // var2DataGridViewTextBoxColumn
            // 
            this.var2DataGridViewTextBoxColumn.DataPropertyName = "Var2";
            this.var2DataGridViewTextBoxColumn.HeaderText = "Var2";
            this.var2DataGridViewTextBoxColumn.Name = "var2DataGridViewTextBoxColumn";
            this.var2DataGridViewTextBoxColumn.Visible = false;
            // 
            // var3DataGridViewTextBoxColumn
            // 
            this.var3DataGridViewTextBoxColumn.DataPropertyName = "Var3";
            this.var3DataGridViewTextBoxColumn.HeaderText = "Var3";
            this.var3DataGridViewTextBoxColumn.Name = "var3DataGridViewTextBoxColumn";
            this.var3DataGridViewTextBoxColumn.Visible = false;
            // 
            // var4DataGridViewTextBoxColumn
            // 
            this.var4DataGridViewTextBoxColumn.DataPropertyName = "Var4";
            this.var4DataGridViewTextBoxColumn.HeaderText = "Var4";
            this.var4DataGridViewTextBoxColumn.Name = "var4DataGridViewTextBoxColumn";
            this.var4DataGridViewTextBoxColumn.Visible = false;
            // 
            // whBindingSource
            // 
            this.whBindingSource.DataMember = "Wh";
            this.whBindingSource.DataSource = this.wH;
            // 
            // wH
            // 
            this.wH.DataSetName = "WH";
            this.wH.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "条码打印";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.whBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtMan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource whBindingSource;
        private WH wH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wHManDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn var1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn var2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn var3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn var4DataGridViewTextBoxColumn;
    }
}

