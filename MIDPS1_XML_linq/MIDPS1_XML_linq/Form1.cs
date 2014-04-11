using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MIDPS1_XML_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonParsingXML_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/2001ImportConfig.xml");

            XmlElement element = doc.DocumentElement;

            XmlAttributeCollection attr_coll = element.Attributes;
            //attributes of 1st node
            for (int i = 0; i < attr_coll.Count; i++)
            {
                string attr_name = attr_coll[i].Name;
                System.Diagnostics.Debug.WriteLine("attr_name [" +i+"]=" + attr_name);
            }
            //get node from XML
            XmlNodeList elements = doc.SelectNodes("//Element");
            foreach (XmlNode elementInstance in elements)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Version = {2}", 
                    elementInstance.Attributes["ID"] != null ?elementInstance.Attributes["ID"].Value:"No ID attribute",
                    elementInstance.Attributes["Name"] != null ? elementInstance.Attributes["Name"].Value : "No Name attribute",
                    //elementInstance.Attributes["Version"].Value 
                    elementInstance.Attributes["Version"] != null ? elementInstance.Attributes["Version"].Value : "No Version attribute"
                );
            }
        }

        private void buttonXmlReader_Click(object sender, EventArgs e)
        {
            XmlTextReader xmlReader = new XmlTextReader("C:/2001ImportConfig.xml");
            string id = null, name = null;
            while (xmlReader.Read())
            {
                if (xmlReader.Name == "Element")
                {
                    id = xmlReader.GetAttribute("ID");
                }
                else if (xmlReader.Name == "Parameter")
                {
                    name = xmlReader.GetAttribute("Name");
                }
                Console.WriteLine("Element ID = {0}, Parameter Name = {1}",
                    id != null ? id : "No ID attribute",
                    name != null ? name : "No Name attribute");
            }
        }

        private void buttonWriteToXML_Click(object sender, EventArgs e)
        {
            Employee[] employees = new Employee[4];
	        employees[0] = new Employee(1, "David", "Smith", 10000);
	        employees[1] = new Employee(3, "Mark", "Drinkwater", 30000);
	        employees[2] = new Employee(4, "Norah", "Miller", 20000);
	        employees[3] = new Employee(12, "Cecil", "Walker", 120000);

	        using (XmlWriter writer = XmlWriter.Create("c:/employees.xml"))
	        {
	            writer.WriteStartDocument();
	            writer.WriteStartElement("Employees");

	            foreach (Employee employee in employees)
	            {
		        writer.WriteStartElement("Employee");

		        writer.WriteElementString("ID", employee.Id.ToString());
		        writer.WriteElementString("FirstName", employee.FirstName);
		        writer.WriteElementString("LastName", employee.LastName);
		        writer.WriteElementString("Salary", employee.Salary.ToString());

		        writer.WriteEndElement();
	            }

	            writer.WriteEndElement();
	            writer.WriteEndDocument();
	        }
        }

        private void buttonReadXMLWithLinq_Click(object sender, EventArgs e)
        {
            //Load xml
            XDocument xdoc = XDocument.Load("c:/employees.xml");//Linq is working with XDocument!!!!

            //Run query
            var employeeS = from employee in xdoc.Descendants("Employee")
                       select new
                       {
                           //HeaderAttribute = employee.Attribute("name").Value,
                           id = employee.Descendants("ID"),
                           FirstName = employee.Descendants("FirstName"),
                           LastName = employee.Descendants("LastName"),
                           Salary = employee.Descendants("Salary")

                       };

            //Loop through results
            foreach (var employee in employeeS)
            {
                //Console.WriteLine("Header Attribute = {0}",
                  //  employee.HeaderAttribute);
                foreach (var lv2 in employee.id)
                {
                    Console.WriteLine("ID = {0}",                    
                        lv2.Value);
                }
                foreach (var lv2 in employee.FirstName)
                {
                    Console.WriteLine("FirstName = {0}",
                        lv2.Value);
                }
                foreach (var lv2 in employee.LastName)
                {
                    Console.WriteLine("LastName = {0}",                    
                        lv2.Value);
                }
                foreach (var lv2 in employee.Salary)
                {
                    Console.WriteLine("Salary = {0}",
                        lv2.Value);
                }
                
                //result.AppendLine(lv1.Header);
                //foreach (var lv2 in lv1.Children)
                    //result.AppendLine("     " + lv2.Attribute("name").Value);
            }

        }
    }

    class Employee
    {
        int _id;
        string _firstName;
        string _lastName;
        int _salary;

        public Employee(int id, string firstName, string lastName, int salary)
        {
            this._id = id;
            this._firstName = firstName;
            this._lastName = lastName;
            this._salary = salary;
        }

        public int Id { get { return _id; } }
        public string FirstName { get { return _firstName; } }
        public string LastName { get { return _lastName; } }
        public int Salary { get { return _salary; } }
    }

}
