using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Musical_instrument_store
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
            this.Password.AutoSize = false;
            this.Password.Size = new Size(this.Password.Size.Width, 42);
            Login.Text = "Введите имя";
            Password.Text = "Введите пароль";
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите имя")
            {
                Login.Text = "";
                Login.ForeColor = Color.Black;
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введите имя";
                Login.ForeColor = Color.Gray;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Введите пароль")
            {
                Password.Text = "";
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Введите пароль";
                Password.ForeColor = Color.Gray;
            }
        }

        private void Entrance_Click(object sender, EventArgs e)
        {
            string loginUser = Login.Text;
            string passwordUser = Password.Text;

            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `User` WHERE `login` = @lu AND `Password` = @pu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pu", MySqlDbType.VarChar).Value = passwordUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show( "Продолжить работу?", "Вы вошли в систему", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else 
                MessageBox.Show("Нет такого пользователя либо введен неправильный пароль", "Ошибка");
        }

        Point lastPoint;
        private void Авторизация_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Авторизация_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Регистрация form3 = new Регистрация();
            form3.ShowDialog();
        }
    }
}
