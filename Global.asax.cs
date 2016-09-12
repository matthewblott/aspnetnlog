using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using static NLog.LogManager;

namespace aspnetnlog
{
  public class Global : HttpApplication
  {
    protected void Application_Start()
    {
      var logger = GetCurrentClassLogger();

      logger.Info("Initialisation started - logged via Global");

      Helper.Log("Initialisation started - logged via Helper");

      AreaRegistration.RegisterAllAreas();
      RouteConfig.RegisterRoutes(RouteTable.Routes);

      logger.Info("Initialisation completed - logged via Global");

      Helper.Log("Initialisation completed - logged via Helper");

    }

  }

}
