using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
///D_meibao_product 的摘要说明
/// </summary>
public class D_meibao_product
{
	public D_meibao_product()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 插入数据
    /// </summary>
    /// <param name="zhonglei"></param>
    /// <param name="product_date"></param>
    /// <param name="product_hour"></param>
    /// <param name="yongmeichangshu"></param>
    /// <param name="meichangzhong"></param>
    /// <param name="yongmeizongliang"></param>
    /// <param name="meimimeihao"></param>
    /// <param name="ganfa"></param>
    /// <param name="shifa"></param>
    /// <param name="kuntu"></param>
    /// <param name="ersanban"></param>
    /// <param name="yahua"></param>
    /// <param name="rouwen"></param>
    /// <param name="zongji"></param>
    /// <returns></returns>
    public static int insert_data(string zhonglei, DateTime product_date, double product_hour, double yongmeichangshu,
       double meichangzhong, double yongmeizongliang, double meimimeihao, double ganfa, double shifa, double kuntu,
        double ersanban, double yahua, double rouwen, double zongji)
    {
        string sql = @"insert into meihao_product (zhonglei, product_date, product_hour, yongmeichangshu,meichangzhong,
             yongmeizongliang, meimimeihao, ganfa, shifa, kuntu, ersanban, yahua, rouwen, zongji) 
             values (@zhonglei, @product_date, @product_hour, @yongmeichangshu,@meichangzhong,
             @yongmeizongliang, @meimimeihao, @ganfa, @shifa, @kuntu, @ersanban, @yahua, @rouwen, @zongji)";
        SqlParameter[] param = sqlparameters(zhonglei, product_date, product_hour, yongmeichangshu, meichangzhong,
             yongmeizongliang, meimimeihao, ganfa, shifa, kuntu, ersanban, yahua, rouwen, zongji);
        return db.databasic(sql, param);
    }

    /// <summary>
    /// 更新数据
    /// </summary>
    /// <param name="zhonglei"></param>
    /// <param name="product_date"></param>
    /// <param name="product_hour"></param>
    /// <param name="yongmeichangshu"></param>
    /// <param name="meichangzhong"></param>
    /// <param name="yongmeizongliang"></param>
    /// <param name="meimimeihao"></param>
    /// <param name="ganfa"></param>
    /// <param name="shifa"></param>
    /// <param name="kuntu"></param>
    /// <param name="ersanban"></param>
    /// <param name="yahua"></param>
    /// <param name="rouwen"></param>
    /// <param name="zongji"></param>
    /// <returns></returns>
    public static int update_data(string zhonglei,  DateTime old_product_date, DateTime product_date, double product_hour, double yongmeichangshu,
       double meichangzhong, double yongmeizongliang, double meimimeihao, double ganfa, double shifa, double kuntu,
        double ersanban, double yahua, double rouwen, double zongji)
    {
        string sql = @"update meihao_product set  product_date = @product_date, product_hour = @product_hour, yongmeichangshu = @yongmeichangshu, meichangzhong = @meichangzhong,
             yongmeizongliang = @yongmeizongliang, meimimeihao = @meimimeihao, ganfa = @ganfa, shifa = @shifa, kuntu = @kuntu, ersanban = @ersanban, yahua = @yahua, rouwen = @rouwen, zongji = @zongji ";
        string sqlwhere = "where zhonglei = @zhonglei and product_date = @old_product_date";
        sql = sql + sqlwhere;
        SqlParameter[] param = sqlparameters(zhonglei, product_date, product_hour, yongmeichangshu, meichangzhong,
            yongmeizongliang, meimimeihao, ganfa, shifa, kuntu, ersanban, yahua, rouwen, zongji);
        SqlParameter old_product_date_param = new SqlParameter("@old_product_date", old_product_date);
        param[param.Length] = old_product_date_param;
        return db.databasic(sql, param);
    }

    public static int delete_data(string zhonglei, DateTime product_date)
    {
        string sql = @"delete from meihao_product where zhonglei = @zhnglei and product_date = @product_date";
        SqlParameter[] param =  new SqlParameter[]{
            new SqlParameter("@zhonglei",zhonglei),
            new SqlParameter("@product_date",product_date.ToString())};
        return db.databasic(sql, param);
    }

    /// <summary>
    /// sqlparameters 对应于数据库中表单中的字段，防止sql注入
    /// </summary>
    /// <param name="zhonglei"></param>
    /// <param name="product_date"></param>
    /// <param name="product_hour"></param>
    /// <param name="yongmeichangshu"></param>
    /// <param name="meichangzhong"></param>
    /// <param name="yongmeizongliang"></param>
    /// <param name="meimimeihao"></param>
    /// <param name="ganfa"></param>
    /// <param name="shifa"></param>
    /// <param name="kuntu"></param>
    /// <param name="ersanban"></param>
    /// <param name="yahua"></param>
    /// <param name="rouwen"></param>
    /// <param name="zongji"></param>
    /// <returns></returns>
    private static SqlParameter[] sqlparameters(string zhonglei, DateTime product_date, double product_hour, double yongmeichangshu,
       double meichangzhong, double yongmeizongliang, double meimimeihao, double ganfa, double shifa, double kuntu,
        double ersanban, double yahua, double rouwen, double zongji)
    {
        SqlParameter[] sqlparams = new SqlParameter[]{
            new SqlParameter("@zhonglei",zhonglei),
            new SqlParameter("@product_date",product_date.ToString()),
            new SqlParameter("@product_hour",product_hour),
            new SqlParameter("@yongmeichangshu",yongmeichangshu),
            new SqlParameter("@meichangzhong",meichangzhong),
            new SqlParameter("@yongmeizongliang",yongmeizongliang),
            new SqlParameter("@meimimeihao",meimimeihao),
            new SqlParameter("@ganfa",ganfa),
            new SqlParameter("@shifa",shifa),
            new SqlParameter("@kuntu",kuntu),
            new SqlParameter("@ersanban",ersanban),
            new SqlParameter("@yahua",yahua),
            new SqlParameter("@rouwen",rouwen),
            new SqlParameter("@zongji",zongji)
        };
        return sqlparams;
    }
}