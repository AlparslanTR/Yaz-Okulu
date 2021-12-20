using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;

public partial class OgrenciSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt32(Request.QueryString["ORID"]);
        EntityOgrenci ent = new EntityOgrenci();
        ent.ORID = x;
        BLLOgrenci.OgrenciSilBll(ent.ORID);
        Response.Redirect("OgrenciListesi.aspx");
    }
}