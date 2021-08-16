
namespace SendDataToAnotherForm
{
    partial class Form1
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
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(387, 196);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(75, 23);
            this.btnSend1.TabIndex = 0;
            this.btnSend1.Text = "Send 1";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(468, 196);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(75, 23);
            this.btnSend2.TabIndex = 1;
            this.btnSend2.Text = "Send 2";
            this.btnSend2.UseVisualStyleBackColor = true;
            //this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(101, 30);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(442, 160);
            this.txtValue.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 237);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.btnSend1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.TextBox txtValue;
    }
}

