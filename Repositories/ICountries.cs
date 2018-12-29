using System.Collections.Generic;
using Dodos.UI.Models;
namespace Dodos.UI.Repositories{

public interface ICountries
{
    HashSet<CountriesModel> getCountries();
}
}