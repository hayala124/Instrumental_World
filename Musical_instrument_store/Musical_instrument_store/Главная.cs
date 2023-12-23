using System;
using System.Drawing;
using System.Windows.Forms;

namespace Musical_instrument_store
{
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        Point lastPoint;
        // Передвижение формы.
        private void Главная_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Главная_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Личный кабинет")
            {
                Авторизация f2 = new Авторизация();
                f2.ShowDialog();

                // После закрытия формы авторизации активируем 2 пункт меню.
                toolStripMenuItem2.Visible = true;
            }
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.ShowDialog();
        }

    }
}
