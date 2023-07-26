// See https://aka.ms/new-console-template for more information
using BuilderDesignPattern;

Console.WriteLine("Hello, World!");

Report report;
ReportDirector reportDirector = new ReportDirector();
// Construct and display Reports
// PDFReport pdfReport = new PDFReport();
// report = reportDirector.MakeReport(pdfReport);
// report.DisplayReport();
// Console.WriteLine("-------------------");
// ExcelReport excelReport = new ExcelReport();
// report = reportDirector.MakeReport(excelReport);
// report.DisplayReport();

// Console.ReadKey();

Beverage beverage;
BeverageDirector beverageDirector = new BeverageDirector();

TeaBuilder tea = new TeaBuilder();
beverage = beverageDirector.MakeBeverage(tea);
Console.WriteLine(beverage.ShowBeverage());
CoffeeBuilder coffee = new CoffeeBuilder();
beverage = beverageDirector.MakeBeverage(coffee);
Console.WriteLine(beverage.ShowBeverage());
Console.ReadKey();
