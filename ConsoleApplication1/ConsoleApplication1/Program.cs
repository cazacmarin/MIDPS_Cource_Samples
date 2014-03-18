using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
//using System.Data.SqlClient;
//using System.Data;

namespace ConsoleApplication1
{
    //adresa fizica/juridica
    class Address 
    {
        public string City { get; set; }
        public string street { get; set; }
        public bool type { get; set; }
        public override string ToString() {

            return " City: " + City + " street: " + street + " type: " + (type ? "home" : "work");
        }
    }
    //e-mail
    class EMail
    {
        public string eMailAddress { get; set; }
        public bool type { get; set; }//if false then Work, else - HOME
        public override string ToString()
        {
            return " eMailAddress: " + eMailAddress + " type: " + (type ? "home" : "work");
        }
    }
    class Agenda
    {
        public string name { get;  set; }
        public string surname { get;  set; }
        public string phoneNumber { get; set; }
        public List<Address> addressList { get; set; }
        public List<EMail> emailList { get; set; }
        
        public override string ToString() {
            string str = "name:" + name + " surname:" + surname + " phoneNumber:" + phoneNumber + "\n";
            if (addressList != null) 
            foreach (var item in addressList)
	        {
                str += item.ToString() +"\n";
	        }
            if (emailList != null) 
            foreach (var item in emailList)
            {
                str += item.ToString() + "\n";
            }
            return str;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //laborator1();
            SqlConnection sqlConnection = prepareConnection(".","agenda");
            sqlConnection.Open();
            selectFromTable(sqlConnection);
            string sqlString = "INSERT INTO Address(id_address,city,street,type2) VALUES(@param4,@param1,@param2,@param3)";
            insert(sqlConnection, sqlString );
            sqlString = "UPDATE Address SET street=@param1,type2=@param2 WHERE id_address=@param3";
            update(sqlConnection, sqlString);
            sqlConnection.Close();
            System.Console.ReadKey();
            
            

        }

        private static SqlConnection prepareConnection(string ipAddress, string dbName)
        {
            SqlConnection connection = new SqlConnection("Server=" + ipAddress + ";Database=" + dbName + ";Trusted_Connection=True;");
            return connection;
        }

        private static void laborator1()
        {
            Agenda a1 = new Agenda();
            a1.name = "Dorin";
            a1.surname = " Recean";
            a1.phoneNumber = "902";
            Address ad1 = new Address();
            ad1.City = "Chisinau";
            ad1.street = "st. cel Mare 162 ";
            ad1.type = false;
            Address ad2 = new Address();
            ad2.City = "Orhei";
            ad2.street = "Mihai Eminescu 1";
            ad2.type = true;//home
            a1.addressList = new List<Address>();
            a1.addressList.Add(ad1);
            a1.addressList.Add(ad2);

            EMail eMail = new EMail();
            eMail.eMailAddress = "asd@asd.com";
            eMail.type = false;
            a1.emailList = new List<EMail>();
            a1.emailList.Add(eMail);

            Agenda a2 = new Agenda();
            a2.name = "Vovacica";
            a2.surname = " Pecikin";
            a2.phoneNumber = "901";
            a2.addressList = new List<Address>();
            a2.addressList.Add(ad1);


            List<Agenda> list1 = new List<Agenda>();
            list1.Add(a1);
            list1.Add(a2);

            try
            {
                int a = 0;
                int x = 3 / a;
            }
            catch (Exception ex)
            {
                Console.WriteLine("S-a produs o exceptize :{0}", ex.Message);
            }

            foreach (var item in list1)
            {
                Console.WriteLine(item.ToString());
            }
            System.Diagnostics.Debug.WriteLine("asd");

            /*string ConnectionString = "Persist Security Info=False;User ID=sa;Password=1210;database=NMS;server=(local)";
            SqlConnection Connection = new SqlConnection(ConnectionString);

            Connection.Open();
            using (Connection)
            {
                SqlCommand mySqlCMD = new SqlCommand("select Utilisateur.Nom,Comanda.tipul from Utilisateur, Comanda where Comanda.Id_User=Utilisateur.ID_User; ", Connection);
                //mySqlCMD.CommandType = CommandType.Text;//mySqlCMD.CommandText;//StoredProcedure;
                mySqlCMD.Prepare();


            }*/


        }

        private static void insert(SqlConnection sqlConnection, string sqlString)
        {
            //throw new NotImplementedException();
           // using (sqlConnection)
            {
                //sqlConnection.Open();
                //string sql = ;//id_address
                SqlCommand cmd = new SqlCommand(sqlString, sqlConnection);
                cmd.Parameters.Add("@param4", SqlDbType.Int).Value = 15;
                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = "Soroca";
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 100).Value = "bd. Stefan Cel Mare 11";
                cmd.Parameters.Add("@param3", SqlDbType.SmallInt, 50).Value = 1;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        private static void update(SqlConnection sqlConnection, string sqlString)
        {
            //throw new NotImplementedException();
            using(sqlConnection)
            {
                //sqlConnection.Open();

                SqlCommand cmd = new SqlCommand(sqlString, sqlConnection);
                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = "bd. Stefan Cel Mare 11/1";
                    cmd.Parameters.Add("@param2", SqlDbType.SmallInt).Value = 0;
                    cmd.Parameters.Add("@param3", SqlDbType.Int).Value = 10;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
            }
        }


        public static string selectFromTable(SqlConnection sqlConnection)
        {
            //using (sqlConnection)
            {
                using (SqlCommand command = new SqlCommand("select * from test.dbo.utilisateur",sqlConnection))//select Utilisateur.Nom,Comanda.tipul from Utilisateur, Comanda where Comanda.Id_User=Utilisateur.ID_User; ", Connection))
                {
                     
                    using (SqlDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Console.WriteLine(dr[0]);
                            Console.WriteLine(dr[1]);
                            Console.WriteLine(dr[2]);
                        }
                        
                    }
                    
                }
            }
            return "";
        }
    }
}

/*
 *     finally
    {
        // close the reader
        if (rdr != null)
        {
            rdr.Close();
        }

        // Close the connection
        if (conn != null)
        {
            conn.Close();
        }
    }
 */