using NReco.PivotData;
using NReco.PivotData.Output;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.Json;

namespace csharp_pivot_sample
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("CSharp Pivot Table Sample");
      var list = new List<Hashtable>();
      list = JsonSerializer.Deserialize<List<Hashtable>>(ReadAllLine("data.json", "utf-8"));

      var dt = new DataTable("hogehoge");

      foreach (var key in list[0].Keys)
      {
        dt.Columns.Add(key.ToString());
      }

      foreach (var row in list)
      {
        var dr = dt.NewRow();
        foreach (var key in row.Keys)
        {
          dr[key.ToString()] = row[key];
        }
        dt.Rows.Add(dr);
      }

      PrintTable(dt);

      var pivotData = new PivotData(
          new string[] { "AGE_KBN_NAME", "HEADER" },
          new SumAggregatorFactory("MED_EXPENSE_SUM"),
          new DataTableReader(dt));
      var pivot = new PivotTable(
          new[] { "AGE_KBN_NAME" },
          new[] { "HEADER" },
          pivotData);
      var pvWr = new PivotTableDataTableWriter("pivot");
      PrintTable(pvWr.Write(pivot));

    }

    private static string ReadAllLine(string filePath, string encodingName)
    {
      var sr = new StreamReader(filePath, Encoding.GetEncoding(encodingName));
      string allLine = sr.ReadToEnd();
      sr.Close();

      return allLine;
    }

    private static void PrintTable(DataTable dt)
    {
      Console.Write("|");
      for (int i = 0; i < dt.Columns.Count; i++)
      {
        Console.Write(dt.Columns[i].ColumnName + "|");
      }
      Console.WriteLine("");
      foreach (DataRow dr in dt.Rows)
      {
        Console.Write("|");
        for (int i = 0; i < dr.ItemArray.Length; i++)
        {
          Console.Write(dr[i].ToString() + "|");
        }
        Console.WriteLine("");
      }
      Console.WriteLine("");
    }
  }

}
