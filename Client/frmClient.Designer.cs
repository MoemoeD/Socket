namespace Client
{
    partial class frmClient
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(500, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 30);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(650, 42);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 30);
            this.btnDisconnect.TabIndex = 1;
            this.btnDisconnect.Text = "断开连接";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(750, 325);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 200);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(87, 47);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(200, 25);
            this.txtIP.TabIndex = 3;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(353, 47);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 4;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(50, 50);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(31, 15);
            this.lblIP.TabIndex = 5;
            this.lblIP.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(300, 50);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(47, 15);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(50, 100);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(800, 200);
            this.txtMessage.TabIndex = 7;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(50, 325);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(675, 200);
            this.txtSend.TabIndex = 8;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "frmClient";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSend;
    }
}

