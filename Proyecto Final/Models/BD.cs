using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;


namespace Proyecto_final.Models
{
    public static class BD
    {

        private static string _connectionString = "Server=localhost;Database=EMPRESA;User Id=alumno; Password =alumno1;";

        public static string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        private static SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }

        public static void Desconectar(SqlConnection conn)
        {
            conn.Close();
        }

        public static List<Inmueble> ObtenerTodosInmuebles()
        {
            List<Inmueble> lista = new List<Inmueble>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "SELECT * from Inmueble WHERE idUsuarioReserva is null";
            consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                int precio = Convert.ToInt32(dr["precio"]);
                int id = Convert.ToInt32(dr["id"]);
                int superficie = Convert.ToInt32(dr["superficie"]);
                int ambientes = Convert.ToInt32(dr["ambientes"]);
                bool patio = Convert.ToBoolean(dr["patio"]);
                bool terraza = Convert.ToBoolean(dr["terraza"]);
                string direccion = (dr["direccion"]).ToString();
                int baños = Convert.ToInt32(dr["baños"]);
                int habitaciones = Convert.ToInt32(dr["habitaciones"]);
                string imagen = (dr["imagen"]).ToString();

                Inmueble inmb = new Inmueble(precio, id, superficie, ambientes, patio, terraza, direccion, baños, habitaciones,imagen);

                lista.Add(inmb);
            }
            Desconectar(conn);
            return lista;
        }
        public static Usuario LogIn(Usuario miUsuario)
        {
            SqlConnection conn = Conectar();
            Usuario unUsuario = null;
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_LogIn";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@usu", miUsuario.NombreDeUsuario);
            consulta.Parameters.AddWithValue("@pass", miUsuario.Contraseña);
            SqlDataReader dr = consulta.ExecuteReader();
            if (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"]);
                string nombreDeUsuario = (dr["nombreDeUsuario"]).ToString();
                string nombre = (dr["nombre"]).ToString();
                string apellido = (dr["apellido"]).ToString();
                string contraseña = (dr["contraseña"]).ToString();

                unUsuario = new Usuario(id, nombreDeUsuario, nombre, apellido, contraseña);
            }

            Desconectar(conn);
            return unUsuario;
        }
        public static int ingresarPropiedad(Inmueble inmb)
        {
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_AgregarPropiedad";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@precio", inmb.Precio);
            consulta.Parameters.AddWithValue("@sup", inmb.Superficie);
            consulta.Parameters.AddWithValue("@amb", inmb.Ambientes);
            consulta.Parameters.AddWithValue("@patio", inmb.Patio);
            consulta.Parameters.AddWithValue("@terraza", inmb.Terraza);
            consulta.Parameters.AddWithValue("@direccion", inmb.Direccion);
            consulta.Parameters.AddWithValue("@baños", inmb.Baños);
            consulta.Parameters.AddWithValue("@habitaciones", inmb.Habitaciones);
            consulta.Parameters.AddWithValue("@imagen", inmb.Imagen);
            int datos = consulta.ExecuteNonQuery();
            Desconectar(conn);
            return datos;
        }
    
        public static int Registro(Usuario miUsuario)
        {
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_CrearUsuario";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@usu", miUsuario.NombreDeUsuario);
            consulta.Parameters.AddWithValue("@pass", miUsuario.Contraseña);
            consulta.Parameters.AddWithValue("@nom", miUsuario.Nombre);
            consulta.Parameters.AddWithValue("@ape", miUsuario.Apellido);
            int datos = consulta.ExecuteNonQuery();
            Desconectar(conn);
            return datos;
        }

        public static int Reserva(int id, int idUsuario)
        {
            
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_ReservarPropiedad";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            consulta.Parameters.AddWithValue("@idUsuario", idUsuario);
            consulta.Parameters.AddWithValue("@idInmueble", id);

            int datos = consulta.ExecuteNonQuery();
            Desconectar(conn);
            return datos;
        }

        public static List<Tipos> ObtenerTodosLosTipos()
        {
            List<Tipos> lista = new List<Tipos>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_ObtenerTodosLosTipos";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                string tipo = (dr["tipo"]).ToString();
                int id = Convert.ToInt32(dr["id"]);

                Tipos a = new Tipos(id, tipo);

                lista.Add(a);
            }
            Desconectar(conn);
            return lista;
        }

        public static List<Barrios> ObtenerTodosLosBarrios()
        {
            List<Barrios> lista = new List<Barrios>();
            SqlConnection conn = Conectar();
            SqlCommand consulta = conn.CreateCommand();
            consulta.CommandText = "sp_ObtenerTodosLosBarrios";
            consulta.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = consulta.ExecuteReader();
            while (dr.Read())
            {
                int idBarrio = Convert.ToInt32(dr["IdBarrio"]);
                string barrio = (dr["barrio"]).ToString();

                Barrios a = new Barrios(idBarrio, barrio);

                lista.Add(a);
            }
            Desconectar(conn);
            return lista;
        }

    }
}

