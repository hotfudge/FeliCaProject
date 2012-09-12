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
        /// テーブルを作成するメソッド
        /// </summary>
        /// <param name="tableName">Createするテーブル名</param>
        /// <param name="columm">Createするカラム</param>
        /// <param name="primaryKey">設定するPRIMARY KEY</param>
        public void createTable(string tableName, string columm, string primaryKey)
        {
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                connect.ChangeDatabase("felica");
            }
            string commandStr;
            if (primaryKey.Trim() != "")
            {
                commandStr = "CREATE TABLE " + tableName + "(" + columm + "," + "PRIMARY KEY(" + primaryKey + "));";
            }
            else
            {
                commandStr = "CREATE TABLE " + tableName + "(" + columm + ");";
            }
            MySqlCommand command = new MySqlCommand(commandStr,connect);
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
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                connect.ChangeDatabase("felica");
            }
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
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                connect.ChangeDatabase("felica");
            }
            string commandStr;
            /*文字列をINSERTする時には''で囲まなければならない*/
            commandStr = "INSERT INTO userinfo(idm,name,studentid,grade) VALUES('" + idms + "','" + names + "','" + studentids + "'," + grades + ");";
            MessageBox.Show(commandStr);
            MySqlCommand command = new MySqlCommand(commandStr, connect);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            commandStr = "INSERT INTO entrytime(idm) VALUES('" + idms + "');";
            MySqlCommand commandTime = new MySqlCommand(commandStr, connect);
            try
            {
                commandTime.ExecuteNonQuery();
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
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                connect.ChangeDatabase("felica");
            }
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
        /// 入退出の時間をMysqlに格納するメソッド
        /// </summary>
        /// <param name="idm">idm</param>
        public void entryTime(string idm)
        {
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                connect.ChangeDatabase("felica");
            }
            string commandStr = "SELECT * FROM entrytime WHERE idm ='" + idm + "';";
            DataTable dataTable = new DataTable();
            try
            {
                MySqlDataAdapter adapt = new MySqlDataAdapter(commandStr, connect);
                adapt.Fill(dataTable);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (dataTable.Rows.Count != 0)
            {
                if (dataTable.Rows[0][1].ToString().Trim() == "")
                {
                    commandStr = "UPDATE entrytime SET intime = now() WHERE idm = '" + idm + "';";
                    MySqlCommand command = new MySqlCommand(commandStr, connect);
                    try
                    {
                        command.ExecuteNonQuery();
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
                else if (dataTable.Rows[0][1].ToString().Trim() != "" && dataTable.Rows[0][2].ToString().Trim() == "")
                {
                    commandStr = "UPDATE entrytime SET outtime = now() WHERE idm = '" + idm + "';";
                    MySqlCommand command = new MySqlCommand(commandStr, connect);
                    try
                    {
                        command.ExecuteNonQuery();
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
            }
            else
            {
                MessageBox.Show("アカウント登録がされていないカード又は読み込みエラーです");
            }
        }
        /// <summary>
        /// ShowTableメニューからテーブルを閲覧するために用いるメソッド
        /// </summary>
        /// <param name="commandStr">MySQLコマンド</param>
        /// <param name="dataTable">テーブルのデータを格納する変数</param>
        public static void tableReader(string commandStr,DataTable dataTable)
        {

            MySqlDataAdapter adapt = new MySqlDataAdapter(commandStr,connect);
            connect.ChangeDatabase("felica");
            try
            {
                adapt.Fill(dataTable);
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
        public void getEntryTimeTable(string idm,DataTable getTimeDataTable)
        {
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                connect.ChangeDatabase("felica");
            }
            string commandStr = "SELECT intime,outtime FROM entrytime WHERE idm = '" + idm + "';";
            MySqlDataAdapter adapt = new MySqlDataAdapter(commandStr, connect);
            try
            {
                adapt.Fill(getTimeDataTable);
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
    }
}
