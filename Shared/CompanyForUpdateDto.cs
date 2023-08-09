using Shared.DataTransferObjects;

namespace Shared
{
    public record CompanyForUpdateDto : CompanyForManipulationDto
    {
        public IEnumerable<EmployeeForCreationDto>? Employees { get; init; }
    }
}
