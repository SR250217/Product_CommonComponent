using System.Collections.Generic;
using Dodos.UI.Models;
namespace Dodos.UI.Repositories {

public interface ICities
{
    HashSet<CitiesModel> getCities(int stid);
}
}