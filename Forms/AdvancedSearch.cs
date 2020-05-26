using System.Drawing;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class AdvancedSearch : Form
    {
        bool dataEnable;
        public AdvancedSearch()
        {
            this.dataEnable = false;
            InitializeComponent();
        }

        private void buttonFind_MouseClick(object sender, MouseEventArgs e)
        {
            TempData.gangster.Name = textName.Text;
            TempData.gangster.Surname = textSurname.Text;
            TempData.gangster.Nickname = textNickname.Text;
            if (dataEnable) TempData.gangster.Birthday = birthdayPicker.Value.ToShortDateString();
            else TempData.gangster.Birthday = "";
            if (comboBoxGender.SelectedIndex != -1) TempData.gangster.Gender = comboBoxGender.SelectedItem.ToString();
            else TempData.gangster.Gender = "man";
            if (comboBoxWanted.SelectedIndex != -1) TempData.gangster.Wanted = comboBoxWanted.SelectedItem.ToString();
            else TempData.gangster.Wanted = "";
            TempData.gangster.Crime = textCrime.Text;
            TempData.gangster.Group = textGroup.Text;
            TempData.search = true;
            this.Close();
        }

        private void pictureData_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataEnable)
            {
                dataEnable = false;
                birthdayPicker.Enabled = false;
                pictureData.Image = Properties.Resources.accept;
            }
            else
            {
                dataEnable = true;
                birthdayPicker.Enabled = true;
                pictureData.Image = Properties.Resources.denied;
            }
        }

        private void pictureInfo_MouseEnter(object sender, System.EventArgs e)
        {
            pictureInfo.BackColor = Color.Green;
        }

        private void pictureInfo_MouseLeave(object sender, System.EventArgs e)
        {
            pictureInfo.BackColor= Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void pictureInfo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Введите известные вам данные о преступнике, после чего нажмите на кнопку \"Найти\".", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
