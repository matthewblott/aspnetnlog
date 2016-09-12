using static NLog.LogManager;

public static class Helper
{
  public static void Log(string message)
  {
    var logger = GetCurrentClassLogger();

    logger.Info(message);


    //var environmentConnectionString = Environment.GetEnvironmentVariable("MyDbConnection", EnvironmentVariableTarget.User);

    //connectionString = !string.IsNullOrEmpty(environmentConnectionString)
    //                        ? environmentConnectionString
    //                        : ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

    //var logger = NLog.LogManager.GetCurrentClassLogger();

    //var anotherLogger = NLog.LogManager.GetLogger("name", typeof(Helper));

    //NLog.LogLevel level;

    //level = NLog.LogLevel.Debug;

    //var message = "we have an error";

    //logger.Log(level, message);


  }

}