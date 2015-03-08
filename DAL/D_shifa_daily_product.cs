using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
///D_shifa_daily_product 的摘要说明
/// </summary>
public class D_shifa_daily_product
{
	public D_shifa_daily_product()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 插入数据
    /// </summary>
    /// <param name="product_date"></param>
    /// <param name="peiliao_date"></param>
    /// <param name="banzu"></param>
    /// <param name="beisi_name"></param>
    /// <param name="zhidan"></param>
    /// <param name="fangjuanmishu"></param>
    /// <param name="shoujuanmishu"></param>
    /// <param name="shenchanglv"></param>
    /// <param name="peiliao"></param>
    /// <param name="xianshangyongliao"></param>
    /// <param name="peiliaozongjia"></param>
    /// <param name="peiliaodanjia"></param>
    /// <param name="danhao"></param>
    /// <param name="meimidanjia"></param>
    /// <param name="zhongjianmishu"></param>
    /// <param name="yidengmishu"></param>
    /// <param name="erdengmishu"></param>
    /// <param name="dengjipinlv"></param>
    /// <param name="beisi_prise"></param>
    /// <param name="isComplete"></param>
    /// <returns></returns>
    public static int insert_data(DateTime product_date, DateTime peiliao_date, string banzu, string beisi_name,
                        int zhidan, double fangjuanmishu, double shoujuanmishu,
                      double shenchanglv, double peiliao, double xianshangyongliao, double peiliaozongjia, double peiliaodanjia, double danhao,
                       double meimidanjia, double zhongjianmishu, double yidengmishu, double erdengmishu,
                         double dengjipinlv, double beisi_prise, double isComplete)
    {
        SqlParameter[] param = sqlparameters(product_date, peiliao_date, banzu, beisi_name,
                                     zhidan, fangjuanmishu, shoujuanmishu,
                                   shenchanglv, peiliao, xianshangyongliao, peiliaozongjia, peiliaodanjia, danhao,
                                    meimidanjia, zhongjianmishu, yidengmishu, erdengmishu,
                                      dengjipinlv, beisi_prise, isComplete);
        string sql = @"insert into shifa_daily_product (product_date,  peiliao_date,  banzu,  beisi_name, 
                         zhidan,  fangjuanmishu,  shoujuanmishu,
                       shenchanglv,  peiliao,  xianshangyongliao,  peiliaozongjia,  peiliaodanjia,  danhao,
                        meimidanjia,  zhongjianmishu,  yidengmishu,  erdengmishu,
                          dengjipinlv,  beisi_prise,  isComplete) values (@product_date, @peiliao_date, @banzu, @beisi_name,
                             @zhidan, @fangjuanmishu, @shoujuanmishu,
                           @shenchanglv, @peiliao, @xianshangyongliao, @peiliaozongjia, @peiliaodanjia, @danhao,
                            @meimidanjia, @zhongjianmishu, @yidengmishu, @erdengmishu,
                              @dengjipinlv, @beisi_prise, @isComplete)";
        return db.databasic(sql, param);
    }


    public static int update_data(DateTime product_date, DateTime peiliao_date, string banzu, string beisi_name,
                        int zhidan, double fangjuanmishu, double shoujuanmishu,
                      double shenchanglv, double peiliao, double xianshangyongliao, double peiliaozongjia, double peiliaodanjia, double danhao,
                       double meimidanjia, double zhongjianmishu, double yidengmishu, double erdengmishu,
                         double dengjipinlv, double beisi_prise, double isComplete)
    {
        SqlParameter[] param = sqlparameters(product_date, peiliao_date, banzu, beisi_name,
                                     zhidan, fangjuanmishu, shoujuanmishu,
                                   shenchanglv, peiliao, xianshangyongliao, peiliaozongjia, peiliaodanjia, danhao,
                                    meimidanjia, zhongjianmishu, yidengmishu, erdengmishu,
                                      dengjipinlv, beisi_prise, isComplete);
        string sql = @"update shifa_daily_product set  product_date = @product_date,  peiliao_date = @peiliao_date,  banzu = @banzu,  beisi_name = @beisi_name, 
                         zhidan = @zhidan,  fangjuanmishu = @fangjuanmishu,  shoujuanmishu = @shoujuanmishu,
                       shenchanglv = @shenchanglv,  peiliao = @peiliao,  xianshangyongliao = @xianshangyongliao,  peiliaozongjia = @peiliaozongjia,  peiliaodanjia = @peiliaodanjia,  danhao = @danhao,
                        meimidanjia = @meimidanjia,  zhongjianmishu = @zhongjianmishu,  yidengmishu = @yidengmishu,  erdengmishu = @erdengmishu,
                          dengjipinlv = @dengjipinlv,  beisi_prise = @beisi_prise,  isComplete = @isComplete";
        string sqlwhere = "";
        sql = sql + sqlwhere;
        return db.databasic(sql, param);
    }

    /// <summary>
    /// sqlparameters对应于数据库中的字段，防止SQL注入
    /// </summary>
    /// <param name="product_date"></param>
    /// <param name="peiliao_date"></param>
    /// <param name="banzu"></param>
    /// <param name="beisi_name"></param>
    /// <param name="zhidan"></param>
    /// <param name="fangjuanmishu"></param>
    /// <param name="shoujuanmishu"></param>
    /// <param name="shenchanglv"></param>
    /// <param name="peiliao"></param>
    /// <param name="xianshangyongliao"></param>
    /// <param name="peiliaozongjia"></param>
    /// <param name="peiliaodanjia"></param>
    /// <param name="danhao"></param>
    /// <param name="meimidanjia"></param>
    /// <param name="zhongjianmishu"></param>
    /// <param name="yidengmishu"></param>
    /// <param name="erdengmishu"></param>
    /// <param name="dengjipinlv"></param>
    /// <param name="beisi_prise"></param>
    /// <param name="isComplete"></param>
    /// <returns></returns>
    private static SqlParameter[] sqlparameters(DateTime product_date, DateTime peiliao_date, string banzu, string beisi_name, 
        int zhidan, double fangjuanmishu, double shoujuanmishu,
      double shenchanglv, double peiliao, double xianshangyongliao, double peiliaozongjia, double peiliaodanjia, double danhao,
       double meimidanjia, double zhongjianmishu, double yidengmishu, double erdengmishu,
         double dengjipinlv, double beisi_prise, double isComplete)
    {
        SqlParameter[] sqlparams = new SqlParameter[]{
            new SqlParameter("@peiliao_date",peiliao_date.ToString()),
            new SqlParameter("@product_date",product_date.ToString()),
            new SqlParameter("@banzu",banzu),
            new SqlParameter("@beisi_name",beisi_name),
            new SqlParameter("@zhidan",zhidan),
            new SqlParameter("@fangjuanmishu",fangjuanmishu),
            new SqlParameter("@shoujuanmishu",shoujuanmishu),
            new SqlParameter("@shenchanglv",shenchanglv),
            new SqlParameter("@peiliao",peiliao),
            new SqlParameter("@xianshangyongliao",xianshangyongliao),
            new SqlParameter("@peiliaozongjia",peiliaozongjia),
            new SqlParameter("@peiliaodanjia",peiliaodanjia),
            new SqlParameter("@danhao",danhao),
            new SqlParameter("@meimidanjia",meimidanjia),
            new SqlParameter("@zhongjianmishu",zhongjianmishu),
            new SqlParameter("@yidengmishu",yidengmishu),
            new SqlParameter("@erdengmishu",erdengmishu),
            new SqlParameter("@dengjipinlv",dengjipinlv),
            new SqlParameter("@beisi_prise",beisi_prise),
            new SqlParameter("@isComplete",isComplete)
        };
        return sqlparams;
    }
}