using Microsoft.VisualBasic.FileIO;

namespace PairOfEmployees
{
    public static class CsvFileReader
    {
        public static List<string> ReadCsvFile(string filePath)
        {
            List<string> data = new List<string>();
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    foreach (string field in fields)
                    {
                        data.Add(field);
                    }
                }
            }

            return data;
        }
    }
}
