#r "MyobETL.dll"


using System;
 using MyobETL;

public static void Run(TimerInfo myTimer, TraceWriter log)
{
    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");


    string sqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SqlConnectionString"].ConnectionString;
    string myobClientSecret = System.Configuration.ConfigurationManager.ConnectionStrings["MyobSecretKey"].ConnectionString;
    string myobClientID = System.Configuration.ConfigurationManager.ConnectionStrings["MyobDeveloperKey"].ConnectionString;
    string myobRedirectUrl = System.Configuration.ConfigurationManager.ConnectionStrings["MyobRedirectUrl"].ConnectionString;
    string myobCompanyName = System.Configuration.ConfigurationManager.ConnectionStrings["MyobCompanyName"].ConnectionString;
    string myobComapnyUserName = System.Configuration.ConfigurationManager.ConnectionStrings["MyobComapnyUserName"].ConnectionString;
    string myobComapnyUserPassword = System.Configuration.ConfigurationManager.ConnectionStrings["MyobComapnyUserPassword"].ConnectionString;
  

     MYOB_Data myOB = new MYOB_Data(myobClientID, myobClientSecret, myobRedirectUrl,myobCompanyName,myobComapnyUserName
                                    ,myobComapnyUserPassword,sqlConnectionString );
      myOB.ProcessETL();
}
