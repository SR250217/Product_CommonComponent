using Dodos.UI.Repositories;
using Dodos.UI.Models;
namespace Dodos.UI.Services {
    public class Common_Connectionservices
    {
    private ICommon_Connection objconnection;
    //private readonly ILogin login;

            public Common_Connectionservices (ICommon_Connection iCommon_Connection) {
            objconnection = iCommon_Connection;

        }

        public Common_ConnectionModel getconnectiondetails (string pcode) {
            return objconnection.getconnectiondetails (pcode);
        }

    }
}