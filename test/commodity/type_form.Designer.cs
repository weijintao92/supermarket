namespace test.commodity
{
    partial class type_form
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.type_view = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.strip_update = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_isable = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.type_view)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(122, 54);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(100, 21);
            this.txt_type.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(169, 96);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // type_view
            // 
            this.type_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.type_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.type_view.ContextMenuStrip = this.contextMenuStrip1;
            this.type_view.Location = new System.Drawing.Point(4, 134);
            this.type_view.Name = "type_view";
            this.type_view.RowTemplate.Height = 23;
            this.type_view.Size = new System.Drawing.Size(270, 150);
            this.type_view.TabIndex = 3;
            this.type_view.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.type_view_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_update,
            this.strip_isable});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // strip_update
            // 
            this.strip_update.Name = "strip_update";
            this.strip_update.Size = new System.Drawing.Size(100, 22);
            this.strip_update.Text = "修改";
            // 
            // strip_isable
            // 
            this.strip_isable.Name = "strip_isable";
            this.strip_isable.Size = new System.Drawing.Size(100, 22);
            this.strip_isable.Text = "禁用";
            this.strip_isable.Click += new System.EventHandler(this.strip_isable_Click);
            // 
            // type_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 356);
            this.Controls.Add(this.type_view);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label1);
            this.Name = "type_form";
            this.Text = "商品类型";
            this.Load += new System.EventHandler(this.type_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.type_view)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView type_view;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem strip_update;
        private System.Windows.Forms.ToolStripMenuItem strip_isable;
    }
}