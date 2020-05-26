using Interpol.Components;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class Dossier : Form
    {
        readonly DataRow row;
        bool somethingDid;
        public Dossier()
        {
            InitializeComponent();
        }
        public Dossier(DataRow Row)
        {
            this.somethingDid = false;
            this.row = Row;
            TempData.change = false;
            TempData.gangster.Id = Convert.ToInt32(row["Id"]);
            InitializeComponent();
        }
        private void Dossier_Load(object sender, EventArgs e)
        {
            textName.Text = row["name"].ToString();
            textSurname.Text = row["surname"].ToString();
            textNickname.Text = row["nickname"].ToString();
            textBirthday.Text = row["birthday"].ToString();
            textGender.Text = row["gender"].ToString();
            textWanted.Text = row["wanted"].ToString();
            textGroup.Text = row["organization"].ToString();
            textCrime.Text = row["crime"].ToString();
            textDescription.Text = row["description"].ToString();
            try
            {
                Bitmap img = new Bitmap(@"..\..\Images\Criminals\" + textSurname.Text + textName.Text + ".jpg");
                picturePhoto.Image = img;
            }
            catch
            {
                Bitmap img = new Bitmap(@"..\..\Images\Authorization\user.png");
                picturePhoto.Image = img;
            }
            buttonSaveChanges.Visible = false;
            CheckAccess();
        }
        private void CheckAccess()
        {
            if (TempData.user.Access == 1)
            {
                buttonChange.Visible = false;
                buttonArchieve.Visible = false;
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {

            buttonChange.Visible = false;
            buttonArchieve.Visible = false;
            buttonSaveChanges.Visible = true;

            AddWritingAccess(true);
            ChangeFunctionality(true);
        }

        #region Visual Functions
        private void AddWritingAccess(bool access)
        {
            textName.ReadOnly = !access;
            textSurname.ReadOnly = !access;
            textNickname.ReadOnly = !access;
            textGroup.ReadOnly = !access;
            textCrime.ReadOnly = !access;
            textDescription.ReadOnly = !access;

        }
        private void ChangeFunctionality(bool change)
        {
            if (change)
            {
                textGender.Visible = false;
                comboBoxGender.Visible = true;
                comboBoxGender.Text = textGender.Text;

                textWanted.Visible = false;
                comboBoxWanted.Visible = true;
                comboBoxWanted.Text = textWanted.Text;

                textBirthday.Visible = false;
                birthdayPicker.Visible = true;
                birthdayPicker.Value = Convert.ToDateTime(textBirthday.Text);
            }
            else
            {
                textGender.Text = comboBoxGender.Text;
                textGender.Visible = true;
                comboBoxGender.Visible = false;

                textWanted.Text = comboBoxWanted.Text;
                textWanted.Visible = true;
                comboBoxWanted.Visible = false;

                textBirthday.Visible = true;
                birthdayPicker.Visible = false;
                textBirthday.Text = birthdayPicker.Value.ToShortDateString();
            }
        }
        private void pictureGoBack_MouseLeave(object sender, EventArgs e)
        {
            pictureGoBack.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void pictureGoBack_MouseEnter(object sender, EventArgs e)
        {
            pictureGoBack.BackColor = Color.LightGray;
        }
        #endregion

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
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


            buttonChange.Visible = true;
            buttonArchieve.Visible = true;
            buttonSaveChanges.Visible = false;

            AddWritingAccess(false);
            ChangeFunctionality(false);

            TempData.gangster.Name = textName.Text;
            TempData.gangster.Surname = textSurname.Text;
            TempData.gangster.Nickname = textNickname.Text;
            TempData.gangster.Birthday = textBirthday.Text;
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

        private void pictureGoBack_Click(object sender, EventArgs e)
        {
            if (this.somethingDid)
            {
                TempData.change = true;
                TempData.dataBase.ChangeGangsterInfo();
            }
            Application.OpenForms[1].Show();
            this.Close();
        }

        private void buttonArchieve_Click(object sender, EventArgs e)
        {
            
            Reason reason = new Reason();
            reason.Show();
            reason.FormClosed+=Archieve;
        }
        private void Archieve(object sender,EventArgs e)
        {
            if (TempData.archieve)
            {
                TempData.gangster.Name = textName.Text;
                TempData.gangster.Surname = textSurname.Text;
                TempData.gangster.Nickname = textNickname.Text;
                TempData.gangster.Birthday = textBirthday.Text;
                TempData.gangster.Gender = textGender.Text;
                TempData.gangster.Wanted = textWanted.Text;
                TempData.gangster.Crime = textCrime.Text;
                TempData.gangster.Group = textGroup.Text;
                TempData.gangster.Description = textDescription.Text;
                TempData.gangster.Administrator = TempData.user.Login;
                TempData.gangster.Time = DateTime.Now.ToString();
                this.Close();
            }
        }

        private void pictureInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.Green;
        }

        private void pictureInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void pictureInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if(TempData.user.Access==1)MessageBox.Show("На странице представлена вся информация о преступнике.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("На странице представлена вся информация о преступнике. Нажмите на кнопку \"Изменить\", чтобы внести корректировки в дело или нажмите на кнопку \"Архив\", чтобы перенести дело в архив.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
