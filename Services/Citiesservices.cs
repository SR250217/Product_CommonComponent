using Dodos.UI.Repositories;
using System.Collections.Generic;
using Dodos.UI.Models;

namespace Dodos.UI.Services
{
    public class Citiesservices
    {
        private ICities citiesObj;

        public Citiesservices(ICities icities)
        {
            citiesObj = icities;

        }
        public HashSet<CitiesModel> getCities(int stid)
        {
            return citiesObj.getCities(stid);
        }
    }
}