using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TRAMADE.Formularios_Login__Menú.Clases
{
    public class clsDBCon
    {
        clsConexion cn = new clsConexion();
        public string[] nombre;
        public byte[] rostro;
        public List<byte[]> rostros = new List<byte[]>();
        public int totalUsuarios;

        // ── GUARDAR IMAGEN (reemplaza) ─────────────────────────────
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

        // ── OBTENER IMÁGENES PARA ENTRENAMIENTO ────────────────────
        public DataTable ObtenerBytesImagen()
        {
            try
            {
                cn.Abrir();
                // ✅ ORDER BY para que imágenes del mismo usuario queden juntas
                string consulta = @"SELECT u.id_usuario, u.nombre_usuario, i.imagen_facial 
                                    FROM IMAGEN_FACIAL i
                                    INNER JOIN USUARIO u ON i.id_usuario = u.id_usuario
                                    WHERE u.id_estado = 1
                                    ORDER BY u.id_usuario";

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

        // ── CONVERTIR IMAGEN A BINARY ──────────────────────────────
        public void convertirImgABinary(int idUsuario, Image img)
        {
            using (Bitmap bmp = new Bitmap(img))
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                guardarImagen(idUsuario, ms.ToArray());
            }
        }

        // ── CONVERTIR BYTES A IMAGE ────────────────────────────────
        public Image convertirByteAImg(int con)
        {
            MemoryStream ms = new MemoryStream(rostros[con]);
            return Image.FromStream(ms);
        }

        // ── REGISTRAR INICIO DE SESIÓN ─────────────────────────────
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

        // ── LLENAR COMBO USUARIOS ──────────────────────────────────
        internal static void llenarComboUsuarios(Krypton.Toolkit.KryptonComboBox cmb,
            clsConexion conexion)
        {
            try
            {
                conexion.Abrir();
                string consulta = "SELECT id_usuario, nombre_usuario " +
                                  "FROM USUARIO WHERE id_estado = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion.SqlC);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmb.DataSource = dt;
                cmb.DisplayMember = "nombre_usuario";
                cmb.ValueMember = "id_usuario";
                cmb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        // ── INSERTAR IMAGEN FACIAL (agrega, no reemplaza) ──────────
        public bool insertarImagenFacial(int idUsuario, byte[] imagen)
        {
            try
            {
                cn.Abrir();
                SqlCommand comando = new SqlCommand("PA_INSERTAR_IMAGEN_FACIAL", cn.SqlC);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                comando.Parameters.Add("@imagen_facial", SqlDbType.VarBinary, -1).Value = imagen;
                int resultado = comando.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar imagen: " + ex.Message);
            }
            finally
            {
                cn.Cerrar();
            }
        }

        // ── ELIMINAR IMÁGENES DE UN USUARIO ───────────────────────
        public bool eliminarImagenesUsuario(int idUsuario)
        {
            try
            {
                cn.Abrir();
                SqlCommand comando = new SqlCommand("PA_ELIMINAR_IMAGENES_USUARIO", cn.SqlC);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id_usuario", idUsuario);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar imágenes: " + ex.Message);
            }
            finally
            {
                cn.Cerrar();
            }
        }
    }
}