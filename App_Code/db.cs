using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
///db 的摘要说明
/// </summary>
public class db
{
	public db()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    /// <summary>
    /// 连接数据库
    /// </summary>
    private static  string strconn = ConfigurationManager.AppSettings["conn"];
   // private static  SqlConnection myconn = new SqlConnection(strconn);
    public static int databasic(string sql)
    {

        int count = 0;
        using (SqlConnection conn = new SqlConnection(strconn))
        {
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                count = cmd.ExecuteNonQuery();
            }
        }
        return count;
    }
    public static int databasic(string sql, SqlParameter[] param)
    {

        int count = 0;
        using (SqlConnection conn = new SqlConnection(strconn))
        {
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.Add(param);
                count = cmd.ExecuteNonQuery();
            }
        }
        return count;
    }

    /// <summary>
    /// 得手动关闭sqldatareader
    /// </summary>
    /// <param name="sql"></param>
    /// <returns></returns>
    public static SqlDataReader returnReader(string sql)
    {

        SqlConnection myconn = new SqlConnection(strconn);
        try
        { 

            myconn.Open();
            //myconn.ConnectionString = strconn;
            using (SqlCommand cmd = myconn.CreateCommand())
            {
                cmd.CommandText = sql;

                cmd.ExecuteNonQuery();
                SqlDataReader myreader = cmd.ExecuteReader();
                return myreader;
            }
          
        }
	    catch(Exception e)
	    {
            throw new Exception("执行任务失败:" + e.Message + "   " + sql);
	    }
      
    }
    public static DataSet returnDataSet(string sql)
    {
        DataSet myset = new DataSet();
        using (SqlConnection myconn = new SqlConnection(strconn))
        {

            //myconn.ConnectionString = strconn;
           
            myconn.Open();
            using (SqlCommand cmd = myconn.CreateCommand())
            {
                cmd.CommandText = sql;
                SqlDataAdapter myAdapt = new SqlDataAdapter(cmd);
               
                myAdapt.Fill(myset, "DataList");

                myAdapt.Dispose();
            }
          
        }
        return myset;
    }

    public static DataSet returnDataSet(string sql, SqlParameter[] param)
    {
        DataSet myset = new DataSet();
        using (SqlConnection myconn = new SqlConnection(strconn))
        {

            //myconn.ConnectionString = strconn;

            myconn.Open();
            using (SqlCommand cmd = myconn.CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.Add(param);
                SqlDataAdapter myAdapt = new SqlDataAdapter(cmd);

                myAdapt.Fill(myset, "DataList");

                myAdapt.Dispose();
            }

        }
        return myset;
    }
    public static DataTable returnDataTable(string sql, SqlParameter[] param)
    {
        return returnDataSet(sql, param).Tables[0];

    }
    public static DataTable returnDataTable(string sql)
    {
        return returnDataSet(sql).Tables[0];
    }
}