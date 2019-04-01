using System;
using System.Xml;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("water.xml");

            while (reader.Read())
            {
                Console.WriteLine(reader.Name);
            }
            Console.ReadLine();

            //Console.WriteLine("Hello World!");
        }

        














        //試3
        //public static object MessageBox { get; private set; }

        //static void Main(string[] args)
        //{
        //    XmlDocument document = new XmlDocument();
        //    document.LoadXml("water.xml");

        //    XmlNode node_status = document.SelectSingleNode("/HydrologyReservoirClass/LiyutanReservoirDailyWaterInformation/Date");

        //    MessageBox.show("node_status");
        //}

        //試2
        //public void ImportData(string xmlData, ConnectionStringSettings connectionSettings)
        //{
        //    DbProviderFactory providerFactory = DbProviderFactories.GetFactory(connectionSettings.ProviderName);
        //    IDbConnection connection = providerFactory.CreateConnection();
        //    connection.ConnectionString = connectionSettings.ConnectionString;

        //    XmlDocument document = new XmlDocument();
        //    document.LoadXml("water.xml");
        //}

        //試1
        //private FileNotFoundException(string message)
        //{
        //    FileStream fileStream = File.OpenRead("112.xml");
        //    StreamReader streamReader = new StreamReader(fileStream);
        //    string xmldata = streamReader.ReadToEnd();
        //    XmlDocument Document = new XmlDocument();
        //    Document.Load(xmldata);
        //    Console.ReadLine();
        //}
    }
}
