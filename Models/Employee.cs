namespace PairOfEmployees.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int ProjectId { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int DaysWorkedOnProject { get; set; }

        public Employee(int employeeId, int projectId, DateTime from, DateTime to)
        {
            EmployeeId = employeeId;
            ProjectId = projectId;
            DateFrom = from;
            DateTo = to;
        }
    }
}
