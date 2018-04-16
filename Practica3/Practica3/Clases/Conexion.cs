using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Conexion
/// </summary>
public class Conexion
{
    public Conexion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    //Conexión a la base de datos
    private static SqlConnection conexion = new SqlConnection
        (
        "Data Source=DESKTOP-DV9JSGM\\SQLEXPRESS; Initial Catalog=ANALISIS_P3; Integrated Security=True;"
        );

    public static SqlConnection RecibirConexion()
    {
        return conexion;
    }
}