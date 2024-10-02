using util.query;

namespace util {
  public static class QueryParser {
    /// <summary>
    /// 문자열 쿼리를 분해하여 key - value 형태로 정리한다.
    /// </summary>
    /// <param name="queryString">쿼리 문자열. key1[:(asc|desc)];key2[:(asc|desc)] 꼴로 표현</param>
    /// <returns></returns>
    public static Dictionary<string, SortOrder> Parse (string queryString) {
      var entries = new Dictionary<string, SortOrder>();

      var queryItems = queryString.Split(";",StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

      foreach(var query in queryItems) {
        var values = query.Split(":", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        // 쿼리는 key:asc 꼴 또는 key 형태로 나타나야 한다.
        if(values.Length <= 0 || values.Length > 2) continue;

        var key = values[0].ToLower();
        SortOrder sort;

        // key만 지정되면 ASC
        if(values.Length == 1) sort = SortOrder.ASC;
        else {
          var sortStr = values[1].ToLower();
         
          if(sortStr == "asc") sort = SortOrder.ASC;
          else if (sortStr == "desc") sort = SortOrder.DESC;
          // sort 규칙에 asc / desc가 아닌 다른 값이 들어오면 무시
          else continue;
        }

        entries.Add(key, sort);
      }

      return entries;
    }
  }
}