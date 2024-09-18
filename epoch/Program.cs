// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int seconds = 1726531205;
int oneyear = 31556926;
int years = seconds / oneyear;
int rest = seconds % oneyear;
int oneday = 86400;
int days = rest / oneday;

Console.WriteLine(years);
Console.WriteLine(rest);
Console.WriteLine(years + " " + days);