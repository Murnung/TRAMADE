using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace TRAMADE.Formularios_Login__Menú.Clases
{
    public class clsDBCon
    {
        clsConexion cn = new clsConexion();
        public string[] nombre;
        public byte[] rostro;
        public List<byte[]> rostros = new List<byte[]>();
        public int totalUsuarios;

        // Guarda la imagen facial usando el PA
        public bool guardarImagen(int idUsuario, byte[] imagen)
        {
            try
            {
                cn.Abrir();
                SqlCommand comando = new SqlCommand("PA_GUARDAR_IMAGEN_FACIAL", cn.SqlC);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                comando.Parameters.Add("@imagen_facial", SqlDbType.VarBinary, -1).Value = imagen;
                int resultado = comando.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar imagen: " + ex.Message);
            }
            finally
            {
                cn.Cerrar();
            }
        }

        // Carga usuarios activos con imagen facial registrada
        public DataTable ObtenerBytesImagen()
        {
            try
            {
                cn.Abrir();
                string consulta = @"SELECT id_usuario, nombre_usuario, imagen_facial 
                                    FROM USUARIO 
                                    WHERE id_estado = 1 
                                    AND imagen_facial IS NOT NULL";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, cn.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                int count = dt.Rows.Count;
                nombre = new string[count];
                rostros.Clear();

                for (int i = 0; i < count; i++)
                {
                    nombre[i] = dt.Rows[i]["nombre_usuario"].ToString();
                    rostro = (byte[])dt.Rows[i]["imagen_facial"];
                    rostros.Add(rostro);
                }

                totalUsuarios = count;
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener imágenes: " + ex.Message);
            }
            finally
            {
                cn.Cerrar();
            }
        }

        // Convierte imagen a bytes y llama al PA
        public void convertirImgABinary(int idUsuario, Image img)
        {
            using (Bitmap bmp = new Bitmap(img))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                guardarImagen(idUsuario, ms.ToArray());
            }
        }

        // Convierte bytes de BD a Image
        public Image convertirByteAImg(int con)
        {
            MemoryStream ms = new MemoryStream(rostros[con]);
            return Image.FromStream(ms);
        }

        // Registra inicio de sesión
        public void registrarInicioSesion(int idUsuario)
        {
            try
            {
                cn.Abrir();
                string sql = @"INSERT INTO INICIO_DE_SESION (id_usuario, fecha_inicio_de_sesion)
                               VALUES (@id, GETDATE())";
                SqlCommand comm = new SqlCommand(sql, cn.SqlC);
                comm.Parameters.AddWithValue("@id", idUsuario);
                comm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar sesión: " + ex.Message);
            }
            finally
            {
                cn.Cerrar();
            }
        }
    }
}