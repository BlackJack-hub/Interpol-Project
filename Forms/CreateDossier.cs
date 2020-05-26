using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class CreateDossier : Form
    {
        bool somethingDid;
        public CreateDossier()
        {
            this.somethingDid = false;
            InitializeComponent();
        }

        #region Visual Functions
        private void pictureGoBack_MouseEnter(object sender, EventArgs e)
        {
            pictureGoBack.BackColor = Color.LightGray;
        }

        private void pictureGoBack_MouseLeave(object sender, EventArgs e)
        {
            pictureGoBack.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }
        #endregion

        private void pictureGoBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void CreateDossier_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.somethingDid)
            {
                TempData.change = true;
            }
            else TempData.change = false;
        }

        private void buttonCreate_MouseClick(object sender, MouseEventArgs e)
        {
            if (textName.Text != "")
            {
                ChangeCase(textName);
                nameError.Visible = false;
            }
            else
            {
                MessageBox.Show("Введите имя!");
                nameError.Visible = true;
                return;
            }
            if (textSurname.Text != "")
            {
                ChangeCase(textSurname);
                surnameError.Visible = false;
            }
            else
            {
                MessageBox.Show("Введите фамилию!");
                surnameError.Visible = true;
                return;
            }
            if (textNickname.Text != "")
            {
                ChangeCase(textNickname);
                nicknameError.Visible = false;
            }
            else
            {
                MessageBox.Show("Введите прозвище!");
                nicknameError.Visible = true;
                return;
            }
            if (comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите пол!");
                genderError.Visible = true;
                return;
            }
            else genderError.Visible = false;

            if (comboBoxWanted.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите страну!");
                wantedError.Visible = true;
                return;
            }
            else wantedError.Visible = false;

            if (textGroup.Text == "")
            {
                MessageBox.Show("Введите преступную группировку!");
                groupError.Visible = true;
                return;
            }
            else groupError.Visible = false;

            if (textCrime.Text != "")
            {
                ChangeCase(textCrime);
                crimeError.Visible = false;
            }
            else
            {
                MessageBox.Show("Введите преступление!");
                crimeError.Visible = true;
                return;
            }
            if (textDescription.Text != "")
            {
                ChangeCase(textDescription);
                descriptionError.Visible = false;
            }
            else
            {
                MessageBox.Show("Введите описание преступника!");
                descriptionError.Visible = true;
                return;
            }

            this.somethingDid = true;
            label11.Visible = true;
            TempData.gangster.Name = textName.Text;
            TempData.gangster.Surname = textSurname.Text;
            TempData.gangster.Nickname = textNickname.Text;
            TempData.gangster.Birthday = birthdayPicker.Value.ToShortDateString();
            TempData.gangster.Gender = comboBoxGender.SelectedItem.ToString();
            TempData.gangster.Wanted = comboBoxWanted.SelectedItem.ToString();
            TempData.gangster.Crime = textCrime.Text;
            TempData.gangster.Group = textGroup.Text;
            TempData.gangster.Description = textDescription.Text;
        }
        private void ChangeCase(TextBox box)
        {
            string sentence = box.Text;
            sentence = sentence.Substring(0, 1).ToUpper() + sentence.Substring(1).ToLower();
            box.Text = sentence;
        }

        private void pictureInfo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Заполните все поля ниже, чтобы создать новое дело.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureInfo.BackColor= Color.Green; 
        }

        private void pictureInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }
    }
}
