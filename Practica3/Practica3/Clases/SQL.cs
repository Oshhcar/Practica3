using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Descripción breve de SQL
/// </summary>
public class SQL
{
    public SQL()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

	public void insertarUsuario(String nombre, String usuario, String correo, String contraseña)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();
            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario
                String accion = "INSERT INTO USUARIO(nombre, usuario, correo, contraseña) VALUES (@a, @b, @c, @d);";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@a", nombre);
                comando.Parameters.AddWithValue("@b", usuario);
                comando.Parameters.AddWithValue("@c", correo);
                comando.Parameters.AddWithValue("@d", contraseña);

                try
                {
                    comando.ExecuteScalar();
                    conectar.Close();
                    //return 1;


                }
                catch (Exception e)
                {
                    conectar.Close();
                    //return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                //return 0;
            }
        }

        public String verificarNombreUsuario(String usuario)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();

            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario
                String accion = "SELECT count(codigo) FROM Usuario WHERE usuario = @usuario;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@usuario", usuario);

                try
                {
                    string resultado = (comando.ExecuteScalar()).ToString();                    
                    conectar.Close();
                    return resultado;

                }
                catch (Exception e)
                {
                    conectar.Close();
                    return "No";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());               
                return "No";
            }
        }

        public String verificarContraseña(String codigo)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();

            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario
                String accion = "SELECT contraseña FROM Usuario WHERE codigo = @codigo;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@codigo", codigo);

                try
                {
                    string contraseña = (comando.ExecuteScalar()).ToString();
                    conectar.Close();
                    return contraseña;

                }
                catch (Exception e)
                {
                    conectar.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public String consultaSaldo(String codigo)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();
            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario

                String accion = "SELECT saldo FROM Usuario WHERE codigo = @codigo;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@codigo", codigo);

                try
                {
                    string saldo = (comando.ExecuteScalar()).ToString();
                    conectar.Close();
                    return saldo;

                }
                catch (Exception e)
                {
                    conectar.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
           
        }

        public String consultaNumeroCuenta(String usuario)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();
            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario

                String accion = "SELECT codigo FROM Usuario WHERE usuario = @usuario;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@usuario", usuario);

                try
                {
                    string codigo = (comando.ExecuteScalar()).ToString();
                    conectar.Close();
                    return codigo;

                }
                catch (Exception e)
                {
                    conectar.Close();
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }

        }

        public void Transferencia(String remite, String destino, String cantidad)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();
            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario

                String accion = "INSERT INTO TRANSFERENCIA VALUES (@a, @b, @c);";
                String accion2 = "UPDATE USUARIO SET saldo = saldo -@c WHERE codigo = @a;";
                String accion3 = "UPDATE USUARIO SET saldo = saldo +@c WHERE codigo = @b;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);
                SqlCommand comando2 = new SqlCommand(accion2, conectar);
                SqlCommand comando3 = new SqlCommand(accion3, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@a", remite);
                comando.Parameters.AddWithValue("@b", destino);
                comando.Parameters.AddWithValue("@c", cantidad);

                comando2.Parameters.AddWithValue("@a", remite);
                comando2.Parameters.AddWithValue("@c", cantidad);

                comando3.Parameters.AddWithValue("@b", destino);
                comando3.Parameters.AddWithValue("@c", cantidad);


                try
                {
                    comando.ExecuteScalar();
                    comando2.ExecuteScalar();
                    comando3.ExecuteScalar();
                    conectar.Close();
                    

                }
                catch (Exception e)
                {
                    conectar.Close();
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                
            }
            }

        public void Acreditar(String destino, String descripcion, String tipo, String cantidad)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();
            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario

                String accion = "INSERT INTO TRANSACCION VALUES (@a, @b, @c, @d);";
                String accion2 = "UPDATE USUARIO SET saldo = saldo +@d WHERE codigo = @a;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);
                SqlCommand comando2 = new SqlCommand(accion2, conectar);                

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@a", destino);
                comando.Parameters.AddWithValue("@b", descripcion);
                comando.Parameters.AddWithValue("@c", tipo);
                comando.Parameters.AddWithValue("@d", cantidad);

                comando2.Parameters.AddWithValue("@d", cantidad);
                comando2.Parameters.AddWithValue("@a", destino);


                try
                {
                    comando.ExecuteScalar();
                    comando2.ExecuteScalar();
                    conectar.Close();


                }
                catch (Exception e)
                {
                    conectar.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }

        public void Debitar(String destino, String descripcion, String tipo, String cantidad)
        {
            //crear un objeto de tipo conexión
            SqlConnection conectar = Conexion.RecibirConexion();
            try
            {
                //Abrir la conexión
                conectar.Open();
                //Sentencia SQL para obtener la contraseña dado un nombre de usuario

                String accion = "INSERT INTO TRANSACCION VALUES (@a, @b, @c, @d);";
                String accion2 = "UPDATE USUARIO SET saldo = saldo -@d WHERE codigo = @a;";
                //Crear un objeto de tipo SqlCommand y de parámetro vamos a enviar el String 
                SqlCommand comando = new SqlCommand(accion, conectar);
                SqlCommand comando2 = new SqlCommand(accion2, conectar);

                //Para agregar un parametro al where usuario = @usuario
                comando.Parameters.AddWithValue("@a", destino);
                comando.Parameters.AddWithValue("@b", descripcion);
                comando.Parameters.AddWithValue("@c", tipo);
                comando.Parameters.AddWithValue("@d", cantidad);

                comando2.Parameters.AddWithValue("@d", cantidad);
                comando2.Parameters.AddWithValue("@a", destino);

                try
                {
                    comando.ExecuteScalar();
                    comando2.ExecuteScalar();
                    conectar.Close();


                }
                catch (Exception e)
                {
                    conectar.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }
}
