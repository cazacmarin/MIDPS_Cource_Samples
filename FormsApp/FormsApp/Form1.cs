using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml;

namespace FormsApp
{
    public partial class Form1 : Form
    {
        public static SqlConnection sqlConnection = Utils.prepareConnection(".", "agenda");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSaveAddress_Click(object sender, EventArgs e)
        {
            Utils.Address a = new Utils.Address();
            //SqlConnection sqlConnection = Utils.prepareConnection(".","agenda");
            sqlConnection.Open();
            int maxId = Utils.selectMaxId(sqlConnection, "id_address", "Address");
            string sqlCommand = String.Format("insert into Address values ({0}, '{1}', '{2}', {3})", maxId + 1,textBoxCity.Text,textBoxStreet.Text, comboBoxType.SelectedIndex);
            int affectedRows = Utils.insertSQLCommandIntoTable(sqlConnection,sqlCommand);
            if (affectedRows == 1)
                MessageBox.Show("Insert Successfully completed into table Address");
            else
                MessageBox.Show("Insert was not completed for table Address");
            //clearing Values from Form
            textBoxCity.Text = "";
            textBoxStreet.Text = "";
            comboBoxType.SelectedIndex = -1;
            sqlConnection.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("haha");
            populateAddressTable();
            string select = "select * from agenda.dbo.EMail";
            drowDataGrids(select, dataGridViewEMailAddress);
        }

