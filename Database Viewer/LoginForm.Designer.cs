
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
			this.loginBox = new System.Windows.Forms.TextBox();
			this.passBox = new System.Windows.Forms.TextBox();
			this.authButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(12, 12);
			this.loginBox.Name = "loginBox";
			this.loginBox.Size = new System.Drawing.Size(100, 23);
			this.loginBox.TabIndex = 0;
			// 
			// passBox
			// 
			this.passBox.BackColor = System.Drawing.SystemColors.Window;
			this.passBox.Location = new System.Drawing.Point(12, 51);
			this.passBox.Name = "passBox";
			this.passBox.Size = new System.Drawing.Size(100, 23);
			this.passBox.TabIndex = 1;
			// 
			// authButton
			// 
			this.authButton.Location = new System.Drawing.Point(12, 93);
			this.authButton.Name = "authButton";
			this.authButton.Size = new System.Drawing.Size(75, 23);
			this.authButton.TabIndex = 2;
			this.authButton.Text = "log in";
			this.authButton.UseVisualStyleBackColor = true;
			this.authButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.AutoSize = true;
			this.exitButton.Location = new System.Drawing.Point(411, 9);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(38, 15);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "label1";
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.authButton);
			this.Controls.Add(this.passBox);
			this.Controls.Add(this.loginBox);
			this.Name = "LoginForm";
			this.Text = "Аутентификация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label exitButton;
		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.TextBox passBox;
		private System.Windows.Forms.Button authButton;
	}
}

