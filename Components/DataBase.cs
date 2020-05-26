using System;
using System.Data;
using System.Data.SqlClient;

namespace Interpol.Components
{
    class DataBase
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private DataSet dataset;
        private const string Users = "Users";
        private const string Gangsters = "Gangsters";
        private const string Archieve = "Archieve";

        public DataBase()
        {
            this.sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\InterpolDataBase.mdf;Integrated Security=True");
            this.sqlDataAdapter = new SqlDataAdapter();
            this.dataset = new DataSet();
            this.dataset.Tables.Add(Archieve);
            this.dataset.Tables.Add(Gangsters);
            this.dataset.Tables.Add(Users);

        }
        #region Connection Functions
        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }

        public void openConnetion()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnetion()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        #endregion


        public DataTable FindUser(string login, string password)
        {
            openConnetion();
            this.sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Users WHERE login=N'{login}' AND password=N'{password}'", sqlConnection);
            dataset.Clear();
            sqlDataAdapter.Fill(dataset,Users);
            closeConnetion();
            return dataset.Tables[Users];
        }
        public DataTable LoadGangsters()
        {
            openConnetion();
            dataset.Tables[Gangsters].Clear();
            sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Gangsters", sqlConnection);
            sqlDataAdapter.Fill(dataset,Gangsters);
            closeConnetion();
            return dataset.Tables[Gangsters];
        }
        public DataTable FindGangster()
        {
            openConnetion();
            dataset.Clear();
            sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Gangsters WHERE name LIKE N'%{TempData.gangster.Name}%' AND surname LIKE N'%{TempData.gangster.Surname}%' AND nickname LIKE N'%{TempData.gangster.Nickname}%'", sqlConnection);
            sqlDataAdapter.Fill(dataset, Gangsters);
            closeConnetion();
            return dataset.Tables[Gangsters];
        }
        public DataTable FindGangsterSearch()
        {
            openConnetion();
            dataset.Tables[Gangsters].Clear();
            sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Gangsters WHERE name LIKE N'%{TempData.gangster.Name}%' AND surname LIKE N'%{TempData.gangster.Surname}%' AND nickname LIKE N'%{TempData.gangster.Nickname}%' AND gender LIKE N'%{TempData.gangster.Gender}%' AND birthday LIKE N'%{TempData.gangster.Birthday}%' AND wanted LIKE N'%{TempData.gangster.Wanted}%' AND crime LIKE N'%{TempData.gangster.Crime}%' AND organization LIKE N'%{TempData.gangster.Group}%' ", sqlConnection);
            sqlDataAdapter.Fill(dataset, Gangsters);
            closeConnetion();
            return dataset.Tables[Gangsters];
        }
        public void ChangeGangsterInfo()
         {
             openConnetion();
             dataset.Tables[Gangsters].Clear();
             try
             {
                 sqlDataAdapter = new SqlDataAdapter($"UPDATE Gangsters SET name=N'{TempData.gangster.Name}',surname=N'{TempData.gangster.Surname}',nickname=N'{TempData.gangster.Nickname}',birthday=N'{TempData.gangster.Birthday}',gender=N'{TempData.gangster.Gender}',wanted=N'{TempData.gangster.Wanted}',crime=N'{TempData.gangster.Crime}',description=N'{TempData.gangster.Description}',organization=N'{TempData.gangster.Group}' WHERE Id='{TempData.gangster.Id}' ", sqlConnection);
                 sqlDataAdapter.Fill(dataset, Gangsters);
                 dataset.Tables[Gangsters].AcceptChanges();
                
             }
             catch (Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }
             closeConnetion();
         }
        public void AddGangster()
        {
                openConnetion();
                sqlDataAdapter = new SqlDataAdapter($"INSERT INTO Gangsters (name,surname,nickname,birthday,gender,wanted,crime,description,organization) VALUES(N'{TempData.gangster.Name}',N'{TempData.gangster.Surname}',N'{TempData.gangster.Nickname}',N'{TempData.gangster.Birthday}',N'{TempData.gangster.Gender}',N'{TempData.gangster.Wanted}',N'{TempData.gangster.Crime}',N'{TempData.gangster.Description}',N'{TempData.gangster.Group}')", sqlConnection);
                sqlDataAdapter.Fill(dataset, Gangsters);
                dataset.Tables[Gangsters].AcceptChanges();
                closeConnetion();
           
        }
        public void MoveToArchieve()
         {
            openConnetion();
            sqlDataAdapter = new SqlDataAdapter($"DELETE FROM Gangsters WHERE Id='{TempData.gangster.Id}'", sqlConnection);
            sqlDataAdapter.Fill(dataset, Gangsters);
            dataset.Tables[Gangsters].AcceptChanges();
            sqlDataAdapter = new SqlDataAdapter($"INSERT INTO Archieve (name,surname,nickname,birthday,gender,wanted,crime,description,organization,reason,loguser,time) VALUES(N'{TempData.gangster.Name}',N'{TempData.gangster.Surname}',N'{TempData.gangster.Nickname}',N'{TempData.gangster.Birthday}',N'{TempData.gangster.Gender}',N'{TempData.gangster.Wanted}',N'{TempData.gangster.Crime}',N'{TempData.gangster.Description}',N'{TempData.gangster.Group}',N'{TempData.gangster.Reason}',N'{TempData.user.Login}',N'{TempData.gangster.Time}')", sqlConnection);
            sqlDataAdapter.Fill(dataset, Archieve);
            try
            {

                dataset.Tables[Archieve].AcceptChanges();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            closeConnetion();
         }
        public DataTable LoadArchive()
        {
            openConnetion();
            dataset.Tables[Archieve].Clear();
            sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Archieve", sqlConnection);
            sqlDataAdapter.Fill(dataset, Archieve);
            dataset.Tables[Archieve].AcceptChanges();
            closeConnetion();
            return dataset.Tables[Archieve];
        }
        public DataTable FindArchieveGangster()
        {
            openConnetion();
            dataset.Tables[Archieve].Clear();
            sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM Archieve WHERE name LIKE N'%{TempData.gangster.Name}%' AND surname LIKE N'%{TempData.gangster.Surname}%' AND nickname LIKE N'%{TempData.gangster.Nickname}%'", sqlConnection);
            sqlDataAdapter.Fill(dataset, Archieve);
            closeConnetion();
            return dataset.Tables[Archieve];
        }
        public void MovingToGangsters()
        {
            openConnetion();
            sqlDataAdapter = new SqlDataAdapter($"DELETE FROM Archieve WHERE Id='{TempData.gangster.Id}'", sqlConnection);
            sqlDataAdapter.Fill(dataset,Archieve);
            dataset.Tables[Archieve].AcceptChanges();
            sqlDataAdapter = new SqlDataAdapter($"INSERT INTO Gangsters (name,surname,nickname,birthday,gender,wanted,crime,description,organization) VALUES(N'{TempData.gangster.Name}',N'{TempData.gangster.Surname}',N'{TempData.gangster.Nickname}',N'{TempData.gangster.Birthday}',N'{TempData.gangster.Gender}',N'{TempData.gangster.Wanted}',N'{TempData.gangster.Crime}',N'{TempData.gangster.Description}',N'{TempData.gangster.Group}')", sqlConnection);
            sqlDataAdapter.Fill(dataset,Archieve);
            try
            {

                dataset.Tables[Archieve].AcceptChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            closeConnetion();
        }
        public void AddTestDataGangsters()
        {
            openConnetion();
            try
            {
                for (int i = 1; i < 100; i++)
                {
                    sqlDataAdapter = new SqlDataAdapter($"INSERT INTO Gangsters  VALUES ('test{i}','test{i}','test{i}','01.01.2000','man ','Germany','Crime','This is description','KNURE')", sqlConnection);
                    sqlDataAdapter.Fill(dataset, Gangsters);
                   
                }
                dataset.Tables[Gangsters].AcceptChanges();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            closeConnetion();
        }
        public void AddTestDataArchive()
        {
            openConnetion();
            try
            {
                for (int i = 1; i < 100; i++)
                {
                    sqlDataAdapter = new SqlDataAdapter($"INSERT INTO Archieve  VALUES ('test{i}','test{i}','test{i}','01.01.2000','man ','Germany','Crime','This is description','KNURE','Dead','Admin','24.05.2020 12:03:19')", sqlConnection);
                    sqlDataAdapter.Fill(dataset,Archieve);

                }
                dataset.Tables[Archieve].AcceptChanges();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            closeConnetion();
        }
    }
}
