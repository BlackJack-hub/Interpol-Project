using Interpol.Components;
using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpol.Forms
{
    public partial class MainScreen : Form
    {
        DataTable gangsters;

        int startIndex;
        int lastIndex;
        int amountToAdd;
        public MainScreen()
        {
            InitializeComponent();    
            gangsters = new DataTable();
            startIndex = 0;
            amountToAdd = 25;
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {

            CheckAccess();
            LoadAll(sender,e);

            totalNumber.Text = $"Total number of criminals: {gangsters.Rows.Count}";
        }
        private void CheckAccess()
        {
            if (TempData.user.Access == 1)
            {
                buttonCreate.Visible = false;
                buttonArchive.Visible = false;
            }
        }
        private void LoadAll(object sender, EventArgs e)
        {

                gangsters = TempData.dataBase.LoadGangsters();
                Loading(gangsters);        
        }
        private void Loading(DataTable table)
        {
            startIndex = 0;
            if (table.Rows.Count < amountToAdd+1)
            { 
                loadMore.Visible = false;
                lastIndex = table.Rows.Count;
            }
            else
            {
                loadMore.Visible = true;
                lastIndex = amountToAdd;
            }
            userLayoutPanel.Controls.Clear();
            CreatePanels(userLayoutPanel,table);
            searchNumber.Text = $"Search results: {gangsters.Rows.Count}";
        }

        private void CreatePanels(FlowLayoutPanel userLayoutPanel,DataTable table)
        {
            Panel panel = new Panel();
            for (int i = startIndex;i<lastIndex; i++)
            {
                panel = new Panel();
                panel.Name = $"{i}";
                panel.Width = 200;
                panel.Height = 200;
                panel.BackColor = Color.LightGray;
               
                Label name = new Label();
                name.Enabled = false;
                name.Location = new Point(95, 55);
                name.Text = table.Rows[i]["name"].ToString();
                name.ForeColor = Color.WhiteSmoke;
                name.Font = new Font("Century", 12.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));

                Label surname = new Label();
                surname.Enabled = false;
                surname.Location = new Point(95, 10);
                surname.ForeColor = Color.WhiteSmoke;
                surname.Font = new Font("Century", 12.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                surname.Text = table.Rows[i]["surname"].ToString();

                Label nickname = new Label();
                nickname.Enabled = false;
                nickname.Location = new Point(95, 100);
                nickname.ForeColor = Color.WhiteSmoke;
                nickname.Font = new Font("Century", 12.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
                nickname.Text = table.Rows[i]["nickname"].ToString();

                PictureBox image = new PictureBox();
                image.Width = 84;
                image.Height = 84;
                image.Enabled = false;
                image.Location = new Point(3, 36);
                image.SizeMode = PictureBoxSizeMode.StretchImage;
                try
                {
                    Bitmap img = new Bitmap(@"..\..\Images\Criminals\" + surname.Text + name.Text + ".jpg");
                    image.Image = img;
                }
                catch
                {
                    image.Image = Properties.Resources.user;
                }
                //image.Image = Properties.Resources.user;

                TextBox description = new TextBox();
                description.Location = new Point(10, 140);
                description.Width = 180;
                description.Height = 50;
                description.Multiline = true;
                description.Enabled = false;
                description.Text = table.Rows[i]["description"].ToString();

                panel.Controls.Add(image);
                panel.Controls.Add(surname);
                panel.Controls.Add(name);
                panel.Controls.Add(nickname);
                panel.Controls.Add(description);

                userLayoutPanel.Controls.Add(panel);
                userLayoutPanel.Controls[i].MouseDoubleClick += OpenGangster;
                
            }
        }
        private void OpenGangster(object sender,EventArgs e)
        {
            string getName = ((Panel)sender).Name;
            int index = Convert.ToInt32(getName);
            Dossier dossier = new Dossier(this.gangsters.Rows[index]);
            dossier.Show();
            dossier.FormClosed += DossierClose;
        }
        private void DossierClose(object sender,EventArgs e)
        {
            if (TempData.archieve)
            {
                TempData.archieve = false;
                TempData.dataBase.MoveToArchieve();
                TotalNumberChange(-1);
                LoadAll(sender,e);
                
            }
            else if (TempData.change)
            {
                LoadAll(sender, e);
            }

        }
 
        private void loadMore_Click(object sender, EventArgs e)
        {
            if (lastIndex < gangsters.Rows.Count)
            {
                startIndex += amountToAdd;
                if (lastIndex + amountToAdd <= gangsters.Rows.Count) lastIndex += amountToAdd;
                else lastIndex += gangsters.Rows.Count - lastIndex;
                CreatePanels(userLayoutPanel, gangsters);
                if (lastIndex == gangsters.Rows.Count) loadMore.Visible = false;
            }
        }

        private void buttonSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (searchSurname.Text == "Фамилия" && searchName.Text == "Имя" && searchNickname.Text == "Прозвище")
            {
                LoadAll(sender, e);
                return;
            }
            if (searchSurname.Text == "Фамилия") TempData.gangster.Surname = "";
            else TempData.gangster.Surname = searchSurname.Text;
            if (searchName.Text == "Имя") TempData.gangster.Name = "";
            else TempData.gangster.Name = searchName.Text;
            if (searchNickname.Text == "Прозвище") TempData.gangster.Nickname = "";
            else TempData.gangster.Nickname = searchNickname.Text;

            this.gangsters = TempData.dataBase.FindGangster();
            Loading(gangsters);
        }

        #region Visual Seacrh Functions
        private void BlockButtons(bool block)
        {
            buttonCreate.Enabled = !block;
            pictureAdvancedSearch.Enabled = !block;
            buttonArchive.Enabled = !block;
        }
        private void searchSurname_Enter(object sender, EventArgs e)
        {
            if(searchSurname.Text=="Фамилия")searchSurname.Text="";
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

        #region Window Buttons
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            BlockButtons(true);
            CreateDossier createDossier = new CreateDossier();
            createDossier.Show();
            createDossier.FormClosed += AddGangster;
            
        }
        private void AddGangster(object sender,EventArgs e)
        {
            BlockButtons(false);
            if (TempData.change)
            {
                TotalNumberChange(1);
                TempData.dataBase.AddGangster();
                LoadAll(sender, e);
            }
        }
        private void TotalNumberChange(int add)
        {
            if (add < 1) add = -1;
            else add = 1;

            string newS = totalNumber.Text;
            int newINt = Convert.ToInt32(newS.Substring(27)) + add;
            totalNumber.Text = newS.Substring(0, 27) + newINt.ToString();
        }

        private void pictureAdvancedSearch_MouseClick(object sender, MouseEventArgs e)
        {
            BlockButtons(true);
            TempData.search = false;
            AdvancedSearch advancedSearch = new AdvancedSearch();
            advancedSearch.Show();
            advancedSearch.FormClosed += SearchAdvance;
        }
        private void SearchAdvance(object sender,EventArgs e)
        {
            BlockButtons(false);
            if (TempData.search)
            {
                this.gangsters=TempData.dataBase.FindGangsterSearch();
                Loading(gangsters);
            }
        }

        private void buttonArchive_MouseClick(object sender, MouseEventArgs e)
        {
            Archive archive = new Archive();
            archive.Show();
            this.Hide();
            archive.FormClosed += ArchiveClose;
        }
        private void ArchiveClose(object sender,EventArgs e)
        {
            if (TempData.archieveChange)
            {
                TempData.archieve = false;
                TempData.archieveChange = false;
                LoadAll(sender, e);
                totalNumber.Text = $"Total number of criminals: {gangsters.Rows.Count}";
            }
            this.Show();
        }

        private void pictureInfo_MouseClick(object sender, MouseEventArgs e)
        {
            if (TempData.user.Access == 1)
            {
                MessageBox.Show("Нажмите на лупу, чтобы открыть расширенный поиск преступников. Для открытия личного дела нажмите два раза на интересующего вас преступника.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нажмите на лупу, чтобы открыть расширенный поиск преступников. Для открытия личного дела нажмите два раза на интересующего вас преступника. Нажмите на кнопку \"Создать\", чтобы добавить новое дело или на кнопку \"Архив\", чтобы открыть архив преступников.", "Подсказка", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void pictureReload_MouseClick(object sender, MouseEventArgs e)
        {
            pictureReload.BackColor = Color.DarkGray;
            LoadAll(sender, e);
            searchName.Text = "Имя";
            searchSurname.Text = "Фамилия";
            searchNickname.Text = "Прозвище";
        }

        private void pictureReload_MouseEnter(object sender, EventArgs e)
        {
            pictureReload.BackColor = Color.LightGray;
        }

        private void pictureReload_MouseLeave(object sender, EventArgs e)
        {
            pictureReload.BackColor = Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(111)))), ((int)(((byte)(161)))));
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
