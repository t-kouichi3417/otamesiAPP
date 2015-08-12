namespace otamesiApp_0805
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTest = new System.Windows.Forms.Label();
            this.buttonTest = new System.Windows.Forms.Button();
            this.txtBoxTest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTest
            // 
            this.labelTest.Location = new System.Drawing.Point(10, 53);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(236, 20);
            this.labelTest.TabIndex = 0;
            this.labelTest.Text = "ここに表示されますよ？";
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(296, 12);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(95, 29);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "表示";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // txtBoxTest
            // 
            this.txtBoxTest.Location = new System.Drawing.Point(12, 12);
            this.txtBoxTest.Name = "txtBoxTest";
            this.txtBoxTest.Size = new System.Drawing.Size(256, 19);
            this.txtBoxTest.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 390);
            this.Controls.Add(this.txtBoxTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.labelTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox txtBoxTest;
    }
}

