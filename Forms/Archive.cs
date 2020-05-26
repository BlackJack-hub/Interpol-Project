using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class Archive : Form
    {
        DataTable archive;
        public Archive()
        {
            TempData.archieveChange = false;
            InitializeComponent();
            this.archive = new DataTable();
        }

        private void Archive_Load(object sender, EventArgs e)
        {
            this.archive = TempData.dataBase.LoadArchive();
            Loading();
        }
        private void Loading()
        {
            listBoxArchive.Items.Clear();
            for (int i = 0; i < this.archive.Rows.Count; i++)
            {
                listBoxArchive.Items.Add(i+1+") "+archive.Rows[i]["name"].ToString() + " " + archive.Rows[i]["surname"].ToString() + " " + archive.Rows[i]["nickname"].ToString());
            }
        }

        private void buttonOpen_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxArchive.SelectedIndex != -1)
            {
                TempData.archieve = false;
                ArchieveDossier archieveDossier = new ArchieveDossier(archive.Rows[listBoxArchive.SelectedIndex]);
                archieveDossier.Show();
                archieveDossier.FormClosed += ArchiveDossierClose;
            }
        }
        private void ArchiveDossierClose(object sender,EventArgs e)
        {
            if (TempData.archieveChange&&TempData.archieve) Archive_Load(sender,e);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (listBoxArchive.SelectedIndex != -1)
            {
                TempData.gangster.Id = (int)archive.Rows[listBoxArchive.SelectedIndex]["Id"];
                TempData.gangster.Name = archive.Rows[listBoxArchive.SelectedIndex]["name"].ToString();
                TempData.gangster.Surname = archive.Rows[listBoxArchive.SelectedIndex]["surname"].ToString();
                TempData.gangster.Nickname = archive.Rows[listBoxArchive.SelectedIndex]["nickname"].ToString();
                TempData.gangster.Birthday = archive.Rows[listBoxArchive.SelectedIndex]["birthday"].ToString();
                TempData.gangster.Gender = archive.Rows[listBoxArchive.SelectedIndex]["gender"].ToString();
                TempData.gangster.Wanted = archive.Rows[listBoxArchive.SelectedIndex]["wanted"].ToString();
                TempData.gangster.Crime = archive.Rows[listBoxArchive.SelectedIndex]["crime"].ToString();
                TempData.gangster.Group = archive.Rows[listBoxArchive.SelectedIndex]["organization"].ToString();
                TempData.gangster.Description = archive.Rows[listBoxArchive.SelectedIndex]["description"].ToString();
                TempData.archieveChange = true;
                TempData.dataBase.MovingToGangsters();
                Archive_Load(sender, e);
            }
        }
        private void pictureHome_MouseEnter(object sender, EventArgs e)
        {
            pictureHome.BackColor = Color.LightGray;
        }

        private void pictureHome_MouseLeave(object sender, EventArgs e)
        {
            pictureHome.BackColor = Color.White;
        }
        private void pictureHome_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        #region Visual Seacrh Functions
        private void searchSurname_Enter(object sender, EventArgs e)
        {
            if (searchSurname.Text == "Фамилия") searchSurname.Text = "";
        }

        private void searchSurname_Leave(object sender, EventArgs e)
        {
            if (searchSurname.Text == "") searchSurname.Text = "Фамилия";
        }

        private void searchName_Enter(object sender, EventArgs e)
        {
            if (searchName.Text == "Имя") searchName.Text = "";
        }

        private void searchName_Leave(object sender, EventArgs e)
        {
            if (searchName.Text == "") searchName.Text = "Имя";
        }

        private void searchNickname_Enter(object sender, EventArgs e)
        {
            if (searchNickname.Text == "Прозвище") searchNickname.Text = "";
        }

        private void searchNickname_Leave(object sender, EventArgs e)
        {
            if (searchNickname.Text == "") searchNickname.Text = "Прозвище";
        }
        #endregion
        #region Windows Buttons
        private void close_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void pictureInfo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("На странице показаны личные дела, которые находятся в архиве. Выберите дело, нажмите на кнопку \"Открыть\", чтобы просмотреть дело и на кнопку \"Вернуть\", чтобы сделать дело снова актуальным.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.Green;
        }

        private void pictureInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureInfo.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void buttonArchiveSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (searchSurname.Text == "Фамилия" && searchName.Text == "Имя" && searchNickname.Text == "Прозвище")
            {
                Archive_Load(sender, e);
                return;
            }
            if (searchSurname.Text == "Фамилия") TempData.gangster.Surname = "";
            else TempData.gangster.Surname = searchSurname.Text;
            if (searchName.Text == "Имя") TempData.gangster.Name = "";
            else TempData.gangster.Name = searchName.Text;
            if (searchNickname.Text == "Прозвище") TempData.gangster.Nickname = "";
            else TempData.gangster.Nickname = searchNickname.Text;

            this.archive = TempData.dataBase.FindArchieveGangster();
            Loading();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
           closeArchive.BackColor= Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void exitArchive_MouseLeave(object sender, EventArgs e)
        {
           exitArchive.BackColor= Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }
    }
}
