using Service.Contracts.Interfaces;

namespace Contracts.Interfaces
{
    public interface IServiceManager
    {
        ICompanyService CompanyService { get; }
        IEmployeeService EmployeeService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
