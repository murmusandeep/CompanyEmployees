using Shared.DataTransferObjects;

namespace Shared
{
    public record CompanyForCreationDto : CompanyForManipulationDto
    {
        IEnumerable<EmployeeForCreationDto> Employees { get; init; }
    }
}
