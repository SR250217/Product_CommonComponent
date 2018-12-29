using System.Linq;
using Dodos.UI.Models;

namespace Dodos.UI.Repositories.Imp {
    public class LoginImp : ILogin {
        //private readonly ApplicationContext context;
        private readonly MyBloggingContext dbcontext;
        // public LoginImp (ApplicationContext context) {
        //     this.context = context;
            
        // }
 public LoginImp (MyBloggingContext dbcontext) {
            
            this.dbcontext=dbcontext;
        }
        public bool getlogindetails (string username, string password) {
            bool loginresult = false;
            
            var loginvar = dbcontext.tblAppUser.FirstOrDefault (x => x.AppUserName == "sakthi.ramachandran@kosoft.co" && x.AppUserPassword == "Password");

            if (loginvar != null)
                loginresult = true;

            return loginresult;
        }

    }
}