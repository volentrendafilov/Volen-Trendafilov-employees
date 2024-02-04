namespace PairOfEmployees.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public List<Employee> Employees { get; set; }
        public List<EmployeePairResult> EmployeePairs { get; set; }

        public Project(int projectId)
        {
            ProjectId = projectId;
            Employees = new List<Employee>();
            EmployeePairs = new List<EmployeePairResult>();
        }

        public void FindPairs()
        {
            if (Employees.Count >= 2)
            {
                for (int i = 0; i < Employees.Count - 1; i++)
                {
                    int daysWorkedOnProject = 0;

                    Employee employee1 = Employees[i];
                    Employee employee2 = Employees[i + 1];                   

                    if (employee1.EmployeeId != employee2.EmployeeId &&
                        employee1.DateTo > employee2.DateFrom &&
                        employee2.DateTo > employee1.DateFrom)
                    {
                        if (employee1.DateTo >= employee2.DateTo)
                        {
                            if (employee1.DateFrom >= employee2.DateFrom)
                            {
                                daysWorkedOnProject = (employee2.DateTo - employee1.DateFrom).Days;
                            }
                            else
                            {
                                daysWorkedOnProject = (employee2.DateTo - employee2.DateFrom).Days;
                            }
                        }
                        else
                        {
                            if (employee1.DateFrom >= employee2.DateFrom)
                            {
                                daysWorkedOnProject = (employee1.DateTo - employee1.DateFrom).Days;
                            }
                            else
                            {
                                daysWorkedOnProject = (employee1.DateTo - employee2.DateFrom).Days;
                            }
                        }
                    }

                    if (EmployeePairs.Any(x => x.EmployeeId1 == employee1.EmployeeId && x.EmployeeId2 == employee2.EmployeeId))
                    {
                        EmployeePairs.Where(x => x.EmployeeId1 == employee1.EmployeeId && x.EmployeeId2 == employee2.EmployeeId).FirstOrDefault().DaysWorked += daysWorkedOnProject;
                    }
                    else
                    {
                        EmployeePairResult employeePair = new EmployeePairResult(employee1.EmployeeId, employee2.EmployeeId, ProjectId, daysWorkedOnProject);
                        EmployeePairs.Add(employeePair);
                    }
                }
            }
        }
    }
}
