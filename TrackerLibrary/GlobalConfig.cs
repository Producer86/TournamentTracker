using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  public static class GlobalConfig
  {
    public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

    public static void InitializeConnections(bool database, bool textFiles)
    {
      if (database)
      {
        // TODO - Set up SqlConnector properly.
        SqlConnector sqlConnector = new SqlConnector();
        Connections.Add(sqlConnector);
      }

      if (textFiles)
      {
        // TODO - Set up TextConnector properly.
        TextConnector textConnector = new TextConnector();
        Connections.Add(textConnector);
      }
    }
  }
}
