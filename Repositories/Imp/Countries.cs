using System.Linq;
using System.Collections.Generic;
using Dodos.UI.Models;

namespace Dodos.UI.Repositories.Imp
{
    public class CountriesImp : ICountries
    {
        private readonly MyBackupBloggingContext dbcontext;
        public CountriesImp(MyBackupBloggingContext dbcontext)
        {
            this.dbcontext = dbcontext;

        }

        public HashSet<CountriesModel> getCountries()
        {
            return new HashSet<CountriesModel>(this.dbcontext.tblCountries.Where(x => x.cstatus == true));
        }
    }
}