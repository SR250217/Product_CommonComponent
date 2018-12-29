using System.Linq;
using System.Collections.Generic;
using Dodos.UI.Models;

namespace Dodos.UI.Repositories.Imp
{
    public class CitiesImp : ICities
    {
        private readonly MyBackupBloggingContext dbcontext;
        public CitiesImp(MyBackupBloggingContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }

        public HashSet<CitiesModel> getCities(int parm_stateid)
        {
            return new HashSet<CitiesModel>(this.dbcontext.tblCities.Where(x => x.cstatus == true && x.stateid == parm_stateid));
        }
    }
}