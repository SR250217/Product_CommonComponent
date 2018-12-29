using Dodos.UI.Repositories;

namespace Dodos.UI.Services {
    public class Loginservices {
        private ILogin loginobj;

        private readonly ILogin login;

        public Loginservices (ILogin ilogin) {
            loginobj = ilogin;

        }

        public bool getlogindetails (string username, string password) {
            return loginobj.getlogindetails (username, password);
        }

    }

}