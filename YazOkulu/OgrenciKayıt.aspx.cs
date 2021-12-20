using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;

public partial class OgrenciKayıt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.ORADSOYAD = TextBox1.Text;
        ent.ORNUMARA = TextBox2.Text;
        ent.ORSIFRE = TextBox3.Text;
        ent.ORFOTOGRAF = TextBox4.Text;
        BLLOgrenci.OgrenciEkleBLL(ent);
        Response.Write("<script>alert('Öğrenci Kaydedildi');</script>");
    }
}