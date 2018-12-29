using Dodos.UI.Models;
using System;
namespace Dodos.UI.Repositories
{
    public interface ICommon_Connection
    {
        Common_ConnectionModel getconnectiondetails (string pcode);
        
    }
}