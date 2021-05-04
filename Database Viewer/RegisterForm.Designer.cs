
namespace Database_Viewer
{
	partial class RegisterForm
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
			this.loginBox = new System.Windows.Forms.TextBox();
			this.authButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.loginField = new System.Windows.Forms.TextBox();
			this.nameField = new System.Windows.Forms.TextBox();
			this.passwordField = new System.Windows.Forms.TextBox();
			this.surnameField = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.passBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// loginBox
			// 
			this.loginBox.Location = new System.Drawing.Point(12, 12);
			this.loginBox.Name = "loginField";
			this.loginBox.Size = new System.Drawing.Size(126, 23);
			this.loginBox.TabIndex = 0;
			// 
			// authButton
			// 
			this.authButton.Location = new System.Drawing.Point(12, 119);
			this.authButton.Name = "authButton";
			this.authButton.Size = new System.Drawing.Size(126, 23);
			this.authButton.TabIndex = 2;
			this.authButton.Text = "Register";
			this.authButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.AutoSize = true;
			this.exitButton.BackColor = System.Drawing.Color.White;
			this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.exitButton.Location = new System.Drawing.Point(151, 12);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(14, 15);
			this.exitButton.TabIndex = 3;
			this.exitButton.Text = "X";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.passBox);
			this.panel1.Controls.Add(this.loginBox);
			this.panel1.Controls.Add(this.authButton);
			this.panel1.Controls.Add(this.exitButton);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 150);
			this.panel1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.loginField);
			this.panel2.Controls.Add(this.nameField);
			this.panel2.Controls.Add(this.passwordField);
			this.panel2.Controls.Add(this.surnameField);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 150);
			this.panel2.TabIndex = 6;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(112, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Registration";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label1.Font = new System.Drawing.Font("Arial", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(150, 113);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "log-in with account";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// loginField
			// 
			this.loginField.BackColor = System.Drawing.SystemColors.Window;
			this.loginField.Location = new System.Drawing.Point(12, 74);
			this.loginField.Name = "loginField";
			this.loginField.Size = new System.Drawing.Size(126, 23);
			this.loginField.TabIndex = 4;
			this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
			this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
			// 
			// nameField
			// 
			this.nameField.Location = new System.Drawing.Point(12, 30);
			this.nameField.Name = "nameField";
			this.nameField.Size = new System.Drawing.Size(126, 23);
			this.nameField.TabIndex = 0;
			this.nameField.Enter += new System.EventHandler(this.nameField_Enter);
			this.nameField.Leave += new System.EventHandler(this.nameField_Leave);
			// 
			// passwordField
			// 
			this.passwordField.BackColor = System.Drawing.SystemColors.Window;
			this.passwordField.Location = new System.Drawing.Point(151, 74);
			this.passwordField.Name = "passwordField";
			this.passwordField.Size = new System.Drawing.Size(126, 23);
			this.passwordField.TabIndex = 4;
			this.passwordField.Enter += new System.EventHandler(this.passwordField_Enter);
			this.passwordField.Leave += new System.EventHandler(this.passwordField_Leave);
			// 
			// surnameField
			// 
			this.surnameField.Location = new System.Drawing.Point(151, 30);
			this.surnameField.Name = "surnameField";
			this.surnameField.Size = new System.Drawing.Size(126, 23);
			this.surnameField.TabIndex = 0;
			this.surnameField.Enter += new System.EventHandler(this.surnameField_Enter);
			this.surnameField.Leave += new System.EventHandler(this.surnameField_Leave);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 113);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// passBox
			// 
			this.passBox.BackColor = System.Drawing.SystemColors.Window;
			this.passBox.Location = new System.Drawing.Point(12, 72);
			this.passBox.Name = "passwordField";
			this.passBox.Size = new System.Drawing.Size(126, 23);
			this.passBox.TabIndex = 4;
			// 
			// RegisterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 150);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "RegisterForm";
			this.Text = "RegisterForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox loginBox;
		private System.Windows.Forms.Button authButton;
		private System.Windows.Forms.Label exitButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox loginField;
		private System.Windows.Forms.TextBox nameField;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.TextBox surnameField;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox passBox;
		private System.Windows.Forms.TextBox passwordField;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}