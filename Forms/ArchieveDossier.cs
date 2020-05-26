using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class ArchieveDossier : Form
    {
        DataRow row;
        public ArchieveDossier(DataRow row)
        {
            this.row = row;
            InitializeComponent();
        }
        private void ArchieveDossier_Load(object sender, EventArgs e)
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
            textReason.Text = row["reason"].ToString();
            textDate.Text = row["time"].ToString();
            try
            {
                Bitmap img = new Bitmap(@"..\..\Images\Criminals\" + textName.Text + textSurname.Text + ".jpg");
                picturePhoto.Image = img;
            }
            catch
            {
                Bitmap img = new Bitmap(@"..\..\Images\Authorization\user.png");
                picturePhoto.Image = img;
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            TempData.gangster.Id = (int)row["Id"];
            TempData.gangster.Name = textName.Text;
            TempData.gangster.Surname = textSurname.Text;
            TempData.gangster.Nickname = textNickname.Text;
            TempData.gangster.Birthday = textBirthday.Text;
            TempData.gangster.Gender = textGender.Text;
            TempData.gangster.Wanted = textWanted.Text;
            TempData.gangster.Crime = textCrime.Text;
            TempData.gangster.Group = textGroup.Text;
            TempData.gangster.Description = textDescription.Text;
            TempData.archieveChange = true;
            TempData.archieve = true;
            TempData.dataBase.MovingToGangsters();
            this.Close();
        }

        private void pictureGoBack_MouseEnter(object sender, EventArgs e)
        {
            pictureGoBack.BackColor = Color.LightGray;
        }

        private void pictureGoBack_MouseLeave(object sender, EventArgs e)
        {
            pictureGoBack.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void pictureGoBack_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
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
            MessageBox.Show("Информация о деле. Нажмите на кнопку \"Вернуть\", чтобы дело снова стало актуальным.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
