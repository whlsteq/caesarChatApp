namespace caesarChatApp
{
    partial class User
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
            this.txt_nickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.rtxt_dataMessage = new System.Windows.Forms.RichTextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nickname
            // 
            this.txt_nickname.Location = new System.Drawing.Point(466, 47);
            this.txt_nickname.Name = "txt_nickname";
            this.txt_nickname.Size = new System.Drawing.Size(144, 27);
            this.txt_nickname.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nickname";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(617, 398);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(94, 29);
            this.btn_send.TabIndex = 17;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(90, 400);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(520, 27);
            this.txt_message.TabIndex = 16;
            // 
            // rtxt_dataMessage
            // 
            this.rtxt_dataMessage.Location = new System.Drawing.Point(90, 96);
            this.rtxt_dataMessage.Name = "rtxt_dataMessage";
            this.rtxt_dataMessage.Size = new System.Drawing.Size(621, 261);
            this.rtxt_dataMessage.TabIndex = 15;
            this.rtxt_dataMessage.Text = "";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(283, 47);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(144, 27);
            this.txt_port.TabIndex = 14;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(90, 47);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(144, 27);
            this.txt_ip.TabIndex = 13;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(617, 45);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(94, 29);
            this.btn_connect.TabIndex = 12;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP";
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_nickname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.rtxt_dataMessage);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nickname;
        private Label label3;
        private Button btn_send;
        private TextBox txt_message;
        private RichTextBox rtxt_dataMessage;
        private TextBox txt_port;
        private TextBox txt_ip;
        private Button btn_connect;
        private Label label2;
        private Label label1;
    }
}