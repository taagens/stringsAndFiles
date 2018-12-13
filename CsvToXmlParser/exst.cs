using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToXmlParser
{
    class exst
    {
        static string[] csvSeparator = new string[] { "," };
        internal static DataTable LoadCSV(string csv_file_path, string[] commentTokens = null)
        {
            DataTable csvData = null;
           
            try
            {
                csvData = new DataTable();
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(csvSeparator);
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    csvReader.TrimWhiteSpace = true;
                    if (commentTokens != null)
                        csvReader.CommentTokens = commentTokens;
               
                    for (int i = 0; i < 144; i++)
                            csvData.Columns.Add();

                    csvData.Rows.Add(csvReader.ReadFields());
                                     
                    DataTable rt = csvData;
                    csvData = null;
                    return rt;
                }
            }
            finally
            {
                if (csvData != null)
                {
                    csvData.Dispose();
                    csvData = null;
                }
            }
        }

       
    }
}
