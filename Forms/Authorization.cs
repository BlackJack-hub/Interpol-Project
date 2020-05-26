using Interpol.Components;
using Interpol.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace Interpol
{
    public partial class Authorization : Form
    {
        
        private int countOfFailures = 0;
        private int timeOfWait = 10;
        private int checkTimer = 0;
        private bool passedFirstLevel = false;

        public Authorization()
        {
           InitializeComponent();

        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            TempData.dataBase = new DataBase();
            TempData.user = new User();
        }

        #region TextBox Visual functions
        private void userLogin_Enter(object sender, EventArgs e)
        {
            if (userLogin.Text == "Логин") userLogin.Text = "";
        }

        private void userLogin_Leave(object sender, EventArgs e)
        {
            if (userLogin.Text == "") userLogin.Text = "Логин";
        }

        private void userPassword_Enter(object sender, EventArgs e)
        {
            if (userPassword.Text == "Пароль")
            {
                userPassword.UseSystemPasswordChar = true;
                userPassword.Text = "";
            }
        }

        private void userPassword_Leave(object sender, EventArgs e)
        {
            if (userPassword.Text == "")
            {
                userPassword.UseSystemPasswordChar = false;
                userPassword.Text = "Пароль";
            }
        }
        private void userCode_Enter(object sender, EventArgs e)
        {
            if (userCode.Text == "Секретный код")
            {
                userCode.UseSystemPasswordChar = true;
                userCode.Text = "";
            }
        }

        private void userCode_Leave(object sender, EventArgs e)
        {
            if (userCode.Text == "")
            {
                userCode.UseSystemPasswordChar = false;
                userCode.Text = "Секретный код";
            }
        }
        private void pictureCodeVisible_MouseClick(object sender, MouseEventArgs e)
        {
            if (userCode.UseSystemPasswordChar == false)
            {
                userCode.UseSystemPasswordChar = true;
                pictureCodeVisible.Image = Properties.Resources.show;
            }
            else
            {
                userCode.UseSystemPasswordChar = false;
                pictureCodeVisible.Image = Properties.Resources.hide;
            }
        }
        #endregion

        private void timerFailure_Tick(object sender, EventArgs e)
        {
            checkTimer++;
            userErrorBlock.Visible = true;
            userErrorBlock.Text = $"Программа заблокированна на {timeOfWait - checkTimer} секунд!";
            if (checkTimer == timeOfWait)
            {
                checkTimer = 0;
                timeOfWait *= 2;

                mainPanel.Enabled = true;
                userErrorBlock.Visible = false;
                userError.Visible = true;

                userError.Text = "Введены неверные данные!";
                timerFailure.Stop();
            }
        }

        private void CheckData_MouseClick(object sender, MouseEventArgs e)
        {
            if (passedFirstLevel == false)
            {
                if (userLogin.Text == "Логин") return;
                if (userPassword.Text == "Пароль") return;

                String loginUser = userLogin.Text;
                String pasUser = userPassword.Text;

                DataTable table = TempData.dataBase.FindUser(loginUser, pasUser);

                if (table.Rows.Count == 1)
                {
                    TempData.user.SetData(Convert.ToString(table.Rows[0]["login"]), Convert.ToInt32(table.Rows[0]["access"]));
                    TempData.mail = new Mail(Convert.ToString(table.Rows[0]["mail"]));
                    TempData.mail.SendMail();

                    MessageBox.Show("Для подтверждения личности вам был отправлен секретный код на почту!", "ВНИМАНИЕ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    timerFailure.Enabled = false;
                    countOfFailures = 0;
                    passedFirstLevel = true;

                    userCode.Enabled = true;
                    userCode.Visible = true;

                    userLogin.Enabled = false;
                    userPassword.Enabled = false;

                    pictureCode.Visible = true;
                    pictureCodeVisible.Visible = true;
                    pictureCodeVisible.Enabled = true;
                }
                else if (table.Rows.Count > 1)
                {
                    MessageBox.Show("Обратитесь к системному администратору! Найдены повторяющиеся данные!", "Ошибка в базе данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    BlockDisplay();
                }
            }
            else
            {
                if (userCode.Text == "Секретный код") return;
                string userSecretCode = userCode.Text;

                if (userCode.Text==TempData.mail.SecretCode)
                {
                    TempData.gangster = new Gangster();
                    TempData.change = false;
                    TempData.search = false;
                    TempData.archieve = false;
                    MainScreen main = new MainScreen();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    BlockDisplay();
                }
            }
        }
        private void BlockDisplay()
        {
            userError.Visible = true;
            countOfFailures++;
            if (countOfFailures >= 3)
            {
                userError.Visible = false;
                mainPanel.Enabled = false;
                timerFailure.Enabled = true;

            }
        }

        
    }
}
