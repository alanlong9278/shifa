using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
///D_shifa_product_summary 的摘要说明
/// </summary>
public class D_shifa_product_summary
{
    public D_shifa_product_summary()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }

    /// <summary>
    /// 插入数据
    /// </summary>
    /// <param name="banzu"></param>
    /// <param name="summary_date"></param>
    /// <param name="zhidanliang"></param>
    /// <param name="fangbu"></param>
    /// <param name="fangjuan"></param>
    /// <param name="shenchanglv"></param>
    /// <param name="zongjianzongliang"></param>
    /// <param name="yidengpin"></param>
    /// <param name="erdengpin"></param>
    /// <param name="zongdengjilv"></param>
    /// <param name="tingjishijian"></param>
    /// <returns></returns>
    public static int insert_data(string banzu, DateTime summary_date, int zhidanliang, int fangbu,
      double fangjuan, double shenchanglv, double zongjianzongliang, double yidengpin, double erdengpin, double zongdengjilv,
       double tingjishijian)
    {
        string sql = @"insert into shifa_product_summary (banzu, summary_date, zhidanliang, fangbu,
                      fangjuan, shenchanglv, zongjianzongliang, yidengpin, erdengpin, zongdengjilv,
                       tingjishijian) values ( @banzu, @summary_date, @zhidanliang, @fangbu,
                      @fangjuan, @shenchanglv, @zongjianzongliang, @yidengpin, @erdengpin, @zongdengjilv,
                       @tingjishijian)";
        SqlParameter[] param = sqlparameters(banzu, summary_date, zhidanliang, fangbu,
                                              fangjuan, shenchanglv, zongjianzongliang, yidengpin, erdengpin, zongdengjilv,
                                               tingjishijian);
        return db.databasic(sql, param);
    }


    public static int insert_data(string banzu, DateTime summary_date, int zhidanliang, int fangbu,
     double fangjuan, double shenchanglv, double zongjianzongliang, double yidengpin, double erdengpin, double zongdengjilv,
      double tingjishijian)
    {
        string sql = @"update shifa_product_summary set banzu = @banzu, summary_date = @summary_date, zhidanliang = @zhidanliang, fangbu = @fangbu,
                      fangjuan = @fangjuan, shenchanglv = @shenchanglv, zongjianzongliang = @zongjianzongliang, yidengpin = @yidengpin, erdengpin = @erdengpin, zongdengjilv = @zongdengjilv,
                       tingjishijian = @tingjishijian";
        string sqlwhere = "";
        sql = sql + sqlwhere;
        SqlParameter[] param = sqlparameters(banzu, summary_date, zhidanliang, fangbu,
                                              fangjuan, shenchanglv, zongjianzongliang, yidengpin, erdengpin, zongdengjilv,
                                               tingjishijian);
        return db.databasic(sql, param);
    }

    /// <summary>
    /// sqlparameters 对应数据库中表单的字段，防止sql注入
    /// </summary>
    /// <param name="banzu"></param>
    /// <param name="summary_date"></param>
    /// <param name="zhidanliang"></param>
    /// <param name="fangbu"></param>
    /// <param name="fangjuan"></param>
    /// <param name="shenchanglv"></param>
    /// <param name="zongjianzongliang"></param>
    /// <param name="yidengpin"></param>
    /// <param name="erdengpin"></param>
    /// <param name="zongdengjilv"></param>
    /// <param name="tingjishijian"></param>
    /// <returns></returns>
    private static SqlParameter[] sqlparameters(string banzu, DateTime summary_date, int zhidanliang, int fangbu,
      double fangjuan, double shenchanglv, double zongjianzongliang, double yidengpin, double erdengpin, double zongdengjilv,
       double tingjishijian)
    {
        SqlParameter[] sqlparams = new SqlParameter[]{
            new SqlParameter("@banzu",banzu),
            new SqlParameter("@summary_date",summary_date.ToString()),
            new SqlParameter("@zhidanliang",zhidanliang),
            new SqlParameter("@fangbu",fangbu),
            new SqlParameter("@fangjuan",fangjuan),
            new SqlParameter("@shenchanglv",shenchanglv),
            new SqlParameter("@zongjianzongliang",zongjianzongliang),
            new SqlParameter("@yidengpin",yidengpin),
            new SqlParameter("@erdengpin",erdengpin),
            new SqlParameter("@zongdengjilv",zongdengjilv),
            new SqlParameter("@tingjishijian",tingjishijian)
        };
        return sqlparams;
    }
      
}