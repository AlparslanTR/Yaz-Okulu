using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;


public partial class Ogretmenler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<EntityOgretmen> OgretmenList = BLLOgretmen.BLListele();
        Repeater1.DataSource = OgretmenList;
        Repeater1.DataBind();
    }
}