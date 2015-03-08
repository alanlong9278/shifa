using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
///D_shifa_daily_prise 的摘要说明
/// </summary>
public class D_shifa_daily_prise
{
	public D_shifa_daily_prise()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}

    /// <summary>
    /// 插入数据
    /// </summary>
    /// <param name="Beisi_name"></param>
    /// <param name="Product_date"></param>
    /// <param name="banzu"></param>
    /// <param name="gangshu"></param>
    /// <param name="DMF_at"></param>
    /// <param name="S_80_at"></param>
    /// <param name="qianweifen_66_at"></param>
    /// <param name="qianweifen_at"></param>
    /// <param name="huangmufen_at"></param>
    /// <param name="zhijiangfen_at"></param>
    /// <param name="CaCo3_at"></param>
    /// <param name="HDW_3100_at"></param>
    /// <param name="HDW_3300_at"></param>
    /// <param name="HDW_3050T_at"></param>
    /// <param name="W_Z551_at"></param>
    /// <param name="W_Z001_at"></param>
    /// <param name="DMF"></param>
    /// <param name="S_80"></param>
    /// <param name="qianweifen_66"></param>
    /// <param name="qianweifen"></param>
    /// <param name="huangmufen"></param>
    /// <param name="zhijiangfen"></param>
    /// <param name="CaCo3"></param>
    /// <param name="HDW_3100"></param>
    /// <param name="HDW_3300"></param>
    /// <param name="HDW_3050T"></param>
    /// <param name="W_Z551"></param>
    /// <param name="W_Z001"></param>
    /// <param name="total_cailiao_weight"></param>
    /// <param name="Hanjin_DMF_at"></param>
    /// <param name="Hanjin_HDW_3050T_at"></param>
    /// <param name="Hanjin_w_Z551_at"></param>
    /// <param name="Hanjin_HX_7046a_at"></param>
    /// <param name="Hanjin_huaweihei_at"></param>
    /// <param name="Hanjin_DMF"></param>
    /// <param name="Hanjin_HDW_3050T"></param>
    /// <param name="Hanjin_w_Z551"></param>
    /// <param name="Hanjin_HX_7046a"></param>
    /// <param name="Hanjin_huaweihei"></param>
    /// <param name="total_yongliao_weight"></param>
    /// <param name="total_yongliao_prise"></param>
    /// <param name="yongliao_prise"></param>
    /// <param name="mianliaodanhao"></param>
    /// <param name="zhongjianmishu"></param>
    /// <param name="yidengmishu"></param>
    /// <param name="dengjipinlv"></param>
    /// <param name="jibu_name"></param>
    /// <param name="jibu_prise"></param>
    /// <param name="jibushiyongmishu"></param>
    /// <param name="jibushiyongzongjia"></param>
    /// <param name="beisi_prise"></param>
    /// <param name="boli"></param>
    /// <param name="isComplete"></param>
    /// <returns></returns>
    public static int insert_data(string Beisi_name, DateTime Product_date, string banzu, int gangshu,
      double DMF_at, double S_80_at, double qianweifen_66_at, double qianweifen_at, double huangmufen_at, double zhijiangfen_at,
       double CaCo3_at, double HDW_3100_at, double HDW_3300_at, double HDW_3050T_at,
        double W_Z551_at, double W_Z001_at, double DMF, double S_80, double qianweifen_66, double qianweifen,
       double huangmufen, double zhijiangfen, double CaCo3, double HDW_3100,
        double HDW_3300, double HDW_3050T, double W_Z551, double W_Z001, double total_cailiao_weight, double Hanjin_DMF_at,
       double Hanjin_HDW_3050T_at, double Hanjin_w_Z551_at, double Hanjin_HX_7046a_at, double Hanjin_huaweihei_at,
        double Hanjin_DMF, double Hanjin_HDW_3050T, double Hanjin_w_Z551, double Hanjin_HX_7046a, double Hanjin_huaweihei, double total_yongliao_weight,
       double total_yongliao_prise, double yongliao_prise, double mianliaodanhao, double zhongjianmishu,
    double yidengmishu, double dengjipinlv, double jibu_name, double jibu_prise, double jibushiyongmishu, double jibushiyongzongjia,
       double beisi_prise, double boli, string isComplete)
    {
        string sql = @"insert into shifa_daily_prise ( Beisi_name, Product_date, banzu, gangshu,
            DMF_at, S_80_at, qianweifen_66_at, qianweifen_at, huangmufen_at, zhijiangfen_at,
            CaCo3_at, HDW_3100_at, HDW_3300_at, HDW_3050T_at,
             W_Z551_at, W_Z001_at, DMF, S_80, qianweifen_66, qianweifen,
            huangmufen, zhijiangfen, CaCo3, HDW_3100,
             HDW_3300, HDW_3050T, W_Z551, W_Z001, total_cailiao_weight, Hanjin_DMF_at,
            Hanjin_HDW_3050T_at, Hanjin_w_Z551_at, Hanjin_HX_7046a_at, Hanjin_huaweihei_at,
             Hanjin_DMF, Hanjin_HDW_3050T, Hanjin_w_Z551, Hanjin_HX_7046a, Hanjin_huaweihei, total_yongliao_weight,
            total_yongliao_prise, yongliao_prise, mianliaodanhao, zhongjianmishu,
           yidengmishu, dengjipinlv, jibu_name, jibu_prise, jibushiyongmishu, jibushiyongzongjia,
            beisi_prise, boli, isComplete) values (@Beisi_name, @Product_date, @banzu, @gangshu,
            @DMF_at, @S_80_at, @qianweifen_66_at, @qianweifen_at, @huangmufen_at, @zhijiangfen_at,
            @CaCo3_at, @HDW_3100_at, @HDW_3300_at, @HDW_3050T_at,
             @W_Z551_at, @W_Z001_at, @DMF, @S_80, @qianweifen_66, @qianweifen,
            @huangmufen, @zhijiangfen, @CaCo3, @HDW_3100,
             @HDW_3300, @HDW_3050T, @W_Z551, @W_Z001, @total_cailiao_weight, @Hanjin_DMF_at,
            @Hanjin_HDW_3050T_at, @Hanjin_w_Z551_at, @Hanjin_HX_7046a_at, @Hanjin_huaweihei_at,
             @Hanjin_DMF, @Hanjin_HDW_3050T, @Hanjin_w_Z551, @Hanjin_HX_7046a, @Hanjin_huaweihei, @total_yongliao_weight,
            @total_yongliao_prise, @yongliao_prise, @mianliaodanhao, @zhongjianmishu,
           @yidengmishu, @dengjipinlv, @jibu_name, @jibu_prise, @jibushiyongmishu, @jibushiyongzongjia,
            @beisi_prise, @boli, @isComplete)";
        SqlParameter[] param = sqlparameters(Beisi_name, Product_date, banzu, gangshu,
            DMF_at, S_80_at, qianweifen_66_at, qianweifen_at, huangmufen_at, zhijiangfen_at,
            CaCo3_at, HDW_3100_at, HDW_3300_at, HDW_3050T_at,
             W_Z551_at, W_Z001_at, DMF, S_80, qianweifen_66, qianweifen,
            huangmufen, zhijiangfen, CaCo3, HDW_3100,
             HDW_3300, HDW_3050T, W_Z551, W_Z001, total_cailiao_weight, Hanjin_DMF_at,
            Hanjin_HDW_3050T_at, Hanjin_w_Z551_at, Hanjin_HX_7046a_at, Hanjin_huaweihei_at,
             Hanjin_DMF, Hanjin_HDW_3050T, Hanjin_w_Z551, Hanjin_HX_7046a, Hanjin_huaweihei, total_yongliao_weight,
            total_yongliao_prise, yongliao_prise, mianliaodanhao, zhongjianmishu,
           yidengmishu, dengjipinlv, jibu_name, jibu_prise, jibushiyongmishu, jibushiyongzongjia,
            beisi_prise, boli, isComplete); 
        return db.databasic(sql, param); 
    }



    public static int update_data(string Beisi_name, DateTime Product_date_old, DateTime Product_date, string banzu, int gangshu,
     double DMF_at, double S_80_at, double qianweifen_66_at, double qianweifen_at, double huangmufen_at, double zhijiangfen_at,
      double CaCo3_at, double HDW_3100_at, double HDW_3300_at, double HDW_3050T_at,
       double W_Z551_at, double W_Z001_at, double DMF, double S_80, double qianweifen_66, double qianweifen,
      double huangmufen, double zhijiangfen, double CaCo3, double HDW_3100,
       double HDW_3300, double HDW_3050T, double W_Z551, double W_Z001, double total_cailiao_weight, double Hanjin_DMF_at,
      double Hanjin_HDW_3050T_at, double Hanjin_w_Z551_at, double Hanjin_HX_7046a_at, double Hanjin_huaweihei_at,
       double Hanjin_DMF, double Hanjin_HDW_3050T, double Hanjin_w_Z551, double Hanjin_HX_7046a, double Hanjin_huaweihei, double total_yongliao_weight,
      double total_yongliao_prise, double yongliao_prise, double mianliaodanhao, double zhongjianmishu,
   double yidengmishu, double dengjipinlv, double jibu_name, double jibu_prise, double jibushiyongmishu, double jibushiyongzongjia,
      double beisi_prise, double boli, string isComplete)
    {
        string sql = @"update shifa_daily_prise set  Product_date = @Product_date,  gangshu = @gangshu,
            DMF_at = @DMF_at, S_80_at = @S_80_at, qianweifen_66_at = @qianweifen_66_at, qianweifen_at = @qianweifen_at, huangmufen_at = @huangmufen_at, zhijiangfen_at = @zhijiangfen_at,
            CaCo3_at = @CaCo3_at, HDW_3100_at = @HDW_3100_at, HDW_3300_at = @HDW_3300_at, HDW_3050T_at = @HDW_3050T_at,
             W_Z551_at = @W_Z551_at, W_Z001_at = @W_Z001_at, DMF = @DMF, S_80 = @S_80, qianweifen_66 = @qianweifen_66, qianweifen = @qianweifen,
            huangmufen = @huangmufen, zhijiangfen = @zhijiangfen, CaCo3 = @CaCo3, HDW_3100 = @HDW_3100,
             HDW_3300 = @HDW_3300, HDW_3050T = @HDW_3050T, W_Z551 = @W_Z551, W_Z001 = @W_Z001, total_cailiao_weight = @total_cailiao_weight, Hanjin_DMF_at = @Hanjin_DMF_at,
            Hanjin_HDW_3050T_at = @Hanjin_HDW_3050T_at, Hanjin_w_Z551_at = @Hanjin_w_Z551_at, Hanjin_HX_7046a_at = @Hanjin_HX_7046a_at, Hanjin_huaweihei_at = @Hanjin_huaweihei_at,
             Hanjin_DMF = @Hanjin_DMF, Hanjin_HDW_3050T = @Hanjin_HDW_3050T, Hanjin_w_Z551 = @Hanjin_w_Z551, Hanjin_HX_7046a = @Hanjin_HX_7046a, Hanjin_huaweihei = @Hanjin_huaweihei, total_yongliao_weight = @total_yongliao_weight,
            total_yongliao_prise = @total_yongliao_prise, yongliao_prise = @yongliao_prise, mianliaodanhao = @mianliaodanhao, zhongjianmishu = @zhongjianmishu,
           yidengmishu = @yidengmishu, dengjipinlv = @dengjipinlv, jibu_name = @jibu_name, jibu_prise = @jibu_prise, jibushiyongmishu = @jibushiyongmishu, jibushiyongzongjia = @jibushiyongzongjia,
            beisi_prise = @beisi_prise, boli = @boli, isComplete = @isComplete ";
        string sqlwhere = " where Beisi_name = @Beisi_name and Product_date_old = @Product_date_old and banzu = @banzu";
        sql = sql + sqlwhere;
        SqlParameter[] param = sqlparameters(Beisi_name, Product_date, banzu, gangshu,
            DMF_at, S_80_at, qianweifen_66_at, qianweifen_at, huangmufen_at, zhijiangfen_at,
            CaCo3_at, HDW_3100_at, HDW_3300_at, HDW_3050T_at,
             W_Z551_at, W_Z001_at, DMF, S_80, qianweifen_66, qianweifen,
            huangmufen, zhijiangfen, CaCo3, HDW_3100,
             HDW_3300, HDW_3050T, W_Z551, W_Z001, total_cailiao_weight, Hanjin_DMF_at,
            Hanjin_HDW_3050T_at, Hanjin_w_Z551_at, Hanjin_HX_7046a_at, Hanjin_huaweihei_at,
             Hanjin_DMF, Hanjin_HDW_3050T, Hanjin_w_Z551, Hanjin_HX_7046a, Hanjin_huaweihei, total_yongliao_weight,
            total_yongliao_prise, yongliao_prise, mianliaodanhao, zhongjianmishu,
           yidengmishu, dengjipinlv, jibu_name, jibu_prise, jibushiyongmishu, jibushiyongzongjia,
            beisi_prise, boli, isComplete);
        SqlParameter[] sql_param = new SqlParameter[param.Length + 1];
        for (int i = 0; i < param.Length; i++)
        {
            sql_param[i] = param[i];
        }
        SqlParameter old_product_date_param = new SqlParameter("@Product_date_old", Product_date_old);
        sql_param[param.Length] = old_product_date_param;

        return db.databasic(sql, param);
    }


    public static int delete_data(int id)
    {
        SqlParameter[] param = new SqlParameter[] { new SqlParameter("@id", id) };
        string sql = "delete from shifa_daily_prise where ID = @id";
        return db.databasic(sql, param);
    }
   /// <summary>
   /// sqlparameters 对应于数据库中表单中的字段，防止sql注入
   /// </summary>
   /// <param name="Beisi_name"></param>
   /// <param name="Product_date"></param>
   /// <param name="banzu"></param>
   /// <param name="gangshu"></param>
   /// <param name="DMF_at"></param>
   /// <param name="S_80_at"></param>
   /// <param name="qianweifen_66_at"></param>
   /// <param name="qianweifen_at"></param>
   /// <param name="huangmufen_at"></param>
   /// <param name="zhijiangfen_at"></param>
   /// <param name="CaCo3_at"></param>
   /// <param name="HDW_3100_at"></param>
   /// <param name="HDW_3300_at"></param>
   /// <param name="HDW_3050T_at"></param>
   /// <param name="W_Z551_at"></param>
   /// <param name="W_Z001_at"></param>
   /// <param name="DMF"></param>
   /// <param name="S_80"></param>
   /// <param name="qianweifen_66"></param>
   /// <param name="qianweifen"></param>
   /// <param name="huangmufen"></param>
   /// <param name="zhijiangfen"></param>
   /// <param name="CaCo3"></param>
   /// <param name="HDW_3100"></param>
   /// <param name="HDW_3300"></param>
   /// <param name="HDW_3050T"></param>
   /// <param name="W_Z551"></param>
   /// <param name="W_Z001"></param>
   /// <param name="total_cailiao_weight"></param>
   /// <param name="Hanjin_DMF_at"></param>
   /// <param name="Hanjin_HDW_3050T_at"></param>
   /// <param name="Hanjin_w_Z551_at"></param>
   /// <param name="Hanjin_HX_7046a_at"></param>
   /// <param name="Hanjin_huaweihei_at"></param>
   /// <param name="Hanjin_DMF"></param>
   /// <param name="Hanjin_HDW_3050T"></param>
   /// <param name="Hanjin_w_Z551"></param>
   /// <param name="Hanjin_HX_7046a"></param>
   /// <param name="Hanjin_huaweihei"></param>
   /// <param name="total_yongliao_weight"></param>
   /// <param name="total_yongliao_prise"></param>
   /// <param name="yongliao_prise"></param>
   /// <param name="mianliaodanhao"></param>
   /// <param name="zhongjianmishu"></param>
   /// <param name="yidengmishu"></param>
   /// <param name="dengjipinlv"></param>
   /// <param name="jibu_name"></param>
   /// <param name="jibu_prise"></param>
   /// <param name="jibushiyongmishu"></param>
   /// <param name="jibushiyongzongjia"></param>
   /// <param name="beisi_prise"></param>
   /// <param name="boli"></param>
   /// <param name="isComplete"></param>
   /// <returns></returns>
    private static SqlParameter[] sqlparameters(string Beisi_name, DateTime Product_date, string banzu, int gangshu,
      double DMF_at, double S_80_at, double qianweifen_66_at, double qianweifen_at, double huangmufen_at, double zhijiangfen_at,
       double CaCo3_at, double HDW_3100_at, double HDW_3300_at, double HDW_3050T_at,
        double W_Z551_at, double W_Z001_at, double DMF, double S_80, double qianweifen_66, double qianweifen,
       double huangmufen, double zhijiangfen, double CaCo3, double HDW_3100,
        double HDW_3300, double HDW_3050T, double W_Z551, double W_Z001, double total_cailiao_weight, double Hanjin_DMF_at,
       double Hanjin_HDW_3050T_at, double Hanjin_w_Z551_at, double Hanjin_HX_7046a_at, double Hanjin_huaweihei_at,
        double Hanjin_DMF, double Hanjin_HDW_3050T, double Hanjin_w_Z551, double Hanjin_HX_7046a, double Hanjin_huaweihei, double total_yongliao_weight,
       double total_yongliao_prise, double yongliao_prise, double mianliaodanhao, double zhongjianmishu,
    double yidengmishu, double dengjipinlv, double jibu_name, double jibu_prise, double jibushiyongmishu, double jibushiyongzongjia,
       double beisi_prise, double boli, string isComplete)
    {
        SqlParameter[] sqlparams = new SqlParameter[]{
            new SqlParameter("@Beisi_name",Beisi_name),
            new SqlParameter("@Product_date",Product_date.ToString()),
            new SqlParameter("@banzu",banzu),
            new SqlParameter("@gangshu",gangshu),
            new SqlParameter("@DMF_at",DMF_at),
            new SqlParameter("@S_80_at",S_80_at),
            new SqlParameter("@qianweifen_66_at",qianweifen_66_at),
            new SqlParameter("@qianweifen_at",qianweifen_at),
            new SqlParameter("@huangmufen_at",huangmufen_at),
            new SqlParameter("@zhijiangfen_at",zhijiangfen_at),
            new SqlParameter("@CaCo3_at",CaCo3_at),
            new SqlParameter("@HDW_3100_at",HDW_3100_at),
            new SqlParameter("@HDW_3300_at",HDW_3300_at),
            new SqlParameter("@HDW_3050T_at",HDW_3050T_at),
            new SqlParameter("@W_Z551_at",W_Z551_at),
            new SqlParameter("@W_Z001_at",W_Z001_at),
            new SqlParameter("@DMF",DMF),
            new SqlParameter("@S_80",S_80),
            new SqlParameter("@qianweifen_66",qianweifen_66),
            new SqlParameter("@qianweifen",qianweifen),
            new SqlParameter("@huangmufen",huangmufen),
            new SqlParameter("@zhijiangfen",zhijiangfen),
            new SqlParameter("@CaCo3",CaCo3),
            new SqlParameter("@HDW_3100",HDW_3100),
            new SqlParameter("@HDW_3300",HDW_3300),
            new SqlParameter("@HDW_3050T",HDW_3050T),
            new SqlParameter("@W_Z551",W_Z551),
            new SqlParameter("@W_Z001",W_Z001),
            new SqlParameter("@total_cailiao_weight",total_cailiao_weight),
            new SqlParameter("@Hanjin_DMF_at",Hanjin_DMF_at),
            new SqlParameter("@Hanjin_w_Z551_at",Hanjin_w_Z551_at),
            new SqlParameter("@Hanjin_HDW_3050T_at",Hanjin_HDW_3050T_at),
            new SqlParameter("@Hanjin_HX_7046a_at",Hanjin_HX_7046a_at),
            new SqlParameter("@Hanjin_huaweihei_at",Hanjin_huaweihei_at),
            new SqlParameter("@Hanjin_DMF",Hanjin_DMF),
            new SqlParameter("@Hanjin_HDW_3050T",Hanjin_HDW_3050T),

             new SqlParameter("@Hanjin_w_Z551",Hanjin_w_Z551),
            new SqlParameter("@Hanjin_HX_7046a",Hanjin_HX_7046a),
            new SqlParameter("@Hanjin_huaweihei",Hanjin_huaweihei),
            new SqlParameter("@total_yongliao_weight",total_yongliao_weight),
            new SqlParameter("@total_yongliao_prise",total_yongliao_prise),
            new SqlParameter("@yongliao_prise",yongliao_prise),
            new SqlParameter("@mianliaodanhao",mianliaodanhao),
            new SqlParameter("@zhongjianmishu",zhongjianmishu),
            new SqlParameter("@yidengmishu",yidengmishu),
            new SqlParameter("@dengjipinlv",dengjipinlv),
            new SqlParameter("@jibu_name",jibu_name),
            new SqlParameter("@jibu_prise",jibu_prise),
            new SqlParameter("@jibushiyongmishu",jibushiyongmishu),
            new SqlParameter("@jibushiyongzongjia",jibushiyongzongjia),
            new SqlParameter("@beisi_prise",beisi_prise),
            new SqlParameter("@boli",boli),
            new SqlParameter("@isComplete",isComplete)
        };
        return sqlparams;
    }
}