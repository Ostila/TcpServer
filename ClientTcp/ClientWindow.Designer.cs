namespace ClientTcp
{
    partial class ClientWindow
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
            this.rtb_console = new System.Windows.Forms.RichTextBox();
            this.lbl_server = new System.Windows.Forms.Label();
            this.txt_serverip = new System.Windows.Forms.TextBox();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_serverport = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lbl_sendmessage = new System.Windows.Forms.Label();
            this.rtb_sendmessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_sendmessage = new System.Windows.Forms.Button();
            this.btn_deconnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_console
            // 
            this.rtb_console.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_console.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_console.Location = new System.Drawing.Point(13, 13);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(600, 191);
            this.rtb_console.TabIndex = 0;
            this.rtb_console.Text = "";
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(6, 26);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(47, 13);
            this.lbl_server.TabIndex = 1;
            this.lbl_server.Text = "Server : ";
            // 
            // txt_serverip
            // 
            this.txt_serverip.Location = new System.Drawing.Point(54, 23);
            this.txt_serverip.Name = "txt_serverip";
            this.txt_serverip.Size = new System.Drawing.Size(159, 20);
            this.txt_serverip.TabIndex = 2;
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(6, 57);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 13);
            this.lbl_port.TabIndex = 3;
            this.lbl_port.Text = "Port : ";
            // 
            // txt_serverport
            // 
            this.txt_serverport.Location = new System.Drawing.Point(54, 57);
            this.txt_serverport.Name = "txt_serverport";
            this.txt_serverport.Size = new System.Drawing.Size(82, 20);
            this.txt_serverport.TabIndex = 4;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(9, 112);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(84, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connection_Click);
            // 
            // lbl_sendmessage
            // 
            this.lbl_sendmessage.AutoSize = true;
            this.lbl_sendmessage.Location = new System.Drawing.Point(251, 219);
            this.lbl_sendmessage.Name = "lbl_sendmessage";
            this.lbl_sendmessage.Size = new System.Drawing.Size(86, 13);
            this.lbl_sendmessage.TabIndex = 6;
            this.lbl_sendmessage.Text = "Send message : ";
            // 
            // rtb_sendmessage
            // 
            this.rtb_sendmessage.Location = new System.Drawing.Point(343, 219);
            this.rtb_sendmessage.Name = "rtb_sendmessage";
            this.rtb_sendmessage.Size = new System.Drawing.Size(270, 100);
            this.rtb_sendmessage.TabIndex = 7;
            this.rtb_sendmessage.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_deconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.lbl_port);
            this.groupBox1.Controls.Add(this.txt_serverip);
            this.groupBox1.Controls.Add(this.txt_serverport);
            this.groupBox1.Controls.Add(this.lbl_server);
            this.groupBox1.Location = new System.Drawing.Point(12, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 141);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // txt_sendmessage
            // 
            this.txt_sendmessage.Enabled = false;
            this.txt_sendmessage.Location = new System.Drawing.Point(538, 328);
            this.txt_sendmessage.Name = "txt_sendmessage";
            this.txt_sendmessage.Size = new System.Drawing.Size(75, 23);
            this.txt_sendmessage.TabIndex = 9;
            this.txt_sendmessage.Text = "Send";
            this.txt_sendmessage.UseVisualStyleBackColor = true;
            this.txt_sendmessage.Click += new System.EventHandler(this.txt_sendmessage_Click);
            // 
            // btn_deconnect
            // 
            this.btn_deconnect.Enabled = false;
            this.btn_deconnect.Location = new System.Drawing.Point(129, 112);
            this.btn_deconnect.Name = "btn_deconnect";
            this.btn_deconnect.Size = new System.Drawing.Size(84, 23);
            this.btn_deconnect.TabIndex = 6;
            this.btn_deconnect.Text = "Deconnect";
            this.btn_deconnect.UseVisualStyleBackColor = true;
            this.btn_deconnect.Click += new System.EventHandler(this.btn_deconnect_Click);
            // 
            // ClientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 363);
            this.Controls.Add(this.txt_sendmessage);
            this.Controls.Add(this.rtb_sendmessage);
            this.Controls.Add(this.lbl_sendmessage);
            this.Controls.Add(this.rtb_console);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientWindow";
            this.Text = "Client Tcp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Label lbl_server;
        private System.Windows.Forms.TextBox txt_serverip;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_serverport;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lbl_sendmessage;
        private System.Windows.Forms.RichTextBox rtb_sendmessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_sendmessage;
        private System.Windows.Forms.Button btn_deconnect;
    }
}

