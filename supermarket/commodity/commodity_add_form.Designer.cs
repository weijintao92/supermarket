namespace supermarket.commodity
{
    partial class add_form
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.combox_tpye = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_state = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_outPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_inPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(64, 27);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 1;
            // 
            // combox_tpye
            // 
            this.combox_tpye.FormattingEnabled = true;
            this.combox_tpye.Location = new System.Drawing.Point(64, 200);
            this.combox_tpye.Name = "combox_tpye";
            this.combox_tpye.Size = new System.Drawing.Size(121, 20);
            this.combox_tpye.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "类型";
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(64, 68);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(100, 21);
            this.txt_barcode.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "条码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "状态";
            // 
            // combox_state
            // 
            this.combox_state.FormattingEnabled = true;
            this.combox_state.Items.AddRange(new object[] {
            "禁用"});
            this.combox_state.Location = new System.Drawing.Point(64, 249);
            this.combox_state.Name = "combox_state";
            this.combox_state.Size = new System.Drawing.Size(121, 20);
            this.combox_state.TabIndex = 6;
            this.combox_state.Text = "启用";
            this.combox_state.SelectedIndexChanged += new System.EventHandler(this.combox_state_SelectedIndexChanged);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(211, 299);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 8;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_outPrice
            // 
            this.txt_outPrice.Location = new System.Drawing.Point(64, 151);
            this.txt_outPrice.Name = "txt_outPrice";
            this.txt_outPrice.Size = new System.Drawing.Size(100, 21);
            this.txt_outPrice.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "售价";
            // 
            // txt_inPrice
            // 
            this.txt_inPrice.Location = new System.Drawing.Point(64, 110);
            this.txt_inPrice.Name = "txt_inPrice";
            this.txt_inPrice.Size = new System.Drawing.Size(100, 21);
            this.txt_inPrice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "进价";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 334);
            this.Controls.Add(this.txt_outPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_inPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combox_state);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combox_tpye);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Name = "add_form";
            this.Text = "新增商品";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.add_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox combox_tpye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combox_state;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txt_outPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_inPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}