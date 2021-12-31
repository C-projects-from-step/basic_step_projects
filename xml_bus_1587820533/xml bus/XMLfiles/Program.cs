using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
namespace XMLfiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Bus bus1 = new Bus { Brand = "Mersedes", Color = ConsoleColor.Black, NumPas = 18, YearofCreation = DateTime.Parse("6.08.2014"), Conditioner = true };
            Bus bus2 = new Bus { Brand = "BAZ", Color = ConsoleColor.Blue, NumPas = 20, YearofCreation = DateTime.Parse("11.03.2010"), Conditioner = false };
            Bus bus3 = new Bus { Brand = "Ral", Color = ConsoleColor.Cyan, NumPas = 25, YearofCreation = DateTime.Parse("21.03.2004"), Conditioner = true };
            Bus bus4 = new Bus { Brand = "Audi", Color = ConsoleColor.DarkBlue, NumPas = 60, YearofCreation = DateTime.Parse("21.04.2000"), Conditioner = false };
            Bus bus5 = new Bus { Brand = "Lada", Color = ConsoleColor.Green, NumPas = 50, YearofCreation = DateTime.Parse("26.01.2020"), Conditioner = true };
            List<Bus> garage = new List<Bus> { bus1, bus2, bus3, bus4, bus5 };

            try
            {
                //  WriteDoc(garage);
                // WritebyTextWriter(garage);


                // List<Bus> f = ReadbyTextReader("Bus.xml");
                //  List<Bus> f = ReadbyTextReader("DocBus.xml");
                // List<Bus> f = ReadDoc("DocBus.xml");
                List<Bus> f = ReadDoc("Bus.xml");

                foreach (var item in f)
                {
                    Console.WriteLine(item.Brand);
                    Console.WriteLine(item.Color);
                    Console.WriteLine(item.NumPas);
                    Console.WriteLine(item.YearofCreation.ToShortDateString());
                    Console.WriteLine(item.Conditioner);
                    Console.WriteLine();
                }
            }
            catch (Exception m)
            {

                Console.WriteLine(m.Message);
            }
           

           
        }
        static void WritebyTextWriter(List<Bus> m)
        {
            // XmlTextWriter
            var rand = new Random();
            XmlTextWriter xw = null;
            using (xw = new XmlTextWriter("Bus.xml", Encoding.Unicode))
            {
                xw.Formatting = Formatting.Indented;
                xw.Indentation = 4;
                xw.WriteStartDocument();
                xw.WriteStartElement("Garage");
                int i = 0;
                foreach (var bus in m)
                {
                    xw.WriteStartElement("Bus_" + (i++ + 1).ToString());
                    xw.WriteAttributeString("Brand", bus.Brand);
                    xw.WriteAttributeString("Color", bus.Color.ToString());
                    xw.WriteElementString("NumPas", bus.NumPas.ToString());
                    xw.WriteElementString("Year_of_Creation", bus.YearofCreation.ToString("d"));
                    xw.WriteElementString("Conditioner", bus.Conditioner.ToString());
                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
            }
        }

        static List<Bus> ReadbyTextReader(string df)
        {
            List<Bus> tmp = new List<Bus>();
            XmlTextReader xr = null;

            using (xr = new XmlTextReader(df))
            {
                xr.WhitespaceHandling = WhitespaceHandling.None;
                Bus bus = new Bus();
                while (xr.Read())
                {
                    if (bus.NumPas != 0)
                    {
                        tmp.Add(bus);
                        bus = new Bus();
                    }

                    while (xr.MoveToNextAttribute())
                    {
                        if (xr.Name == "Brand")
                        {
                            bus.Brand = xr.Value;
                        }
                        if (xr.Name == "Color")
                        {
                            string strp = xr.Value;
                            bus.Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), strp);
                        }
                    }


                    if (xr.NodeType == XmlNodeType.Element)
                    {
                        if (xr.Name == "NumPas")
                        {
                            bus.NumPas = xr.ReadElementContentAsInt();
                        }
                        if (xr.Name == "Year_of_Creation")
                        {

                            DateTime m = DateTime.Parse(xr.ReadElementContentAsString());
                            bus.YearofCreation = m;
                        }
                        if (xr.Name == "Conditioner")
                        {
                            bool f = bool.Parse(xr.ReadElementContentAsString());
                            bus.Conditioner = f;
                        }
                    }
                }
            }
            return tmp;
        }

        static void WriteDoc(List<Bus> m)
        {
            // XmlDocument Save
            var rand = new Random();
            XmlDocument xd = new XmlDocument();

            XmlDeclaration xmlDeclaration = xd.CreateXmlDeclaration("1.0", "utf-16", null);
            XmlElement root = xd.DocumentElement;
            xd.InsertBefore(xmlDeclaration, root);
            XmlElement elements = xd.CreateElement("garage");
            xd.AppendChild(elements);
            int n = 1;
            foreach (var bus in m)
            {
                XmlElement el = xd.CreateElement("Bus_" + (n++).ToString());
                XmlAttribute tmp = xd.CreateAttribute("Brand");
                tmp.Value = bus.Brand;
                el.Attributes.Append(tmp);

                XmlAttribute brand = xd.CreateAttribute("Color");
                brand.Value = bus.Color.ToString();
                el.Attributes.Append(brand);

                XmlElement ch = xd.CreateElement("NumPas");
                XmlText text = xd.CreateTextNode(bus.NumPas.ToString());
                ch.AppendChild(text);

                XmlElement ch1 = xd.CreateElement("Year_of_Creation");
                XmlText text1 = xd.CreateTextNode(bus.YearofCreation.ToString("d"));
                ch1.AppendChild(text1);

                XmlElement ch2 = xd.CreateElement("Conditioner");
                XmlText text2 = xd.CreateTextNode(bus.Conditioner.ToString());
                ch2.AppendChild(text2);


                el.AppendChild(ch);
                el.AppendChild(ch1);
                el.AppendChild(ch2);

                elements.AppendChild(el);

            }

            xd.Save("DocBus.xml");
        }

        static List<Bus> ReadDoc(string file)
        {
            XmlDocument xd = new XmlDocument();
            List<Bus> tmp = new List<Bus>();
            Bus bus = new Bus();

            xd.Load(file);
            PrintNode(xd, tmp, bus);

            //while (xd.HasChildNodes)
            //{
            //    if (bus.Brand != null)
            //    {
            //        tmp.Add(bus);
            //        bus = new Bus();
            //    }

            //    if (xd.Attributes != null)
            //    {
            //        foreach (XmlAttribute at in xd.Attributes)
            //        {
            //            if (at.Name == "Brand")
            //                bus.Brand = at.Value;
            //            if (at.Name == "Color")
            //            {
            //                string strp = at.Value;
            //                bus.Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), strp);
            //            }
            //        }
            //    }

            //    if (xd.NodeType == XmlNodeType.Element)
            //    {
            //        if (xd.Name == "NumPas")
            //        {
            //            bus.NumPas = xd.Value;
            //        }
            //        if (xd.Name == "Year_of_Creation")
            //        {

            //            DateTime m = DateTime.Parse(xd.ReadElementContentAsString());
            //            bus.YearofCreation = m;
            //        }
            //        if (xd.Name == "Conditioner")
            //        {
            //            bool f = bool.Parse(xd.ReadElementContentAsString());
            //            bus.Conditioner = f;
            //        }

            // }



            // Console.WriteLine($"Node: Type={node.NodeType}\tName={node.Name}\tValue={node.Value}");
            //if (node.Attributes != null)
            //{
            //    foreach (XmlAttribute attr in node.Attributes)
            //    {
            //        Console.WriteLine($"Attribute: Type={attr.NodeType}\tName={attr.Name}\tValue={attr.Value}");
            //    }
            //}

            //if (node.HasChildNodes)
            //{
            //    foreach (XmlNode child in node.ChildNodes)
            //    {
            //        PrintNode(child);
            //    }
            //}



            return tmp;
        }

        static void PrintNode(XmlNode node, List<Bus> tmp, Bus bus)
        {
            if (node.Attributes != null)
            {
                foreach (XmlAttribute attr in node.Attributes)
                {
                    if (attr.Name == "Brand")
                        bus.Brand = attr.Value;
                      
                    if (attr.Name == "Color")
                    {
                        bus.Color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), attr.Value);
                    }
                }
            }

            if (node.HasChildNodes)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    if (child.Name == "NumPas")
                    {
                        int.TryParse(child.InnerText, out int m);
                        bus.NumPas = m;                        
                    }
                    else if (child.Name == "Year_of_Creation")
                    {
                        bus.YearofCreation = DateTime.Parse(child.InnerText);
                    }
                    else if (child.Name == "Conditioner")
                    {
                        bus.Conditioner = bool.Parse(child.InnerText);
                        tmp.Add(bus);

                    }
                }
            }

            if (node.HasChildNodes)
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    PrintNode(child, tmp, bus);
                }
            }
        }
    }
}
