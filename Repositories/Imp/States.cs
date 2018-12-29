using System.Linq;
using System.Collections.Generic;
using Dodos.UI.Models;

namespace Dodos.UI.Repositories.Imp
{
    public class StatesImp : IStates
    {
        private readonly MyBackupBloggingContext dbcontext;
        public StatesImp(MyBackupBloggingContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }

        public HashSet<StatesModel> getStates(int parm_countryid)
        {
            return new HashSet<StatesModel>(this.dbcontext.tblStates.Where(x => x.cstatus == true && x.countryid == parm_countryid));
        }
    }
}