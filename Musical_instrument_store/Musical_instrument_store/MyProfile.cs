using System;
using System.Windows.Forms;

namespace Musical_instrument_store
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
        }

        private void Top_up_balance_Click(object sender, EventArgs e)
        {
            int balance = Convert.ToInt32(balance_now.Text);
            balance += Convert.ToInt32(Add_balance.Text);
            balance_now.Text = balance.ToString();
            Add_balance.Clear();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Главная form = new Главная();
            form.Show();
        }
    }
}
