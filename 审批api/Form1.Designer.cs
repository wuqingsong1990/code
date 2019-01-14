namespace 审批api
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Faqi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Faqi
            // 
            this.btn_Faqi.Location = new System.Drawing.Point(103, 75);
            this.btn_Faqi.Name = "btn_Faqi";
            this.btn_Faqi.Size = new System.Drawing.Size(75, 23);
            this.btn_Faqi.TabIndex = 0;
            this.btn_Faqi.Text = "发起";
            this.btn_Faqi.UseVisualStyleBackColor = true;
            this.btn_Faqi.Click += new System.EventHandler(this.btn_Faqi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 388);
            this.Controls.Add(this.btn_Faqi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Faqi;
    }
}

