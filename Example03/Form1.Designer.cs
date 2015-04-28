namespace Example03
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputMonthLabel = new System.Windows.Forms.Label();
            this.monthTextBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputMonthLabel
            // 
            this.inputMonthLabel.AutoSize = true;
            this.inputMonthLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputMonthLabel.Location = new System.Drawing.Point(13, 36);
            this.inputMonthLabel.Name = "inputMonthLabel";
            this.inputMonthLabel.Size = new System.Drawing.Size(152, 16);
            this.inputMonthLabel.TabIndex = 0;
            this.inputMonthLabel.Text = "Please input month";
            // 
            // monthTextBox
            // 
            this.monthTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthTextBox.Location = new System.Drawing.Point(171, 35);
            this.monthTextBox.Name = "monthTextBox";
            this.monthTextBox.Size = new System.Drawing.Size(100, 22);
            this.monthTextBox.TabIndex = 1;
            this.monthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.monthTextBox_KeyPress);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(84, 104);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(149, 28);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 262);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.monthTextBox);
            this.Controls.Add(this.inputMonthLabel);
            this.Name = "Form1";
            this.Text = "月份季節轉換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inputMonthLabel;
        private System.Windows.Forms.TextBox monthTextBox;
        private System.Windows.Forms.Button okButton;
    }
}

