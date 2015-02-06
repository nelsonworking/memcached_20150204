using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MemcachedProviders.Cache;

public partial class _001 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DistCache.Add("myname", TextBox1.Text);

        //給此變數設定 Expiration
        //DistCache.Add("myname", TextBox1.Text, DateTime.Today.AddDays(1) - DateTime.Now);
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        object c1 = DistCache.Get("myname");
        Label1.Text = Convert.ToString(c1);
    }
}