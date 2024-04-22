namespace CompanyManagement.Core.Dtos.Response
{
    public class DepartmentResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<EmployeeResponseDto> Employees { get; set; }
    }
}
