namespace WCFClientApplication
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.domainLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.usrTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.domainTxt = new System.Windows.Forms.TextBox();
            this.tipLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GetReply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 94);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(406, 49);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "WCF Service Reply:";
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Location = new System.Drawing.Point(12, 30);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(56, 13);
            this.passwdLbl.TabIndex = 3;
            this.passwdLbl.Text = "Password:";
            // 
            // domainLbl
            // 
            this.domainLbl.AutoSize = true;
            this.domainLbl.Location = new System.Drawing.Point(12, 51);
            this.domainLbl.Name = "domainLbl";
            this.domainLbl.Size = new System.Drawing.Size(46, 13);
            this.domainLbl.TabIndex = 4;
            this.domainLbl.Text = "Domain:";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(12, 9);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(58, 13);
            this.userLbl.TabIndex = 5;
            this.userLbl.Text = "Username:";
            // 
            // usrTxt
            // 
            this.usrTxt.Location = new System.Drawing.Point(76, 6);
            this.usrTxt.Name = "usrTxt";
            this.usrTxt.Size = new System.Drawing.Size(123, 20);
            this.usrTxt.TabIndex = 6;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(76, 27);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(123, 20);
            this.passTxt.TabIndex = 7;
            // 
            // domainTxt
            // 
            this.domainTxt.Location = new System.Drawing.Point(76, 48);
            this.domainTxt.Name = "domainTxt";
            this.domainTxt.Size = new System.Drawing.Size(168, 20);
            this.domainTxt.TabIndex = 8;
            this.domainTxt.MouseLeave += new System.EventHandler(this.domainTxt_MouseLeave);
            this.domainTxt.MouseHover += new System.EventHandler(this.domainTxt_MouseHover);
            // 
            // tipLbl
            // 
            this.tipLbl.AutoSize = true;
            this.tipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tipLbl.ForeColor = System.Drawing.Color.Firebrick;
            this.tipLbl.Location = new System.Drawing.Point(250, 51);
            this.tipLbl.Name = "tipLbl";
            this.tipLbl.Size = new System.Drawing.Size(128, 13);
            this.tipLbl.TabIndex = 9;
            this.tipLbl.Text = "Example: \"intra.jv.hr\"";
            this.tipLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 183);
            this.Controls.Add(this.tipLbl);
            this.Controls.Add(this.domainTxt);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.usrTxt);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.domainLbl);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwdLbl;
        private System.Windows.Forms.Label domainLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.TextBox usrTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox domainTxt;
        private System.Windows.Forms.Label tipLbl;
    }
}

