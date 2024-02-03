using PairOfEmployees.Models;

namespace PairOfEmployees
{
    public partial class Form1 : Form
    {
        private string CsvFilePath { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a file";
                openFileDialog.Filter = "CSV files (*.csv)|*.csv";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    filePathTextBox.Text = filePath;
                    CsvFilePath = filePath;
                }
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {            
            try
            {
                List<string> data = CsvFileReader.ReadCsvFile(CsvFilePath);

                EmployeeDataService dataService = new EmployeeDataService();
                dataService.SortEmployeeData(data.Skip(4).ToList());
                List<EmployeePairResult> pairs = dataService.FindEmployeePairs();

                dataGridView1.DataSource = pairs;

                if (pairs.Count == 0)
                {
                    MessageBox.Show("There were no pair matches", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Job ready!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
