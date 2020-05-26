using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class Reason : Form
    {
        public Reason()
        {
            InitializeComponent();
        }

        private void pictureInfo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Для добавления в архив необходимо указать причину. Заполните поле.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.Green;
        }

        private void pictureInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void buttonAddArchieve_Click(object sender, EventArgs e)
        {
            if (textReason.Text == "") return;
            else TempData.gangster.Reason = textReason.Text;
            TempData.archieve = true;
            this.Close();
        }
    }
}
