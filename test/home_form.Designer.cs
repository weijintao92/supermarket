namespace test
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
            // home_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_commodity);
            this.Name = "home_form";
            this.Text = "首页";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_commodity;
    }
}