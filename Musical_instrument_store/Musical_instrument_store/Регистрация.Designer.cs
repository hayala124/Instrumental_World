namespace Musical_instrument_store
{
    partial class Регистрация
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
            this.Registration = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.Back_main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registration.FlatAppearance.BorderSize = 0;
            this.Registration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registration.Location = new System.Drawing.Point(149, 343);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(299, 47);
            this.Registration.TabIndex = 4;
            this.Registration.Text = "Зарегистрироваться";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Gray;
            this.login.Location = new System.Drawing.Point(342, 117);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(206, 47);
            this.login.TabIndex = 8;
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Gray;
            this.password.Location = new System.Drawing.Point(342, 192);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(206, 31);
            this.password.TabIndex = 9;
            this.password.UseSystemPasswordChar = true;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Gray;
            this.name.Location = new System.Drawing.Point(41, 117);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(222, 47);
            this.name.TabIndex = 10;
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.ForeColor = System.Drawing.Color.Gray;
            this.surname.Location = new System.Drawing.Point(41, 192);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(222, 47);
            this.surname.TabIndex = 11;
            this.surname.Enter += new System.EventHandler(this.surname_Enter);
            this.surname.Leave += new System.EventHandler(this.surname_Leave);
            // 
            // Back_main
            // 
            this.Back_main.BackColor = System.Drawing.Color.Transparent;
            this.Back_main.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back_main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Back_main.FlatAppearance.BorderSize = 0;
            this.Back_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_main.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back_main.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Back_main.Location = new System.Drawing.Point(0, 406);
            this.Back_main.Name = "Back_main";
            this.Back_main.Size = new System.Drawing.Size(600, 44);
            this.Back_main.TabIndex = 19;
            this.Back_main.Text = "Вернуться на главную";
            this.Back_main.UseVisualStyleBackColor = false;
            this.Back_main.Click += new System.EventHandler(this.Back_main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(190, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 49);
            this.label1.TabIndex = 20;
            this.label1.Text = "Регистрация";
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
            this.labelExit.TabIndex = 21;
            this.labelExit.Text = "Х";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_main);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.Registration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Регистрация";
            this.Text = "Регистрация";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Регистрация_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Регистрация_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Registration;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Button Back_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelExit;
    }
}