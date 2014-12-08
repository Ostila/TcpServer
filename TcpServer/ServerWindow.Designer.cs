namespace TcpServer
{
    partial class ServerWindow
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
            this.btn_startserver = new System.Windows.Forms.Button();
            this.btn_stopserver = new System.Windows.Forms.Button();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtb_console
            // 
            this.rtb_console.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb_console.Location = new System.Drawing.Point(12, 12);
            this.rtb_console.Name = "rtb_console";
            this.rtb_console.ReadOnly = true;
            this.rtb_console.Size = new System.Drawing.Size(593, 218);
            this.rtb_console.TabIndex = 0;
            this.rtb_console.Text = "";
            // 
            // btn_startserver
            // 
            this.btn_startserver.Location = new System.Drawing.Point(12, 247);
            this.btn_startserver.Name = "btn_startserver";
            this.btn_startserver.Size = new System.Drawing.Size(115, 23);
            this.btn_startserver.TabIndex = 1;
            this.btn_startserver.Text = "Start Server";
            this.btn_startserver.UseVisualStyleBackColor = true;
            this.btn_startserver.Click += new System.EventHandler(this.btn_startserver_Click);
            // 
            // btn_stopserver
            // 
            this.btn_stopserver.Enabled = false;
            this.btn_stopserver.Location = new System.Drawing.Point(12, 276);
            this.btn_stopserver.Name = "btn_stopserver";
            this.btn_stopserver.Size = new System.Drawing.Size(115, 23);
            this.btn_stopserver.TabIndex = 2;
            this.btn_stopserver.Text = "Stop Server";
            this.btn_stopserver.UseVisualStyleBackColor = true;
            this.btn_stopserver.Click += new System.EventHandler(this.btn_stopserver_Click);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(148, 252);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(32, 13);
            this.lbl_port.TabIndex = 3;
            this.lbl_port.Text = "Port :";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(186, 249);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(57, 20);
            this.txt_port.TabIndex = 4;
            this.txt_port.Text = "1024";
            // 
            // ServerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 339);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.btn_stopserver);
            this.Controls.Add(this.btn_startserver);
            this.Controls.Add(this.rtb_console);
            this.Name = "ServerWindow";
            this.Text = "Server Tcp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_console;
        private System.Windows.Forms.Button btn_startserver;
        private System.Windows.Forms.Button btn_stopserver;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_port;
    }
}

