using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;
public partial class OgrenciGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        int x = Convert.ToInt32(Request.QueryString["ORID"]);
        TextBox5.Text = x.ToString();
        TextBox5.Enabled = false;
        if (Page.IsPostBack==false)
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.BLLLDetay(x);
            TextBox1.Text = OgrList[0].ORADSOYAD.ToString();
            TextBox2.Text = OgrList[0].ORNUMARA.ToString();
            TextBox3.Text = OgrList[0].ORFOTOGRAF.ToString();
            TextBox4.Text = OgrList[0].ORSIFRE.ToString();
        }
        
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.ORADSOYAD = TextBox1.Text;
        ent.ORNUMARA = TextBox2.Text;
        ent.ORFOTOGRAF = TextBox3.Text;
        ent.ORSIFRE = TextBox4.Text;
        ent.ORID = Convert.ToInt32(TextBox5.Text);
        BLLOgrenci.OgrenciGuncelle(ent);
        Response.Redirect("OgrenciListesi.aspx");
    }
}