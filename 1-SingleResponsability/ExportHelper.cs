using System.Collections;
using System.Text;

namespace SingleResponsibility
{
  public class ExportHelper<T>
  {
    public void ExportToCSV(IEnumerable<T> items)
    {
      StringBuilder sb = new();
      string header = "";
      string[] dataRows = new string[items.Count()];
      foreach (var prop in typeof(T).GetProperties())
      {
        header += $"{prop.Name};";
        for (int i = 0; i < items.Count(); i++)
        {
          var propValue = prop.GetValue(items.ToArray()[i]);
          var propType = propValue.GetType();

          if (propType.Name != nameof(String)
              && propType.GetInterface(nameof(IEnumerable)) != null)
          {
            dataRows[i] += $"{string.Join("|", (propValue as IEnumerable).Cast<object>().Select(x => x.ToString()))};";

          }
          else
          {
            dataRows[i] += $"{propValue};";
          }
        }
      }
      sb.AppendLine(header.Trim(';'));
      foreach (var dataRow in dataRows)
      {
        sb.AppendLine(dataRow.Trim(';'));
      }
      File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Export_{typeof(T)}.csv"), sb.ToString(), Encoding.Unicode);
    }
  }
}