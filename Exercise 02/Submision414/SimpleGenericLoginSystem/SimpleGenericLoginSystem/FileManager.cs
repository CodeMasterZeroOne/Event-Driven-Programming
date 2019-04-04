using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleGenericLoginSystem
{
    /// <summary>
    /// File mamnager sealed singleton class used to read from csv file
    /// </summary>
    sealed class FileManager
    {
        private static FileManager fileManager;
        private static readonly string dataFile = "p_words.csv";

        private FileManager()
        {

        }
        /// <summary>
        /// Public method to get access to file manager
        /// </summary>
        /// <returns>FileManager</returns>
        public static FileManager getFileManager()
        {
            if(fileManager == null)
            {
                fileManager = new FileManager();
            }
            return fileManager;
        }
        /// <summary>
        /// Public method for loading data table
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable LoadData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                StreamReader streamReader = new StreamReader(dataFile);
                string[] headers = streamReader.ReadLine().Split(',');
                
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header);
                }
                while (!streamReader.EndOfStream)
                {
                    string[] rows = Regex.Split(streamReader.ReadLine(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dataRow[i] = rows[i];
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.StackTrace);
            }
            
            return dataTable;
        }
        /// <summary>
        /// Public method for saving data
        /// </summary>
        /// <param name="dataTable"></param>
        public void SaveData(DataTable dataTable)
        {
            StringBuilder stringBuilder = new StringBuilder();

            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            stringBuilder.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dataTable.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                //IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                stringBuilder.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(dataFile, stringBuilder.ToString());
        }
    }
}