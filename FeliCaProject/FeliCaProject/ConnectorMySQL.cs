using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace connectorMySQL
{
    /// <summary>
    /// Mysqlの操作に関する処理をまとめたクラス
    /// </summary>
    class Connector
    {
        private static MySqlConnection connect;
        private string tableSql;
        /// <summary>
        /// 接続を行うメソッド
        /// </summary>
        /// <param name="user">Mysqlログインユーザ</param>
        /// <param name="password">MysqlログインPassword</param>
        /// <returns>接続が正しく行われたかどうか</returns>
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

        /// <summary>
        /// コネクションをクローズするメソッド
        /// </summary>
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
        /// <summary>
        /// Mysqlのコマンドに変換するメソッド(Create)
        /// *後に改変予定*
        /// </summary>
        /// <param name="tableName">Createするテーブル名</param>
        /// <param name="columm">Createするカラム</param>
        /// <param name="primaryKey">設定するPRIMARY KEY</param>
        public void MysqlCreateTable(string tableName,string columm,string primaryKey)
        {
            tableSql = "CREATE TABLE " + tableName + "(" + columm + "," + "PRIMARY KEY(" + primaryKey + "));";
        }

        public void MysqlCreateTable(string tableName, string columm)
        {
            tableSql = "CREATE TABLE " + tableName + "(" + columm + ");";
        }
        /// <summary>
        /// テーブルを作成するメソッド
        /// </summary>
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
        /// <summary>
        /// テーブルを削除するメソッド
        /// </summary>
        /// <param name="tableName">dropするテーブルの名前</param>
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
        /// <summary>
        /// アカウント作成用のメソッド
        /// </summary>
        /// <param name="idms">idm</param>
        /// <param name="names">登録者名</param>
        /// <param name="studentids">学籍番号</param>
        /// <param name="grades">学年</param>
        public void createNewAccount(string idms, string names, string studentids, int grades)
        {
            Connector.Connect("root", "root");
            string commandStr;
            connect.ChangeDatabase("felica");
            /*文字列をINSERTする時には''で囲まなければならない*/
            commandStr = "INSERT INTO userinfo(idm,name,studentid,grade) VALUES('" + idms + "','" + names + "','" + studentids + "'," + grades + ");";
            MessageBox.Show(commandStr);
            MySqlCommand command = new MySqlCommand(commandStr, connect);
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
        /// <summary>
        /// IDmからユーザを照合し、メインのフォームに個人データを表示するメソッド
        /// </summary>
        /// <param name="dataTable">データベースから引き出したデータを格納するテーブル</param>
        /// <param name="idm">カードから取得したidm</param>
        /// <returns></returns>
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
        /// <summary>
        /// Mysqlの時間を取得するメソッド
        /// </summary>
        /// <returns>時間</returns>
        public string getTimeNow()
        {
            string nowTime;
            string commandStr = "SELECT now();";
            Connector.Connect("root", "root");
            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter(commandStr, connect);
                adapt.Fill(dataTable);
                nowTime = dataTable.Rows[0][0].ToString();
                return nowTime;
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConnectClose();
            }

        }
    }
}
