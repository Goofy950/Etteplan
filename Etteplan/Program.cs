using System.Xml.Linq;

//Path till Xml filen @"C:\....
var xml = XDocument.Load(@"C:\");
var query = from c in xml.Descendants("trans-unit")
            where (string)c.Attribute("id") == "42007"
            select c.Element("target").Value;
            

//Path till vart txt filen skall sparas C:\.....\Text.txt <-- annars skapas inte filen med StreamWriter, namnet kvittar
var report = @"C:\";
StreamWriter sw = new StreamWriter(report);
sw.WriteLine(query.FirstOrDefault());
sw.Close();
Console.WriteLine("saving");
Console.ReadLine();


