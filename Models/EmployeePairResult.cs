namespace PairOfEmployees.Models
{
    public class EmployeePairResult
    {
        public int EmployeeId1 { get; set; }
        public int EmployeeId2 { get; set; }
        public int ProjectId { get; set; }
        public int DaysWorked { get; set; }

        public EmployeePairResult(int id1, int id2, int projectId, int days)
        {
            EmployeeId1 = id1;
            EmployeeId2 = id2;
            ProjectId = projectId;
            DaysWorked = days;
        }
    }
}
