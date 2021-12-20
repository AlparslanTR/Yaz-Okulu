using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;

public partial class Dersler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack==false)
        {
            List<EntityDers> EntDers = BLLDers.BLLListele();
            DropDownList1.DataSource = BLLDers.BLLListele();
            DropDownList1.DataTextField = "DERSAD";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataBind();
        }
        List<EntityDers> EntDers2 = BLLDers.BLLListele();
        Repeater1.DataSource = EntDers2;
        Repeater1.DataBind();
    }



    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityBasvuru ent = new EntityBasvuru();
        ent.ORBASVURUID = Convert.ToInt32(TextBox1.Text);
        ent.BASVURUDERSID = Convert.ToInt32(DropDownList1.SelectedValue.ToString());
        BLLDers.TalepEkleBLL(ent);
    }
}