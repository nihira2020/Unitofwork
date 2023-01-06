using Unitofwork.Interface;

namespace Unitofwork.Controllers
{
    public interface IUnitofWork
    {
        ICustomerrepo customerrepo { get;}

        Task CompleteAsync();
    }
}
