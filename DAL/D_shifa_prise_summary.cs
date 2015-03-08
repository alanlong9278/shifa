using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
///D_shifa_prise_summary 的摘要说明
/// </summary>
public class D_shifa_prise_summary
{
	public D_shifa_prise_summary()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 插入数据
    /// </summary>
    /// <param name="beisi_name"></param>
    /// <param name="jibu_name"></param>
    /// <param name="summary_date"></param>
    /// <param name="peiliaozongjia"></param>
    /// <param name="peiliaodanjia"></param>
    /// <param name="danhao"></param>
    /// <param name="meimidanjie"></param>
    /// <param name="zhongjianmishu"></param>
    /// <param name="yidengshu"></param>
    /// <param name="erdengshu"></param>
    /// <param name="chengpinlv"></param>
    /// <param name="jibu_prise"></param>
    /// <param name="jibuzongjia"></param>
    /// <param name="chengbenjia"></param>
    /// <param name="boli"></param>
    /// <returns></returns>
    public static int insert_data(string beisi_name, string jibu_name, DateTime summary_date, double peiliaozongjia,
        double peiliaodanjia,
      double danhao, double meimidanjie, double zhongjianmishu, double yidengshu, double erdengshu, double chengpinlv,
       double jibu_prise, double jibuzongjia, double chengbenjia, double boli)
    {
        SqlParameter[] param = sqlparameters(beisi_name, jibu_name, summary_date, peiliaozongjia,
             peiliaodanjia,
           danhao, meimidanjie, zhongjianmishu, yidengshu, erdengshu, chengpinlv,
            jibu_prise, jibuzongjia, chengbenjia, boli);
        string sql = @"insert into shifa_prise_summary ( beisi_name,  jibu_name,  summary_date,  peiliaozongjia,
                         peiliaodanjia,
                       danhao,  meimidanjie,  zhongjianmishu,  yidengshu,  erdengshu,  chengpinlv,
                        jibu_prise,  jibuzongjia,  chengbenjia,  boli) values (@beisi_name, @jibu_name, @summary_date, @peiliaozongjia,
                         @peiliaodanjia,
                       @danhao, @meimidanjie, @zhongjianmishu, @yidengshu, @erdengshu, @chengpinlv,
                        @jibu_prise, @jibuzongjia, @chengbenjia, @boli)";
        return db.databasic(sql, param);
    }


    public static int update_data(string beisi_name, string jibu_name, DateTime summary_date, double peiliaozongjia,
        double peiliaodanjia,
      double danhao, double meimidanjie, double zhongjianmishu, double yidengshu, double erdengshu, double chengpinlv,
       double jibu_prise, double jibuzongjia, double chengbenjia, double boli)
    {
        SqlParameter[] param = sqlparameters(beisi_name, jibu_name, summary_date, peiliaozongjia,
             peiliaodanjia,
           danhao, meimidanjie, zhongjianmishu, yidengshu, erdengshu, chengpinlv,
            jibu_prise, jibuzongjia, chengbenjia, boli);
        string sql = @"update shifa_prise_summary set beisi_name = @beisi_name,  jibu_name = @jibu_name,  summary_date = @summary_date,  peiliaozongjia = @peiliaozongjia,
                         peiliaodanjia = @peiliaodanjia,
                       danhao = @danhao,  meimidanjie = @meimidanjie,  zhongjianmishu = @zhongjianmishu,  yidengshu = @yidengshu,  erdengshu = @erdengshu,  chengpinlv = @chengpinlv,
                        jibu_prise = @jibu_prise,  jibuzongjia = @jibuzongjia,  chengbenjia = @chengbenjia,  boli = @boli";
        string sqlwhere = "";
        sql = sql + sqlwhere;
        return db.databasic(sql, param);
    }

    /// <summary>
    /// sqlparameters 对应于数据库中表单中的字段，防止SQL注入
    /// </summary>
    /// <param name="beisi_name"></param>
    /// <param name="jibu_name"></param>
    /// <param name="summary_date"></param>
    /// <param name="peiliaozongjia"></param>
    /// <param name="peiliaodanjia"></param>
    /// <param name="danhao"></param>
    /// <param name="meimidanjie"></param>
    /// <param name="zhongjianmishu"></param>
    /// <param name="yidengshu"></param>
    /// <param name="erdengshu"></param>
    /// <param name="chengpinlv"></param>
    /// <param name="jibu_prise"></param>
    /// <param name="jibuzongjia"></param>
    /// <param name="chengbenjia"></param>
    /// <param name="boli"></param>
    /// <returns></returns>
    private static SqlParameter[] sqlparameters(string beisi_name, string jibu_name, DateTime summary_date, double peiliaozongjia,
        double peiliaodanjia,
      double danhao, double meimidanjie, double zhongjianmishu, double yidengshu, double erdengshu, double chengpinlv,
       double jibu_prise, double jibuzongjia, double chengbenjia, double boli)
    {
        SqlParameter[] sqlparams = new SqlParameter[]{
            new SqlParameter("@beisi_name",beisi_name),
            new SqlParameter("@summary_date",summary_date.ToString()),
            new SqlParameter("@jibu_name",jibu_name),
            new SqlParameter("@peiliaozongjia",peiliaozongjia),
            new SqlParameter("@peiliaodanjia",peiliaodanjia),
            new SqlParameter("@meimidanjie",meimidanjie),
            new SqlParameter("@danhao",danhao),
            new SqlParameter("@zhongjianmishu",zhongjianmishu),
            new SqlParameter("@yidengshu",yidengshu),
            new SqlParameter("@erdengshu",erdengshu),
            new SqlParameter("@chengpinlv",chengpinlv),
            new SqlParameter("@jibu_prise",jibu_prise),
            new SqlParameter("@jibuzongjia",jibuzongjia),
            new SqlParameter("@chengbenjia",chengbenjia),
            new SqlParameter("@boli",boli)
        };
        return sqlparams;
    }
}