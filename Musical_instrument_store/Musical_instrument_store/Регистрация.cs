using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Musical_instrument_store
{
    public partial class Регистрация : Form
    {
        public Регистрация()
        {
            InitializeComponent();

            this.password.AutoSize = false;
            this.password.Size = new Size(this.password.Size.Width, 40);

            name.Text = "Введите имя";
            surname.Text = "Введите фамилию";
            login.Text = "Введите логин";
            password.Text = "Введите пароль";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Авторизация form2 = new Авторизация();
            form2.Show();
        }
        // При вводе текста, он становится черного цвета.
        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Введите имя")
            {
                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }
        // На элементе видна подсказка серым цветом, при нажатии на элемент текст пропадает.
        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Введите имя";
                name.ForeColor = Color.Gray;
            }
        }
        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "Введите фамилию")
            {
                surname.Text = "";
                surname.ForeColor = Color.Black;
            }
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "Введите фамилию";
                surname.ForeColor = Color.Gray;
            }
        }
        private void login_Enter(object sender, EventArgs e)
        {
            if (login.Text == "Введите логин")
            {
                login.Text = "";
                login.ForeColor = Color.Black;
            }
        }

        private void login_Leave(object sender, EventArgs e)
        {
            if (login.Text == "")
            {
                login.Text = "Введите логин";
                login.ForeColor = Color.Gray;
            }
        }
        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Введите пароль")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "Введите пароль";
                password.ForeColor = Color.Gray;
            }
        }
        private void Back_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Главная glavnaya1 = new Главная();
            glavnaya1.Show();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            try
            {
                if ((name.Text == "Введите имя") || (surname.Text == "Введите фамилию") || (login.Text == "Введите логин") || (password.Text == "Введите пароль"))
                {
                    MessageBox.Show("Заполните все поля!", "Ошибка");
                    return;
                }

                if (isUserExists())
                    return;

                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `User` (`Name`, `Surname`, `login`, `Password`) VALUES(@name, @surname, @login, @pass)", db.getConnection());

                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
                command.Parameters.Add("@pass", MySqlDbType.Int16).Value = password.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;

                db.openConnection();

                DialogResult agree = MessageBox.Show("Я согласен с условиями использования", "Продолжить?", MessageBoxButtons.OKCancel);
                if (agree == DialogResult.OK)
                {
                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show("Аккаунт был создан"); 
                }
                else
                    MessageBox.Show("Аккаунт не был создан", "Ошибка");
                db.closeConnection();
            }
            catch (System.FormatException )
            {
                MessageBox.Show("Пароль должен состоять только из цифр", "Ошибка");
            }
        }

        // Проверка на существование пользователя с введенным логином.
        public bool isUserExists()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `User` WHERE `login` = @lu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.VarChar).Value = login.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует! Введите другой логин!!", "Ошибка");
                return true;
            } 
            else
                return false;
        }
        
        // Передвижение формы.
        Point lastPoint;
        private void Регистрация_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void Регистрация_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
