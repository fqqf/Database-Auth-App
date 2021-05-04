
namespace Database_Viewer
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginField = new System.Windows.Forms.TextBox();
			this.passwordField = new System.Windows.Forms.TextBox();
			this.authButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginField
			// 
			this.loginField.Location = new System.Drawing.Point(12, 34);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(141, 23);
			this.loginField.TabIndex = 0;
			this.loginField.Enter += new System.EventHandler(this.loginBox_Enter);
			this.loginField.Leave += new System.EventHandler(this.loginBox_Leave);
			// 
			// passwordField
			// 
			this.passwordField.BackColor = System.Drawing.SystemColors.Window;
			this.passwordField.Location = new System.Drawing.Point(12, 63);
			this.passwordField.Name = "passwordField";
			this.passwordField.Size = new System.Drawing.Size(141, 23);
			this.passwordField.TabIndex = 1;
			this.passwordField.Enter += new System.EventHandler(this.passBox_Enter);
			this.passwordField.Leave += new System.EventHandler(this.passBox_Leave);
			// 
			// authButton
			// 
			this.authButton.Location = new System.Drawing.Point(12, 92);
			this.authButton.Name = "authButton";
			this.authButton.Size = new System.Drawing.Size(141, 23);
			this.authButton.TabIndex = 2;
			this.authButton.Text = "Log-in";
			this.authButton.UseVisualStyleBackColor = true;
			this.authButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.AutoSize = true;
			this.exitButton.Location = new System.Drawing.Point(107, 74);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(14, 15);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "X";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.loginField);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.passwordField);
			this.panel1.Controls.Add(this.authButton);
			this.panel1.Controls.Add(this.exitButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(164, 156);
			this.panel1.TabIndex = 4;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(16, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Log into your account";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Don\'t have account?";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(164, 156);
			this.Controls.Add(this.panel1);
			this.Name = "LoginForm";
			this.Text = "Auth";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label exitButton;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox passwordField;
		private System.Windows.Forms.Button authButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}

