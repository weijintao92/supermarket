namespace supermarket
{
    partial class home_form
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
            this.btn_commodity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_condition = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_commodity
            // 
            this.btn_commodity.Location = new System.Drawing.Point(632, 12);
            this.btn_commodity.Name = "btn_commodity";
            this.btn_commodity.Size = new System.Drawing.Size(156, 23);
            this.btn_commodity.TabIndex = 0;
            this.btn_commodity.Text = "商品基础资料管理";
            this.btn_commodity.UseVisualStyleBackColor = true;
            this.btn_commodity.Click += new System.EventHandler(this.btn_commodity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "合计：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_condition
            // 
            this.txt_condition.BackColor = System.Drawing.SystemColors.Window;
            this.txt_condition.Location = new System.Drawing.Point(155, 29);
            this.txt_condition.Name = "txt_condition";
            this.txt_condition.Size = new System.Drawing.Size(168, 21);
            this.txt_condition.TabIndex = 2;
            this.txt_condition.TextChanged += new System.EventHandler(this.txt_condition_TextChanged);
            this.txt_condition.Enter += new System.EventHandler(this.txt_condition_Enter);
            this.txt_condition.Leave += new System.EventHandler(this.txt_condition_Leave);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(90, 101);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(500, 147);
            this.dataGridView.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(657, 322);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "结账";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(350, 29);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_total.Location = new System.Drawing.Point(527, 322);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(100, 21);
            this.txt_total.TabIndex = 5;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(657, 119);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.txt_condition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_commodity);
            this.Name = "home_form";
            this.Text = "首页";
            this.Load += new System.EventHandler(this.home_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_commodity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_condition;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_delete;
    }
}