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

        public void SortEmployeeData(List<string> data, string dateTimeFormat)
        {
            for (int i = 0; i < data.Count; i += 4)
            {
                int employeeId = int.Parse(data[i]);
                int projectId = int.Parse(data[i + 1]);
                DateTime dateFrom = ParseDate(data[i + 2], dateTimeFormat);
                DateTime dateTo;

                if (data[i + 3].ToLower() == "null" || String.IsNullOrEmpty(data[i + 3]))
                {
                    dateTo = ParseDate(DateTime.Now.ToString(), dateTimeFormat);
                }
                else
                {
                    dateTo = ParseDate(data[i + 3], dateTimeFormat);
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

        public List<EmployeePairResult> FindEmployeePair()
        {
            List<EmployeePairResult> pairResult = new List<EmployeePairResult>();

            foreach (var project in Projects)
            {
                project.FindPairs();

                foreach (var pair in project.EmployeePairs)
                {
                    if (pairResult.Any(x => x.ProjectId == pair.ProjectId))
                    {
                        if (pairResult.Any(x => x.EmployeeId1 == pair.EmployeeId1 && x.EmployeeId2 == pair.EmployeeId2))
                        {
                            pairResult.Where(x => x.EmployeeId1 == pair.EmployeeId1 && x.EmployeeId2 == pair.EmployeeId2).FirstOrDefault().DaysWorked += pair.DaysWorked;
                        }
                        else
                        {
                            pairResult.Add(pair);
                        }
                    }
                    else
                    {
                        pairResult.Add(pair);
                    }
                }
            }

            EmployeePairResult winningPairr = pairResult.OrderByDescending(x => x.DaysWorked).FirstOrDefault();

            pairResult.Clear();

            if (winningPairr != null)
            {
                int id1 = winningPairr.EmployeeId1;
                int id2 = winningPairr.EmployeeId2;

                foreach (var project in Projects) 
                {
                    if (project.EmployeePairs.Any(x => x.EmployeeId1 == id1 && x.EmployeeId2 == id2))
                    {
                        pairResult.Add(project.EmployeePairs.Where(x => x.EmployeeId1 == id1 && x.EmployeeId2 == id2).FirstOrDefault());
                    }                    
                }
            }            

            return pairResult;
        }

        private DateTime ParseDate(string date, string dateTimeFormat)
        {
            DateTime parsedDate;

            if (dateTimeFormat == "Auto")
            {
                parsedDate = DateTime.Parse(date);
            }
            else
            {
                if (DateTime.TryParseExact(date, dateTimeFormat, null, System.Globalization.DateTimeStyles.None, out DateTime result))
                {
                    parsedDate = result;
                }
                else
                {
                    throw new Exception("Incorrect Date format!");
                }
            }

            return parsedDate;
        }
    }
}
