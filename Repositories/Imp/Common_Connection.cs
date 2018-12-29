using System.Linq;
using Dodos.UI.Models;
using System;

namespace Dodos.UI.Repositories.Imp {
       public class Common_ConnectionIMP : ICommon_Connection {
        private readonly ApplicationContext context;
        private readonly MyBackupBloggingContext dbcontext;
        public Common_ConnectionIMP (ApplicationContext context) {
            this.context = context;
            
        }
 public Common_ConnectionIMP (MyBackupBloggingContext dbcontext) {
            
            this.dbcontext=dbcontext;
        }
        
        public Common_ConnectionModel getconnectiondetails (string pcode) {
            
            
            return dbcontext.tblProductDB.FirstOrDefault (x => x.ProductCode == "KS0001");
           

            
        }

    }
}