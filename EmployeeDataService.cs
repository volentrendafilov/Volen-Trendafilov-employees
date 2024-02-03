using PairOfEmployees.Models;

namespace PairOfEmployees
{
    public class EmployeeDataService
    {
        public List<Project> Projects { get; set; }

        public EmployeeDataService()
        {
            Projects = new List<Project>();
        }

        public void SortEmployeeData(List<string> data)
        {
            for (int i = 0; i < data.Count; i += 4)
            {
                int employeeId = int.Parse(data[i]);
                int projectId = int.Parse(data[i + 1]);
                DateTime dateFrom = DateTime.Parse(data[i + 2]);
                DateTime dateTo;

                if (data[i + 3].ToLower() == "null" || String.IsNullOrEmpty(data[i + 3]))
                {
                    dateTo = DateTime.Now;
                }
                else
                {
                    dateTo = DateTime.Parse(data[i + 3]);
                }

                Employee employee = new Employee(employeeId, projectId, dateFrom, dateTo);

                if (Projects.Any(x => x.ProjectId == projectId))
                {
                    Projects.Where(x => x.ProjectId == projectId).FirstOrDefault().Employees.Add(employee);
                }
                else
                {
                    Project project = new Project(projectId);
                    project.Employees.Add(employee);
                    Projects.Add(project);
                }
            }

            var test = Projects;
        }

        public List<EmployeePairResult> FindEmployeePairs()
        {
            List<EmployeePairResult> pairs = new List<EmployeePairResult>();

            foreach (var project in Projects)
            {
                project.FindPair();

                if (project.EmployeePair != null)
                {
                    pairs.Add(project.EmployeePair);
                }
            }

            return pairs;
        }
    }
}
