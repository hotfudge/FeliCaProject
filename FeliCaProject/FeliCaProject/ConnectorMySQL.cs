using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace connectorMySQL
{
    class Connector
    {
        private static MySqlConnection connect;
        private string tableSql;
        private string recordSql;

        public static bool Connect(string user,string password)
        {
            string connectionSting = string.Format("server={0};user id={1};password={2};database=mysql;pooling=false","localhost",user,password);
            connect = new MySqlConnection(connectionSting);

            try
            {
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }


        public static void ConnectClose()
        {
            try
            {
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MysqlCreateTable(string tableName,string columm,string primaryKey)
        {
            tableSql = "CREATE TABLE " + tableName + "(" + columm + "," + "PRIMARY KEY(" + primaryKey + "));";
        }

        public void MysqlCreateTable(string tableName, string columm)
        {
            tableSql = "CREATE TABLE " + tableName + "(" + columm + ");";
        }

        public void createTable()
        {

            Connector.Connect("root", "root");
            connect.ChangeDatabase("felica");
            MySqlCommand command = new MySqlCommand(tableSql,connect);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Create Table Success!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectClose();
            }

        }

        public void dropTables(string tableName)
        {
            Connector.Connect("root", "root");
            connect.ChangeDatabase("felica");
            tableSql = "DROP TABLE " + tableName + ";";
            MySqlCommand command = new MySqlCommand(tableSql, connect);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Drop Table Success!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectClose();
            }

        }
        public void createNewAccount(string idms, string names, string studentids, int grades)
        {
            Connector.Connect("root", "root");
            connect.ChangeDatabase("felica");
            /*文字列をINSERTする時には''で囲まなければならない*/
            recordSql = "INSERT INTO userinfo(idm,name,studentid,grade) VALUES('" + idms + "','" + names + "','" + studentids + "'," + grades + ");";
            MessageBox.Show(recordSql);
            MySqlCommand command = new MySqlCommand(recordSql, connect);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Create Account Success!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectClose();
            }
        }
        public static bool userInfoDisp(DataTable dataTable,string idm)
        {
            Connector.Connect("root", "root");
            connect.ChangeDatabase("felica");
            string commandStr = "SELECT * FROM userinfo WHERE idm ='" + idm + "';";

            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter(commandStr,connect);
                adapt.Fill(dataTable);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                ConnectClose();
            }
            return true;

        }
    }
}
