//using UnityEngine;
//using System.Collections.Generic;
//using System.IO;
//using NPOI.HSSF.UserModel;
//using NPOI.SS.UserModel;
//using NPOI.XSSF.UserModel;
//using System.Data.SQLite;

//public class ExcelImporter : MonoBehaviour
//{
//    public string excelFilePath; // Excel文件路径
//    public string databaseFilePath; // SQLite数据库文件路径
//    public string tableName; // 数据库表名

//    void Start()
//    {
//        // 读取Excel文件
//        IWorkbook workbook;
//        using (FileStream stream = new FileStream(excelFilePath, FileMode.Open, FileAccess.Read))
//        {
//            if (Path.GetExtension(excelFilePath) == ".xls")
//            {
//                workbook = new HSSFWorkbook(stream);
//            }
//            else
//            {
//                workbook = new XSSFWorkbook(stream);
//            }
//        }

//        // 获取第一个工作表
//        ISheet sheet = workbook.GetSheetAt(0);

//        // 获取字段名
//        IRow headerRow = sheet.GetRow(1);
//        List<string> fieldNames = new List<string>();
//        for (int i = 0; i < headerRow.LastCellNum; i++)
//        {
//            fieldNames.Add(headerRow.GetCell(i).ToString());
//        }

//        // 创建数据库表
//        using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + databaseFilePath))
//        {
//            connection.Open();

//            using (SQLiteCommand command = new SQLiteCommand(connection))
//            {
//                command.CommandText = "CREATE TABLE " + tableName + " (" + string.Join(", ", fieldNames.ToArray()) + ")";
//                command.ExecuteNonQuery();
//            }
//        }

//        // 导入数据
//        using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + databaseFilePath))
//        {
//            connection.Open();

//            using (SQLiteCommand command = new SQLiteCommand(connection))
//            {
//                for (int i = 2; i <= sheet.LastRowNum; i++)
//                {
//                    IRow row = sheet.GetRow(i);

//                    if (row != null)
//                    {
//                        List<string> values = new List<string>();
//                        for (int j = 0; j < row.LastCellNum; j++)
//                        {
//                            values.Add("'" + row.GetCell(j).ToString() + "'");
//                        }

//                        command.CommandText = "INSERT INTO " + tableName + " (" + string.Join(", ", fieldNames.ToArray()) + ") VALUES (" + string.Join(", ", values.ToArray()) + ")";
//                        command.ExecuteNonQuery();
//                    }
//                }
//            }
//        }

//        Debug.Log("Import completed!");
//    }
//}
