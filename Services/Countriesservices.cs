using Dodos.UI.Repositories;
//using Dodos.UI.Repositories.Imp;
using System.Collections.Generic;
using Dodos.UI.Models;

namespace Dodos.UI.Services {
    public class Countriesservices {
        private  ICountries countriesObj;

        public Countriesservices(ICountries iCountries)
        {
            countriesObj= iCountries;

        }
        public HashSet<CountriesModel> getCountries(){
           return countriesObj.getCountries();
        }
    }
}