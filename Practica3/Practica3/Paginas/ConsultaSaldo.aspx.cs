using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P3.Clases;

namespace P3.Paginas
{
    public partial class ConsultaSaldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuarioactual = (string)(Session["Usuario"]);
            string cuenta = (string)(Session["Codigo"]);
            SQL consulta = new SQL();            
            
            string s = consulta.consultaSaldo(cuenta);
            string saldo = "Q. " + s;

            TextBox1.Text = cuenta;
            TextBox2.Text = usuarioactual;
            TextBox3.Text = saldo;

        }
    }
}