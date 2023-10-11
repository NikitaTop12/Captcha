using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace создание_Captcha
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (new ModelEF().Users.Any(x =>
             x.Login == textBox1.Text &&
             x.Password == textBox2.Text))
             {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            MessageBox.Show("Пользователь не найден,пройдите проверку Captcha!");
            new CaptchForm().ShowDialog();
        }
    }
}
