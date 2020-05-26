using System;


namespace Interpol.Components
{
    class User
    {
        private int access;
        private string login;

        public User(){}
        public int Access
        {
            get
            {
                return this.access;
            }
            private set
            {
                if (value > 2) this.access = 2;
                else if (value < 1) this.access = 1;
                else this.access = value;
            }
        }
        public string Login
        {
            get
            {
                return this.login;
            }
            private set { }
        }

        public void SetData(string userLogin,int userAccess)
        {
            this.login = userLogin;
            this.Access = userAccess;
        }

    }
}
