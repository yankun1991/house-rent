﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class supply : System.Web.UI.Page
{
   
    protected string con = CommonLib.SqlHelper.SqlConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string mname = HttpUtility.UrlDecode(Request.Cookies["buy"]["user"]);
        string sql = "insert into liuyan(title,uid,contents)values('" + TextBox1.Text + "','" + mname + "','" + TextBox2.Text + "')";
        CommonLib.SqlHelper.ExecuteNonQuery(con, CommandType.Text, sql, null);
        CommonLib.JavaScriptHelper.Alert("留言成功", Page);



    }
}
