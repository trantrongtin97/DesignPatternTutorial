using DesignPattern.Object;

namespace DesignPattern.FactoryDesignPattern.BuilderDesignPattern
{
    public class ExampleBuilderDesignPattern
    {
        public void Run()
        {
            PDFReport pdfReport = new PDFReport();
            ReportManager reportManager = new ReportManager();
            Report report = reportManager.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportManager.MakeReport(excelReport);
            report.DisplayReport();
        }
    }
}
