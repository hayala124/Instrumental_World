namespace Musical_instrument_store
{
    partial class Авторизация
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
            this.Login = new System.Windows.Forms.TextBox();
            this.Entrance = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Login.Location = new System.Drawing.Point(180, 124);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(265, 52);
            this.Login.TabIndex = 2;
            this.Login.Enter += new System.EventHandler(this.Login_Enter);
            this.Login.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // Entrance
            // 
            this.Entrance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Entrance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Entrance.FlatAppearance.BorderSize = 0;
            this.Entrance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.Entrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Entrance.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Entrance.Location = new System.Drawing.Point(141, 296);
            this.Entrance.Name = "Entrance";
            this.Entrance.Size = new System.Drawing.Size(333, 44);
            this.Entrance.TabIndex = 4;
            this.Entrance.Text = "Войти";
            this.Entrance.UseVisualStyleBackColor = false;
            this.Entrance.Click += new System.EventHandler(this.Entrance_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password.Location = new System.Drawing.Point(180, 218);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(265, 38);
            this.Password.TabIndex = 5;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            this.Password.Leave += new System.EventHandler(this.Password_Leave);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.Transparent;
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Registration.FlatAppearance.BorderSize = 0;
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Registration.Location = new System.Drawing.Point(0, 406);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(600, 44);
            this.Registration.TabIndex = 16;
            this.Registration.Text = "Ещё нет аккаунта? Зарегистрироваться";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход";
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.DarkRed;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(578, -2);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(22, 24);
            this.labelExit.TabIndex = 17;
            this.labelExit.Text = "Х";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click_1);
            // 
            // Авторизация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Entrance);
            this.Controls.Add(this.Login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Авторизация";
            this.Text = "Авторизация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Авторизация_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Авторизация_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button Entrance;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelExit;
    }
}