        private void drowDataGrids(string sqlString, DataGridView dataGridView)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlString, sqlConnection); //c.con is the connection string

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView.ReadOnly = true;
            dataGridView.DataSource = ds.Tables[0];
        }

        public void populateAddressTable()
        {
            string select = "select * from agenda.dbo.Address";
            drowDataGrids(select, dataGridViewAddress);
        }

        private void buttonDeleteAddress_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddress.SelectedRows.Count == 0)
                MessageBox.Show("Vous devez sélectionner une ligne d'Address table pour la suppression ");
            else
            { 

                //need to delete from DB and grid
            
            }
        }

        private void buttonSaveEMail_Click(object sender, EventArgs e)
        {
            Utils.EMail eMail = new Utils.EMail();
            if (string.IsNullOrEmpty(textBoxEMailAddress.Text) || (comboBoxEMailType.SelectedIndex == -1))
            {
                MessageBox.Show("Completez des champs obligatoires:\"E-mail address \" ou \" Location \"");
            }
            else
            {
                sqlConnection.Open();
                eMail.eMailAddress = textBoxEMailAddress.Text;
                if (comboBoxEMailType.SelectedIndex == 0)
                    eMail.type = false;
                else
                //if (comboBoxEMailType.SelectedIndex == 1)
                    eMail.type = true;


                int maxId = Utils.selectMaxId(sqlConnection, "id_email", "EMail");

                string sqlCommand = String.Format(
                    "insert into EMail(id_email,eMailAddress,type1) values ({0}, '{1}', {2} )", 
                    maxId + 1, eMail.eMailAddress,  comboBoxEMailType.SelectedIndex/*eMail.type*/ );
                //insert into eMail values (3,'Dorin.Recean@mai.md',0,1);
                int affectedRows = Utils.insertSQLCommandIntoTable(sqlConnection, sqlCommand);
                if (affectedRows == 1)
                    MessageBox.Show("Insert Successfully completed into table Address");
                else
                    MessageBox.Show("Insert was not completed for table Address");
                //clearing Values from Form
                textBoxEMailAddress.Text = "";
                comboBoxEMailType.SelectedIndex = -1;


                sqlConnection.Close();
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new XDocument(
            new XElement("root",
            new XElement("someNode", "someValue")
            )
            ).Save(@"c:\kesha.xml");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                XmlDocument doc = new XmlDocument();
                XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(docNode);

                XmlNode productsNode = doc.CreateElement("products");
                doc.AppendChild(productsNode);

                XmlNode productNode = doc.CreateElement("product");
                XmlAttribute productAttribute = doc.CreateAttribute("id");
                productAttribute.Value = "01";
                productNode.Attributes.Append(productAttribute);
                productsNode.AppendChild(productNode);

                XmlNode nameNode = doc.CreateElement("Name");
                nameNode.AppendChild(doc.CreateTextNode("Java"));
                productNode.AppendChild(nameNode);
                XmlNode priceNode = doc.CreateElement("Price");
                priceNode.AppendChild(doc.CreateTextNode("Free"));
                productNode.AppendChild(priceNode);

                // Create and add another product node.
                productNode = doc.CreateElement("product");
                productAttribute = doc.CreateAttribute("id");
                productAttribute.Value = "02";
                productNode.Attributes.Append(productAttribute);
                productsNode.AppendChild(productNode);
                nameNode = doc.CreateElement("Name");
                nameNode.AppendChild(doc.CreateTextNode("C#"));
                productNode.AppendChild(nameNode);
                priceNode = doc.CreateElement("Price");
                priceNode.AppendChild(doc.CreateTextNode("Free"));
                productNode.AppendChild(priceNode);

                doc.Save("c:\\carte.xml");//Console.Out
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string
            XDocument xmlDoc = XDocument.Load(@"c:\1.xml");
            var test = xmlDoc.Descendants("Companies").Elements("Company").Select(r => r.Value).ToArray();
            string result = string.Join(",", test);
            Console.WriteLine(result);



            string pathToXmlFile = @"C:\1.xml";
            XElement patternDoc = XElement.Load(pathToXmlFile);
            List<string> values = new List<string>();
            foreach (var element in patternDoc.Elements("Companies").Elements("Company"))
            {
                values.Add(element.Value);
                Console.WriteLine(element.Value);
            }


            //sau
            /*var companies = xdoc.Descendants("Company").Select(c => (string)c).ToArray();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Utils.Address> addressList = new List<Utils.Address>();
            string select = "select * from agenda.dbo.Address";
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(select, sqlConnection);
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Utils.Address adrTemp = new Utils.Address();
                    int test = -1;
                    int.TryParse(dr[0].ToString(), out test);
                    adrTemp.idAddress = test;
                    adrTemp.City = dr[1].ToString();
                    adrTemp.street = dr[2].ToString();
                    bool tempBool;
                    bool.TryParse(dr[3].ToString(), out tempBool);
                    adrTemp.type = tempBool;
                    addressList.Add(adrTemp);
                }

            }
            sqlConnection.Close();

            Utils.Address ad1 = new Utils.Address();
            ad1.City = "Chisinau";
            ad1.street = "st. cel Mare 162 ";
            ad1.type = false;



            XmlDocument doc = new XmlDocument();
            XmlNode docNode = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(docNode);

            XmlNode addressesNode = doc.CreateElement("addresses");
            doc.AppendChild(addressesNode);

            foreach (var item in addressList)
            {


                XmlNode addressNode = doc.CreateElement("address");
                //adding 0 attributte - idAddress
                XmlAttribute addressAttributeIdAddress = doc.CreateAttribute("idAddress");
                addressAttributeIdAddress.Value = item.idAddress.ToString();
                addressNode.Attributes.Append(addressAttributeIdAddress);
                //adding 1 attributte - City
                XmlAttribute addressAttributeCity = doc.CreateAttribute("City");
                addressAttributeCity.Value = item.City;
                addressNode.Attributes.Append(addressAttributeCity);
                //addings 2nd attribute - Street
                XmlAttribute addressAttributeStreet = doc.CreateAttribute("Street");
                addressAttributeStreet.Value = item.street;
                addressNode.Attributes.Append(addressAttributeStreet);

                //addings 3nd attribute - Type
                XmlAttribute addressAttributeType = doc.CreateAttribute("Type");
                addressAttributeType.Value = item.type.ToString();
                addressNode.Attributes.Append(addressAttributeType);

                addressesNode.AppendChild(addressNode);

            }
            doc.Save(@"c:\AddressTable.xml");




        }



        //Datagridview1.Rows.Remove(Datagridview1.Rows(Datagridview1.SelectedCells.Item(0).RowIndex))
    }
}
