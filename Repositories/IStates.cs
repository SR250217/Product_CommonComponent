using System.Collections.Generic;
using Dodos.UI.Models;
namespace Dodos.UI.Repositories {

public interface IStates
{
    HashSet<StatesModel> getStates(int cntryid);
}
}