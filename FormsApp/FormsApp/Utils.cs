using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


public class Utils
{
    public Utils()
    {
    }
    //adresa fizica/juridica
    public class Address
    {
        public string City { get; set; }
        public string street { get; set; }
        public bool type { get; set; }
        public override string ToString()
        {

            return " City: " + City + " street: " + street + " type: " + (type ? "home" : "work");
        }
    }
    //e-mail
    public class EMail
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
        public string name { get; set; }
        public string surname { get; set; }
        public string phoneNumber { get; set; }
        public List<Address> addressList { get; set; }
        public List<EMail> emailList { get; set; }

        public override string ToString()
        {
            string str = "name:" + name + " surname:" + surname + " phoneNumber:" + phoneNumber + "\n";
            if (addressList != null)
                foreach (var item in addressList)
                {
                    str += item.ToString() + "\n";
                }
            if (emailList != null)
                foreach (var item in emailList)
                {
                    str += item.ToString() + "\n";
                }
            return str;
        }
    }
    
    public static SqlConnection prepareConnection(string ipAddress, string dbName)
    {
        SqlConnection connection = new SqlConnection("Server=" + ipAddress + ";Database=" + dbName + ";Trusted_Connection=True;");
        return connection;
    }

    public static string selectFromTable(SqlConnection sqlConnection)
    {
        //using (sqlConnection)
        {
            using (SqlCommand command = new SqlCommand("select * from test.dbo.utilisateur", sqlConnection))//select Utilisateur.Nom,Comanda.tipul from Utilisateur, Comanda where Comanda.Id_User=Utilisateur.ID_User; ", Connection))
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

    private static void update(SqlConnection sqlConnection, string sqlString)
    {
        //throw new NotImplementedException();
        using (sqlConnection)
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

    public static int selectMaxId(SqlConnection sqlConnection, string idName, string tableName) 
    {
        int maxId=0;
        bool flag = false; 
        SqlCommand cmd = new SqlCommand("select max (" + idName + ") from " + tableName + "", sqlConnection);
        using (SqlDataReader dr = cmd.ExecuteReader())
        {
            while (dr.Read())
            {
                flag = int.TryParse(dr[0].ToString(), out maxId);
            }
            if (flag)
                return maxId;
            else 
                return 0;
        }
    }

    public static int insertSQLCommandIntoTable(SqlConnection sqlConnection, string sqlString)
    {
        SqlCommand cmd = new SqlCommand(sqlString, sqlConnection);
        cmd.CommandType = CommandType.Text;
        return cmd.ExecuteNonQuery();//return nb of row affected
    }
}
