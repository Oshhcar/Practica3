using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuario
/// </summary>
public class Usuario
{
    public Usuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Login(String cuenta, String usuario, String contraseña)
    {
        //1 = correcta
        //0 = incorrecta
        //2 = no existe nombre de usuario o cuenta. 
        SQL mi_consulta = new SQL();


        try
        {
            String contraseñaTomada = mi_consulta.verificarContraseña(cuenta);
            if (contraseñaTomada.Equals(contraseña))
            {
                System.Diagnostics.Debug.Write("Nombre de usuario y contraseña correctos");
                return 1;

            }
            else
            {
                System.Diagnostics.Debug.Write("Nombre de usuario y contraseña incorrectos");
                return 0;
            }

        }
        catch
        {
            System.Diagnostics.Debug.Write("Nombre de usuario no existe");
            return 2;
        }
    }
}