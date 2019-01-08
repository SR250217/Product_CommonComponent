using System.Linq;
using Dodos.UI.Models;
using Password_Encrypt_Decrypt;


namespace Dodos.UI.Repositories.Imp
{
    public class LoginImp : ILogin
    {
        //private readonly ApplicationContext context;
        private readonly MyBloggingContext dbcontext;
        // public LoginImp (ApplicationContext context) {
        //     this.context = context;

        // }

        public LoginImp(MyBloggingContext dbcontext)
        {

            this.dbcontext = dbcontext;
        }
        public bool getlogindetails(string AppUserName, string AppUserPassword)
        {
            bool loginresult = false;
            ProgramEncryptDecrypt objencryptdecrypt = new ProgramEncryptDecrypt();
            AppUserPassword = ProgramEncryptDecrypt.Encrypt(AppUserPassword);
            var loginvar = dbcontext.tblAppUser.FirstOrDefault(x => x.AppUserName == AppUserName && x.AppUserPassword == AppUserPassword);

            if (loginvar != null)
                loginresult = true;

            return loginresult;
        }

    }
}