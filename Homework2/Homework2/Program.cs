using Homework2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = findOpenData();
            showOpenData(nodes);
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }

        static List<OpenData> findOpenData()
        {
            List<OpenData> result = new List<OpenData>();

            var xml = XElement.Load(@"App_Data\water.xml.xml");
            //var nodes = xml.Descendants("LiyutanReservoirDailyWaterInformation").ToList();
            List<XElement> nodes = xml.Descendants("LiyutanReservoirDailyWaterInformation").ToList();

            for (var i = 0; i < nodes.Count; i++)
            {
                var node = nodes[i];

                string string1 = node.Element("Date")?.Value?.Trim();
                string string2 = node.Element("ReservoirName")?.Value?.Trim();
                string string3 = node.Element("WaterLevel")?.Value?.Trim();
                string string4 = node.Element("WaterStorageRate")?.Value?.Trim();

                OpenData item = new OpenData();

                item.Date = getValue(node, "Date");
                item.ReservoirName = getValue(node, "ReservoirName");
                item.WaterLevel = getValue(node, "WaterLevel");
                item.WaterStorageRate = getValue(node, "WaterStorageRate");

                result.Add(item);
            }

            private static string getValue(XElement node, string propertyName)
            {
                return node.Element(propertyName)?.Value?.Trim();
            }

            private static void showOpenData(List<OpenData> nodes)
            {
                Console.WriteLine(string.Format("共收到{0}筆的資料", nodes.Count));
                //nodes.GroupBy(node => node.分類).ToList()
                //    .ForEach(group =>
                //    {
                //        var key = group.Key;
                //        var groupDatas = group.ToList();
                //        var message = $"分類:{key},共有{groupDatas.Count()}筆資料";
                //        Console.WriteLine(message);
                //    });
                nodes.ToList()
                    .ForEach(node =>
                    {
                        var message = $"服務:{ node.ReservoirName}";
                        Console.WriteLine(message);
                    });
                Console.WriteLine($"共:{nodes.Count}筆");
            }
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
