// See https://aka.ms/new-console-template for more information

using AppSettingInConsoleApplication;

var startup = new Startup();
Console.WriteLine(startup.Settings.WelcomeText);
