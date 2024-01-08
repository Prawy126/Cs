using CsvHelper;
using lab7;
using System.Globalization;


string filePath = "sample.csv";

WriteDataToCsv(filePath);

SearchDataInCSV(filePath, "John");

Console.WriteLine();

static void WriteDataToCsv(string filePath)
{
    List<Person> people = new ;
}