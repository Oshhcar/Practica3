using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using P3.Clases;

namespace P3.Paginas
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label1.Visible = false;
            Button2.Visible = false;
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String nombre = Convert.ToString(TextBox1.Text);
            String usuario = Convert.ToString(TextBox2.Text);
            String correo = Convert.ToString(TextBox3.Text);
            String contraseña = Convert.ToString(TextBox4.Text);
            String bandera;

            SQL consulta = new SQL();

            //bandera = consulta.insertarUsuario(nombre, usuario, correo, contraseña);
            bandera = consulta.verificarNombreUsuario(usuario);            

            if (bandera.Equals("0"))
            {
                consulta.insertarUsuario(nombre, usuario, correo, contraseña);
                System.Diagnostics.Debug.Write("Usuario creado con exito");
                Response.Write("<script>window.alert('Usuario creado con exito');</script>");
                //Response.Redirect("/Paginas/Login.aspx", true);
                String num = consulta.consultaNumeroCuenta(usuario);                
                String texto = "No de cuenta: " + num;
                Label1.Text = texto;
                Label1.Visible = true;
                Button1.Visible = false;
                Button2.Visible = true;

            }
            else
            {
                System.Diagnostics.Debug.Write("Nombre de usuario no disponible");
                Response.Write("<script>window.alert('No se ha podido crear el usuario');</script>");
                Label1.Text = "Nombre de usuario no disponible";
                Label1.Visible = true;
            }
            
            
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Paginas/Login.aspx", true);
        }
    }
}