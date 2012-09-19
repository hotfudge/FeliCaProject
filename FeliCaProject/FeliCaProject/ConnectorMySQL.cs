using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace connectorMySQL
{
    /// <summary>
    /// Mysqlの操作に関する処理をまとめたクラス,Connectが行われるため
    /// メソッドの利用をしたあとは必ずDisposeしてください
    /// </summary>
    class Connector: IDisposable
    {
        private static MySqlConnection conn;
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
            conn = new MySqlConnection(connectionSting);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
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
                conn.Close();
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
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
                conn.ChangeDatabase("felica");
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
            MySqlCommand command = new MySqlCommand(commandStr,conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Create Table Success!!");
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
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
                conn.ChangeDatabase("felica");
            }
            tableSql = "DROP TABLE " + tableName + ";";
            MySqlCommand command = new MySqlCommand(tableSql, conn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Drop Table Success!!");
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
            }
            finally
            {
                
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
                conn.ChangeDatabase("felica");
            }
            string commandStr;
            /*文字列をINSERTする時には''で囲まなければならない*/
            commandStr = "INSERT INTO userinfo(idm,name,studentid,grade) VALUES (@idms,@names,@studentids,@grades);";
            MySqlCommand command = new MySqlCommand(commandStr, conn);
            try
            {
                AddMysqlParameter(command, "@idms", MySqlDbType.VarChar, idms);
                AddMysqlParameter(command, "@names", MySqlDbType.VarChar, names);
                AddMysqlParameter(command, "@studentids", MySqlDbType.VarChar, studentids);
                AddMysqlParameter(command, "@grades", MySqlDbType.Int32, grades);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
            }
            commandStr = "INSERT INTO entrytime(idm) VALUES('" + idms + "');";
            MySqlCommand commandTime = new MySqlCommand(commandStr, conn);
            try
            {
                commandTime.ExecuteNonQuery();
                MessageBox.Show("Create Account Success!!");
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
            }

        }
        /// <summary>
        /// IDmからユーザを照合し、メインのフォームに個人データを表示するメソッド
        /// </summary>
        /// <param name="dataTable">データベースから引き出したデータを格納するテーブル</param>
        /// <param name="idm">カードから取得したidm</param>
        /// <returns></returns>
        public MySqlDataReader userInfoDisp(MySqlDataReader dataReader,string idm)
        {
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                conn.ChangeDatabase("felica");
            }
            string commandStr = "SELECT * FROM userinfo WHERE idm = @idm;";
            MySqlCommand command = new MySqlCommand(commandStr,conn); 
            try
            {
                AddMysqlParameter(command, "@idm", MySqlDbType.VarChar, idm);
            }
            catch (MySqlException ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
                return null;
            }
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows == false)
            {                
                return null;//falseのあとを実装して軽くせよ
            }
            else
            {
                while (dataReader.Read());
            }
            return dataReader;
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
                conn.ChangeDatabase("felica");
            }
            string commandStr = "SELECT * FROM entrytime WHERE idm =@idm;";
            MySqlCommand paramCommand = new MySqlCommand(commandStr, conn);
            try
            {
                AddMysqlParameter(paramCommand, "@idm", MySqlDbType.VarChar, idm);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif          
            }
            MySqlDataReader dataReader = paramCommand.ExecuteReader();
            if (dataReader.HasRows == true)
            {
                while (dataReader.Read());
                //intimeの保存
                if (dataReader["intime"].ToString().Trim() == "")
                {
                    dataReader.Close();
                    commandStr = "UPDATE entrytime SET intime = now() WHERE idm = @idm;";
                    MySqlCommand command = new MySqlCommand(commandStr, conn);
                    try
                    {
                        AddMysqlParameter(command, "@idm", MySqlDbType.VarChar, idm);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
#if DEBUG
                        MessageBox.Show(ex.Message);
#endif              
                    }
                }
                //outtimeの保存
                else if (dataReader["intime"].ToString().Trim() != "" && dataReader["outtime"].ToString().Trim() == "")
                {
                    dataReader.Close();
                    commandStr = "UPDATE entrytime SET outtime = now() WHERE idm = @idm;";
                    MySqlCommand command = new MySqlCommand(commandStr, conn);
                    try
                    {
                        AddMysqlParameter(command, "@idm", MySqlDbType.VarChar, idm);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
#if DEBUG
                        MessageBox.Show(ex.Message);
#endif              
                    }
                }
            }
        }
        /// <summary>
        /// ShowTableメニューからテーブルを閲覧するために用いるメソッド
        /// </summary>
        /// <param name="commandStr">MySQLコマンド</param>
        /// <param name="dataTable">テーブルのデータを格納する変数</param>
        public static void tableReader(string commandStr,DataTable dataTable)
        {

            MySqlDataAdapter adapt = new MySqlDataAdapter(commandStr,conn);
            conn.ChangeDatabase("felica");
            try
            {
                adapt.Fill(dataTable);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
            }
        }
        /// <summary>
        /// INTIME・OUTTIMEをデータベースから取り出すメソッド
        /// </summary>
        /// <param name="idm">カードから取得したidm</param>
        /// <param name="getTimeDataTable">データベースから取得した時間を格納するテーブル</param>
        public MySqlDataReader getEntryTimeTable(string idm,MySqlDataReader dataReader)
        {
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                conn.ChangeDatabase("felica");
            }
            string commandStr = "SELECT intime,outtime FROM entrytime WHERE idm = @idm;";
            MySqlCommand command = new MySqlCommand(commandStr,conn);
            try
            {
                AddMysqlParameter(command, "@idm", MySqlDbType.VarChar, idm);
                dataReader = command.ExecuteReader();
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
                return null;
            }

            if (dataReader.HasRows == true)
            {
                while (dataReader.Read()) ;
            }
            else
            {
                return null;
            }
            return dataReader;
        }

        /// <summary>
        /// 入力されたIdmがDB上に存在するか確認するメソッド
        /// </summary>
        /// <param name="idm">抽出されたidm</param>
        /// <returns>True:存在する,False:存在しない</returns>
        public bool checkIdmExist(string idm)
        {
            bool connectBool = Connector.Connect("root", "root");
            if (connectBool)
            {
                conn.ChangeDatabase("felica");
            }
            string commandStr = "SELECT * FROM userinfo WHERE idm = @idm;";
            MySqlCommand command = new MySqlCommand(commandStr, conn);
            MySqlDataReader dataReader = null;
            try
            {
                AddMysqlParameter(command,"@idm",MySqlDbType.VarChar,idm);
                dataReader = command.ExecuteReader();
            }
            catch(Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.Message);
#endif
                return false;
            }
            if (dataReader.HasRows == false)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// SQLインジェクション対策。Paramに入力された不正な値をエスケープする。
        /// </summary>
        /// <param name="com">Mysqlコマンド文</param>
        /// <param name="ParameterName">プレースホルダ</param>
        /// <param name="type">データの型</param>
        /// <param name="value">エスケープしたい対象</param>
        public void AddMysqlParameter(
            MySqlCommand com,string ParameterName,MySqlDbType type,Object value)
        {
            MySqlParameter param = com.CreateParameter();
            param.ParameterName = ParameterName;
            param.MySqlDbType = type;
            param.Direction = ParameterDirection.Input;
            param.Value = value;
            com.Parameters.Add(param);
        }
        /// <summary>
        /// Disposeインターフェイスの実装
        /// </summary>
        public void Dispose()
        {
            ConnectClose();
        }

    }
}
