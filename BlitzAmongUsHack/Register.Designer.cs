namespace BlitzAmongUsHack
{
    partial class Register
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
            this.button2 = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back to Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Register";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(15, 84);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(156, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username";
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(15, 162);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(156, 20);
            this.Key.TabIndex = 3;
            this.Key.Text = "License/key";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(15, 136);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(156, 20);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(15, 110);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(156, 20);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(43, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Welcome to Blitz ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(-1, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "⚡Register⚡";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(183, 245);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}