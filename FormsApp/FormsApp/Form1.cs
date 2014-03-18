using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

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


        //Datagridview1.Rows.Remove(Datagridview1.Rows(Datagridview1.SelectedCells.Item(0).RowIndex))
    }
}
