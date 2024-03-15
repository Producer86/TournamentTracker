using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
  public static class GlobalConfig
  {
    public static IDataConnection Connection { get; private set; }

    public static void InitializeConnections(DatabaseType connectionType)
    {
      switch (connectionType)
      {
        case DatabaseType.Sql:
          SqlConnector sqlConnector = new SqlConnector();
          Connection = sqlConnector;
          break;
        case DatabaseType.Text:
          TextConnector textConnector = new TextConnector();
          Connection = textConnector;
          break;
      }
    }

    public static string CnnString(string name)
    {
      return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
  }
}
