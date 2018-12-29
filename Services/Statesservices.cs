using Dodos.UI.Repositories;
using System.Collections.Generic;
using Dodos.UI.Models;

namespace Dodos.UI.Services
{
    public class Statesservices
    {
        private IStates statesObj;

        public Statesservices(IStates istates)
        {
            statesObj = istates;

        }
        public HashSet<StatesModel> getStates(int cntryid)
        {
            return statesObj.getStates(cntryid);
        }
    }
}