using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockPortfolioManager.Data.Repository
{
  public static class Util
  {
    public static IQueryable<T> Paged<T>(this IQueryable<T> source, int pageIndex, int pageSize, out int TotalPages)
    {
      int TotalCount = source.Count();
      TotalPages = (int)Math.Ceiling(TotalCount / (double)pageSize);

      return source.Skip((pageIndex * pageSize) - pageSize).Take(pageSize);
    }

    public static string FixUpSqlEnding(this string source, IList<string> EndWith)
    {
      for (int i = 0; i < EndWith.Count; i++)
      {
        if (source.Trim().EndsWith(EndWith[i]))
        {
          source = source.Remove(source.Length - EndWith[i].Length, EndWith[i].Length);
        }
      }

      return string.Concat(source.Trim(), ";");
    }

    public static StringBuilder FixUpSqlEnding(this StringBuilder source, IList<string> EndWith)
    {
      for (int i = 0; i < EndWith.Count; i++)
      {
        if (source.ToString().Trim().EndsWith(EndWith[i]))
        {
          source.Remove(source.Length - (EndWith[i].Length + 2), EndWith[i].Length);
        }
      }
      return source.Append(";");
    }
  }
}
