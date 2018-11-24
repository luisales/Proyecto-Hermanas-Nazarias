﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Collections;

namespace Hermanas_nazario
{
    public class Base_de_datos
    {
        protected DataTable Resultado;
        public static string Nombre1;
        public static string Nombre2;
        public static string Apellido1;
        public static int decis = 0, b;
        public static string Apellid2;
        public static string Lugar;
        public static string Fecha;
        public static string NombreP;
        public static string NombreM;
        public static string nombre1_empleado;
        public static string nombre2_empleado;
        public static string apellido1_empleado;
        public static string apellido2_empleado;
        public static string correo_empleado;
        public static string numero_identidad_empleado;
        public static string sexo_empleado;
        public static string numero_telefono_empleado;
        public static string cargo_empleado;
        public static string Identidad;
        public static string Sexo;
        public static string Riesgo;
        public static string dia;
        public static string mes;
        public static string anio;
        public static string contra;
        public static string cita = "";
        public static string Cod = "";
        public static string nommedi;
        public static string cant;
        public static string desc;
        public static string CodMed;
        public static int numero;
        public static string unidad;
        public static int rol;
        public static int cod_empleado;
        public static string User;
        public static string diagnostico, tratamiento, nombre_cita;
        public static ArrayList nombremedicamento = new ArrayList();
        public static ArrayList cantidadmedicamento = new ArrayList();
        public static string Ocupacion;
        public static string LugarT ;
        public static string Direccion ;
        public static string tel ;
        public static string telE;
        public static string Permisos;

        public static SqlConnection Conectar()
        {
           // SqlConnection con = new SqlConnection("Data Source=DESKTOP-CLSVRED;Initial Catalog=Clinica;Persist Security Info=True;User ID=sa;Password=123;");
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-F8819RR;Initial Catalog=Clinica;Integrated Security=True"); 
            //SqlConnection con = new SqlConnection("Data Source=DESKTOP-01SF7PQ;Initial Catalog=Clinica;Integrated Security=True");
            return con;
        }
        public static int Log(string txtusuario, string txtcontraseña)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nombre_usuario, Contrasena_usuario from Usuarios WHERE Nombre_usuario LIKE @nom AND Contrasena_usuario LIKE @usu", con);
            cmd.Parameters.AddWithValue("nom", txtusuario);
            cmd.Parameters.AddWithValue("usu", txtcontraseña);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {

                menu a = new menu();
                a.Show();
                con.Close();
                return 1;

            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrecta");
                con.Close();
                return 0;
            }

        }

        public static void Registro(string nom1, string nom2, string ape1, string ape2, string lugar, string fecha, string padre, string madre, string identidad, string sexo, int riesgo, string Ocupacion, string LugarT, string Direccion, string tel, string telE)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_pacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Primer_nombre_paciente", nom1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_nombre_paciente", nom2));
                cmd.Parameters.Add(new SqlParameter("@Primer_apellido_paciente", ape1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_apellido_paciente", ape2));
                cmd.Parameters.Add(new SqlParameter("@Lugar_nacimiento", lugar));
                cmd.Parameters.Add(new SqlParameter("@Fecha_nacimiento", fecha));
                cmd.Parameters.Add(new SqlParameter("@Nombre_padre_paciente", padre));
                cmd.Parameters.Add(new SqlParameter("@Nombre_madre_paciente", madre));
                cmd.Parameters.Add(new SqlParameter("@Numero_identidad_paciente", identidad));
                cmd.Parameters.Add(new SqlParameter("@Sexo_paciente", sexo));
                cmd.Parameters.Add(new SqlParameter("@Codigo_riesgo", riesgo));
                cmd.Parameters.Add(new SqlParameter("@Ocupacion_paciente", Ocupacion));
                cmd.Parameters.Add(new SqlParameter("@Lugar_trabajo_paciente", LugarT));
                cmd.Parameters.Add(new SqlParameter("@Direccion_paciente", Direccion));
                cmd.Parameters.Add(new SqlParameter("@Telefono_paciente", tel));
                cmd.Parameters.Add(new SqlParameter("@Telefono_emergencia", telE));

                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static void expediente(string ID)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Pacientes] WHERE [Numero_identidad_paciente]=@id", con);
                cmd.Parameters.AddWithValue("@id", ID);
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.Read())
                {
                    MessageBox.Show("El numero de expediente es : " + registro["Codigo_expediente_paciente"].ToString());
                }


            }
            catch
            {
            }
            finally
            {
                con.Close();
            }

        }

        public static void registrar_usuario(string usu, string contra, int codigo, string prof)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_usuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre_usuario", usu));
                cmd.Parameters.Add(new SqlParameter("@Contrasena_usuario", contra));
                cmd.Parameters.Add(new SqlParameter("@Codigo_empleado", codigo));
                cmd.Parameters.Add(new SqlParameter("@Profesor", prof));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario guardado con exito");
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static void registrar_empleado(string nom1, string nom2, string ape1, string ape2, string correo, string id, string sexo, string tel, string cargo)

        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_empleados", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Primer_nombre_empleado", nom1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_nombre_empleado", nom2));
                cmd.Parameters.Add(new SqlParameter("@Primer_apellido_empleado", ape1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_apellido_empleado", ape2));
                cmd.Parameters.Add(new SqlParameter("@Correo_empleado", correo));
                cmd.Parameters.Add(new SqlParameter("@Numero_identidad_empleado", id));
                cmd.Parameters.Add(new SqlParameter("@Sexo_empleado", sexo));
                cmd.Parameters.Add(new SqlParameter("@Telefono_empleado", tel));
                cmd.Parameters.Add(new SqlParameter("@Cargo_empleado", cargo));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Empleado guardado con exito");
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static int validarIDp(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Pacientes WHERE Numero_identidad_paciente=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static int validarIDe(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Empleados WHERE Numero_identidad_empleado=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static int validarIDu(string usu)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Usuarios WHERE Nombre_usuario=@usu", con);
            cmd.Parameters.AddWithValue("usu", usu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static int ValidarExp(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("select [Primer_nombre_paciente], [Segundo_nombre_paciente], [Primer_apellido_paciente], [Segundo_apellido_paciente],[Lugar_nacimiento_paciente], day([Fecha_nacimiento_paciente]) as dia, month([Fecha_nacimiento_paciente]) as mes,year([Fecha_nacimiento_paciente]) as anio,[Nombre_padre_paciente], [Nombre_madre_paciente], [Numero_identidad_paciente], [Sexo_paciente], [Codigo_riesgo], [Ocupacion_paciente], [Lugar_trabajo_paciente], [Direccion_paciente], [Telefono_paciente], [Telefono_emergencia]   from Pacientes WHERE Codigo_expediente_paciente=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.Read())
                {
                    Base_de_datos.Nombre1 = registro["Primer_nombre_paciente"].ToString();
                    Base_de_datos.Nombre2 = registro["Segundo_nombre_paciente"].ToString();
                    Base_de_datos.Apellido1 = registro["Primer_apellido_paciente"].ToString();
                    Base_de_datos.Apellid2 = registro["Segundo_apellido_paciente"].ToString();
                    Base_de_datos.Lugar = registro["Lugar_nacimiento_paciente"].ToString();
                    Base_de_datos.dia = registro["dia"].ToString();
                    Base_de_datos.mes = registro["mes"].ToString();
                    Base_de_datos.anio = registro["anio"].ToString();
                    Base_de_datos.NombreP = registro["Nombre_padre_paciente"].ToString();
                    Base_de_datos.NombreM = registro["Nombre_madre_paciente"].ToString();
                    Base_de_datos.Identidad = registro["Numero_identidad_paciente"].ToString();
                    Base_de_datos.Sexo = registro["Sexo_paciente"].ToString();
                    Base_de_datos.Riesgo = registro["Codigo_riesgo"].ToString();
                    Base_de_datos.Ocupacion = registro["Ocupacion_paciente"].ToString();
                    Base_de_datos.LugarT = registro["Lugar_trabajo_paciente"].ToString();
                    Base_de_datos.Direccion = registro["Direccion_paciente"].ToString();
                    Base_de_datos.tel = registro["Telefono_paciente"].ToString();
                    Base_de_datos.telE = registro["Telefono_emergencia"].ToString();

                }
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }

        }

        public static int validarIDp2(string id, string exp)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Pacientes WHERE Numero_identidad_paciente=@id and Codigo_expediente_paciente != @exp ", con);
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("exp", exp);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static void Actualizar_P(int expediente, string nom1, string nom2, string ape1, string ape2, string lugar, string fecha, string padre, string madre, string identidad, string sexo, int riesgo, string Ocupacion, string LugarT, string Direccion, string tel, string telE)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Pacientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_expediente_paciente", expediente));
                cmd.Parameters.Add(new SqlParameter("@Primer_nombre_paciente", nom1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_nombre_paciente", nom2));
                cmd.Parameters.Add(new SqlParameter("@Primer_apellido_paciente", ape1));
                cmd.Parameters.Add(new SqlParameter("@Segundo_apellido_paciente", ape2));
                cmd.Parameters.Add(new SqlParameter("@Lugar_nacimiento", lugar));
                cmd.Parameters.Add(new SqlParameter("@Fecha_nacimiento", fecha));
                cmd.Parameters.Add(new SqlParameter("@Nombre_padre_paciente", padre));
                cmd.Parameters.Add(new SqlParameter("@Nombre_madre_paciente", madre));
                cmd.Parameters.Add(new SqlParameter("@Numero_identidad_paciente", identidad));
                cmd.Parameters.Add(new SqlParameter("@Sexo_paciente", sexo));
                cmd.Parameters.Add(new SqlParameter("@Codigo_riesgo", riesgo));
                cmd.Parameters.Add(new SqlParameter("@Ocupacion_paciente", Ocupacion));
                cmd.Parameters.Add(new SqlParameter("@Lugar_trabajo_paciente", LugarT));
                cmd.Parameters.Add(new SqlParameter("@Direccion_paciente", Direccion));
                cmd.Parameters.Add(new SqlParameter("@Telefono_paciente", tel));
                cmd.Parameters.Add(new SqlParameter("@Telefono_emergencia", telE));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }


        }

        public static int Recuperar(string txtusuario, string txtprof)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Nombre_usuario, Profesor from Usuarios WHERE Nombre_usuario LIKE @nom AND Profesor LIKE @prof", con);
            cmd.Parameters.AddWithValue("nom", txtusuario);
            cmd.Parameters.AddWithValue("prof", txtprof);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }

        }

        public void Buscar(string id)
        {
            string ID;
            ID = id;

            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Codigo_expediente_paciente 'Expediente paciente',Primer_nombre_paciente 'Primer nombre',Segundo_nombre_paciente 'Segundo nombre',Primer_apellido_paciente 'Primer Apellido',Fecha_nacimiento_paciente 'Fecha de nacimiento',Numero_identidad_paciente 'Identidad de paciente', Sexo_paciente 'Sexo de paciente' from[dbo].[Pacientes] where Numero_identidad_paciente LIKE " + "'" + id + "'", con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }
             
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        public void Buscar(string nom, String ape)
        {

            string nombre, apellido;
            apellido = ape;
            nombre = nom;

            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Codigo_expediente_paciente 'Expediente paciente',Primer_nombre_paciente 'Primer nombre',Segundo_nombre_paciente 'Segundo nombre',Primer_apellido_paciente 'Primer Apellido',Fecha_nacimiento_paciente 'Fecha de nacimiento',Numero_identidad_paciente 'Identidad de paciente', Sexo_paciente 'Sexo de paciente' from[dbo].[Pacientes] where Primer_nombre_paciente LIKE " + "'" + nombre + "%'" + " AND Primer_apellido_paciente LIKE " + "'" + ape + "%'", con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }
               
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        public virtual DataTable Mostrar_Resultados()
        {
            return Resultado;
        }

        public static void busqueda_citas(int id, DataGridView dgv)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Codigo_cita] 'Codigo de cita',[Fecha_cita] 'Fecha de cita' from Citas WHERE Codigo_expediente_paciente=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                dgv.DataSource = dt;
                con.Close();

            }
          
        }

        public static void busqueda_factura(int id, DataGridView dgv)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("select a.Codigo_factura 'Factura', a.Precio_cita 'Precio de cita', a.Donacion, b.Fecha_cita from [dbo].[Facturas] a inner join [dbo].[Citas] b on a.Codigo_cita=b.Codigo_cita where b.Codigo_expediente_paciente = @id; ", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                dgv.DataSource = dt;
                con.Close();

            }

        }

        public static void Ingresar_cita(int codigo, string fecha)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Ingreso_citas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_expediente_paciente", codigo));
                cmd.Parameters.Add(new SqlParameter("@Fecha_cita", fecha));

                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }
        public static void Restablecer(string usu, string contra)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Restablecer_contra", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@usu", usu));
                cmd.Parameters.Add(new SqlParameter("@contra", contra));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }
        public static void registrar_medicamento(string nom, string desc, int cant, double precio, int unidad)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_medicamentos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre_medicamento", nom));
                cmd.Parameters.Add(new SqlParameter("@Cantidad_medicamento", cant));
                cmd.Parameters.Add(new SqlParameter("@Descripcion_medicamento", desc));
                cmd.Parameters.Add(new SqlParameter("@Precio_medicamento", precio));
                cmd.Parameters.Add(new SqlParameter("@Unidad", unidad));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicamento ingresado con exito");
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static DataTable Buscar_medicamento()
        {
            SqlConnection con;
            con = Conectar();
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Codigo_medicamento, Nombre_medicamento, Descripcion_medicamento from [dbo].[Medicamentos]", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void registrar_recetas(int cita, int med, int cant)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Ingreso_recetas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_cita", cita));
                cmd.Parameters.Add(new SqlParameter("@Codigo_medicamento", med));
                cmd.Parameters.Add(new SqlParameter("@Cantidad", cant));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static int validarMed(int cita, int med)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Recetas WHERE Codigo_cita=@id and Codigo_medicamento = @exp ", con);
            cmd.Parameters.AddWithValue("id", cita);
            cmd.Parameters.AddWithValue("exp", med);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count != 0)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static void Quitar(int cita, int med)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_quitar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_cita", cita));
                cmd.Parameters.Add(new SqlParameter("@Codigo_medicamento", med));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static void Ingresar_medicamento(int cod, int cant, string fecha1, string fecha2, int codigo)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("IngresoMedicamentos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_medicamento", cod));
                cmd.Parameters.Add(new SqlParameter("@Cantidad", cant));
                cmd.Parameters.Add(new SqlParameter("@Fecha_entrada", fecha1));
                cmd.Parameters.Add(new SqlParameter("@Fecha_vencimiento", fecha2));
                cmd.Parameters.Add(new SqlParameter("@Codigo_empleado", codigo));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static int codigo_medicamento()
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT top 1 * FROM [dbo].[Medicamentos] order by Codigo_medicamento desc", con);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                return int.Parse(registro["Codigo_medicamento"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public void BuscarMedCod(string Cod)
        {


            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select a.Codigo_medicamento  'Código Medicamento', a.Nombre_medicamento  'Nombre Medicamento',a.Cantidad_medicamento 'Cantidad',a.Descripcion_medicamento 'Descripcion Medicamento', b.Nombre_medida from [dbo].[Medicamentos] a inner join Medida b on a.Codigo_medida=b.[Codigo_medida] where a.Codigo_medicamento LIKE " + "'" + Cod + "'", con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }
            
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        public void BuscarMedNom(string Nom)
        {


            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select a.Codigo_medicamento  'Código Medicamento', a.Nombre_medicamento  'Nombre Medicamento',a.Cantidad_medicamento 'Cantidad',a.Descripcion_medicamento 'Descripcion Medicamento', b.Nombre_medida from [dbo].[Medicamentos] a inner join Medida b on a.Codigo_medida=b.[Codigo_medida] where a.Nombre_medicamento LIKE " + "'" + Nom + "%'", con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }
               
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        public static string Nombre_medicamento(string Cod)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Medicamentos] WHERE [Codigo_medicamento]=@id", con);
            cmd.Parameters.AddWithValue("@id", Cod);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {

                string Nombre = registro["Nombre_medicamento"].ToString();
                con.Close();
                return Nombre;

            }
            else
            {

                return null;
            }
        }
        public static string Precio_medicamento(string Cod)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[Medicamentos] WHERE [Codigo_medicamento]=@id", con);
            cmd.Parameters.AddWithValue("@id", Cod);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {

                string Precio = registro["Precio_medicamento"].ToString();
                con.Close();
                return Precio;

            }
            else
            {

                return null;
            }




        }

        public static int validmedi(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("select Nombre_medicamento, Cantidad_medicamento, Descripcion_medicamento, b.Nombre_medida from [dbo].[Medicamentos] a inner join Medida b on a.Codigo_medida=b.Codigo_medida WHERE [Codigo_medicamento]=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();

                if (registro.Read())
                {
                    Base_de_datos.nommedi = registro["Nombre_medicamento"].ToString();
                    Base_de_datos.cant = registro["Cantidad_medicamento"].ToString();
                    Base_de_datos.desc = registro["Descripcion_medicamento"].ToString();
                    Base_de_datos.unidad = registro["Nombre_medida"].ToString();

                }
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }
        }
        public static int Cantidad_med(string Id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("select Nombre_medicamento, Cantidad_medicamento, Descripcion_medicamento from [dbo].[Medicamentos] WHERE [Codigo_medicamento]=@id", con);
            cmd.Parameters.AddWithValue("id", Id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SqlDataReader registro = cmd.ExecuteReader();
            Base_de_datos.cant = registro["Cantidad_medicamento"].ToString();
            con.Close();
            return int.Parse(Base_de_datos.cant);
        }

        public static void vencemedi(int id, int cant)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_medicamentos", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_med", id));
                cmd.Parameters.Add(new SqlParameter("@cantidad", cant));

                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }


        }
        public int BuscarReceta(string id)
        {
            string ID;
            ID = id;

            SqlConnection con;
            con = Conectar();

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(" select b.[Codigo_medicamento] 'Codigo Medicamento', b.[Nombre_medicamento] 'Nombre Medicamento', a.[Cantidad], (b.[Precio_medicamento]) 'Precio Medicamento', (a.[Cantidad] *b.[Precio_medicamento]) 'Total' from [dbo].[Recetas] a  inner join [dbo].[Medicamentos] b on a.Codigo_medicamento = b.Codigo_medicamento where a.Codigo_cita LIKE " + "'" + id + "'", con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            da.Fill(dt);
            numero = dt.Rows.Count;
            if (dt.Rows.Count >= 1)
            {
                Resultado = dt;
                con.Close();
                return 1;
            }
            else
            {

                MessageBox.Show("Cita no encontrado");
                con.Close();

                return 0;
            }


        }


        public static float porcentaje_riesgo(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();


            con.Open();
            SqlCommand cmd = new SqlCommand("select c.Porcentaje_sugerido from [dbo].[Citas] a  inner join [dbo].[Pacientes] b on a.Codigo_expediente_paciente = b.Codigo_expediente_paciente inner join [dbo].[Riesgo_Social] c on b.Codigo_riesgo = c.Codigo_riesgo where a.Codigo_cita LIKE " + "'" + id + "'", con);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                return float.Parse(registro["Porcentaje_sugerido"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public static float total_medicamentos(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();


            con.Open();
            SqlCommand cmd = new SqlCommand("select sum(round((a.[Cantidad] *b.[Precio_medicamento]),1,0)) as total from [dbo].[Recetas] a  inner join [dbo].[Medicamentos] b on a.Codigo_medicamento = b.Codigo_medicamento where a.Codigo_cita LIKE " + "'" + id + "'", con);
            SqlDataReader registro = cmd.ExecuteReader();

            if (registro.Read())
            {
                return float.Parse(registro["total"].ToString());
            }
            else
            {
                return 0;
            }
        }

        public static void Ingresar_factura(double precio, double dona, int codigo)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Ingreso_factura", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Precio_cita", precio));
                cmd.Parameters.Add(new SqlParameter("@Donacion", dona));
                cmd.Parameters.Add(new SqlParameter("@Codigo_cita", codigo));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }


        }

        public static int VerificarMedicamento(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Medicamentos WHERE Codigo_medicamento=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static int validarNomMed(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Medicamentos WHERE Nombre_medicamento=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                con.Close();
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static void acceso(string usu)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.Codigo_rol, b.Codigo_empleado from [dbo].[Empleado_Rol] a inner join [dbo].[Usuarios] b on a.Codigo_empleado=b.Codigo_empleado where b.Nombre_usuario = @id", con);
            cmd.Parameters.AddWithValue("@id", usu);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {

                    rol = int.Parse(registro["Codigo_rol"].ToString());
                    cod_empleado = int.Parse(registro["Codigo_empleado"].ToString());
                    con.Close();

                }

            }
            else
            {
                MessageBox.Show("hola");
            }
            //Corregir Hola
        }
        public static string Referencia()
        {
            SqlConnection con;
            con = Conectar();
            string Nombre;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.Nombre_usuario,b.Primer_nombre_empleado,b.Primer_apellido_empleado, b.Segundo_apellido_empleado from [dbo].[Usuarios] a inner join [dbo].[Empleados] b on a.Codigo_empleado=b.Codigo_empleado where a.Nombre_usuario = @id", con);
            cmd.Parameters.AddWithValue("@id", User);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {

                    
                    Nombre = ("Dr(a)."+registro["Primer_nombre_empleado"].ToString() +" "+ registro["Primer_apellido_empleado"].ToString() +" "+ registro["Segundo_apellido_empleado"].ToString());
                    con.Close();
                    return Nombre;

                }
                

            }
            return null;
            
            //Corregir Hola
        }
        
       
        public static void esta()
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("Medicamento_vendido", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                cantidadmedicamento.Add(dr.GetInt32(0));
                nombremedicamento.Add(dr.GetString(1));
            }

        }
        /*
        create proc [dbo].[Medicamento_vendido]
as
begin
select top 5 sum(b.Cantidad) 'vendidos', c.Nombre_medicamento from  [dbo].[Facturas] a inner join [dbo].[Recetas] b on a.Codigo_cita=b.Codigo_cita inner join [dbo].[Medicamentos] c on b.Codigo_medicamento=c.Codigo_medicamento
group by c.Nombre_medicamento
order by sum(b.Cantidad) desc
end
*/
        public static void Actualizar_cita(int codigo, string diag, string trat)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_cita", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_cita", codigo));
                cmd.Parameters.Add(new SqlParameter("@Diagnostico", diag));
                cmd.Parameters.Add(new SqlParameter("@Tratamiento", trat));

                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }
        /* create proc	Actualizar_cita
(
@Codigo_cita as int,
@Diagnostico as nvarchar(500),
@Tratamiento as nvarchar(500)
)
as
begin

update [dbo].[Citas]
set 
[Diagnostico]=@Diagnostico,
[Tratamiento]=@Tratamiento
where [Codigo_cita]=@Codigo_cita

end
*/
        public static int Validar_cita(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open(); 
            SqlCommand cmd = new SqlCommand("select b.Primer_nombre_paciente,b.Segundo_nombre_paciente, b.Primer_apellido_paciente, Diagnostico, Tratamiento from [dbo].[Citas] a inner join [dbo].[Pacientes] b on a.Codigo_expediente_paciente=b.Codigo_expediente_paciente where Codigo_cita = @id AND Diagnostico is null", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    nombre_cita = registro["Primer_nombre_paciente"].ToString() + " " + registro["Segundo_nombre_paciente"].ToString() + " " + registro["Primer_apellido_paciente"].ToString();
                    con.Close();
                }
                return 1;

            }
            else
            {
                con.Close();
                return 0;
            }
        }

        public static void Extraer_diagnostico(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("select b.Primer_nombre_paciente,b.Segundo_nombre_paciente, b.Primer_apellido_paciente, a.Diagnostico, a.Tratamiento from [dbo].[Citas] a inner join [dbo].[Pacientes] b on a.Codigo_expediente_paciente=b.Codigo_expediente_paciente where Codigo_cita = @id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    diagnostico = registro["Diagnostico"].ToString();
                    tratamiento = registro["Tratamiento"].ToString();
                    nombre_cita = registro["Primer_nombre_paciente"].ToString() + " " + registro["Segundo_nombre_paciente"].ToString() + " " + registro["Primer_apellido_paciente"].ToString();
                    con.Close();
                }
                    

            }
            else
            {
                con.Close();
            }
        }

        public static void Registro_Rol(string nombreRol, string Permisos)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insertar_Rol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre_rol", nombreRol));
                cmd.Parameters.Add(new SqlParameter("@Permisos_rol", Permisos));

                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }


        public void BuscarRoles()
        {


            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Codigo_rol  'Código del Rol', Nombre_rol 'Nombre del Rol' from[dbo].[Roles]" , con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }


        public static void Actualizar_Rol(int CodigoRol, string nombreRol, string permisosRol)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Actualizar_Rol", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Codigo_rol", CodigoRol));
                cmd.Parameters.Add(new SqlParameter("@Nombre_rol", nombreRol));
                cmd.Parameters.Add(new SqlParameter("@Permisos_rol", permisosRol));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }


        }

        public static void Registro_Medida(string nombreMed)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_medida", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cod", 1));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombreMed));
                cmd.Parameters.Add(new SqlParameter("@opc", 1));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }

        public static void Actualizar_Medida(int Codigo, string nombre)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Mante_medida", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@cod", Codigo));
                cmd.Parameters.Add(new SqlParameter("@nombre", nombre));
                cmd.Parameters.Add(new SqlParameter("@opc", 2));
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                con.Close();
            }


        }

        public void BuscarMedida()
        {


            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Codigo_Medida  'Codigo de medida', Nombre_medida 'Nombre de la medida' from [dbo].[Medida]", con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }

        public static int ValidarFactura(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from [dbo].[Facturas] where Codigo_cita = @id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }
        }
        
        public void BuscarEmpleado()
        {


            SqlConnection con;
            con = Conectar();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select Codigo_empleado, Primer_nombre_empleado 'Primer Nombre', Segundo_nombre_empleado 'Segundo Nombre', Primer_apellido_empleado 'Apellido' from[dbo].[Empleados]", con);
                da.SelectCommand.CommandType = CommandType.Text;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    Resultado = dt;
                    con.Close();

                }

            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        public static int Validar_Cod_empleado(string id)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Primer_nombre_empleado],[Segundo_nombre_empleado],[Primer_apellido_empleado],[Segundo_apellido_empleado],[Correo_empleado],[Numero_identidad_empleado],[Sexo_empleado],[Telefono_empleado],[Cargo_empleado] FROM [dbo].[Empleados] WHERE [Codigo_empleado]=@id", con);
            cmd.Parameters.AddWithValue("id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.Read())
                {
                    Base_de_datos.nombre1_empleado = registro["Primer_nombre_empleado"].ToString();
                    Base_de_datos.nombre2_empleado = registro["Segundo_nombre_empleado"].ToString();
                    Base_de_datos.apellido1_empleado = registro["Primer_apellido_empleado"].ToString();
                    Base_de_datos.apellido2_empleado = registro["Segundo_apellido_empleado"].ToString();
                    Base_de_datos.correo_empleado = registro["Correo_empleado"].ToString();
                    Base_de_datos.numero_identidad_empleado = registro["Numero_identidad_empleado"].ToString();
                    Base_de_datos.sexo_empleado = registro["Sexo_empleado"].ToString();
                    Base_de_datos.numero_telefono_empleado = registro["Telefono_empleado"].ToString();
                    Base_de_datos.cargo_empleado = registro["Cargo_empleado"].ToString();
                }
                con.Close();
                return 1;
            }
            else
            {
                con.Close();
                return 0;
            }
        }
        public static void Actualizar_empleado(int codigo_empleado, string nombre1, string nombre2, string apellido1, string apellido2, string correo_empleado, string id_empleado, string sexo, string tel_empleado, string cargo)
        {
            SqlConnection con;
            con = Base_de_datos.Conectar();

            con.Open();
            SqlCommand cmd = new SqlCommand("Actualizar_empleado", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Codigo_empleado", codigo_empleado));
            cmd.Parameters.Add(new SqlParameter("@Primer_nombre_empleado", nombre1));
            cmd.Parameters.Add(new SqlParameter("@Segundo_nombre_empleado", nombre2));
            cmd.Parameters.Add(new SqlParameter("@Primer_apellido_empleado", apellido1));
            cmd.Parameters.Add(new SqlParameter("@Segundo_apellido_empleado", apellido2));
            cmd.Parameters.Add(new SqlParameter("@Correo_empleado", correo_empleado));
            cmd.Parameters.Add(new SqlParameter("@Identidad_empleado", id_empleado));
            cmd.Parameters.Add(new SqlParameter("@Sexo_empleado", sexo));
            cmd.Parameters.Add(new SqlParameter("@Telefono_empleado", tel_empleado));
            cmd.Parameters.Add(new SqlParameter("@Cargo_empleado", cargo));
            cmd.ExecuteNonQuery();
            con.Close();


        }
        public static void BuscarPermisos(string Rol)
        {


            SqlConnection con;
            con = Conectar();
            con.Open();
            SqlCommand cmd = new SqlCommand("select b.Permisos_rol from [dbo].[Empleado_Rol] a inner join [dbo].[Roles] b on  a.Codigo_rol=b.Codigo_rol where b.Codigo_rol=@Rol", con);
            cmd.Parameters.AddWithValue("Rol", Rol);
            SqlDataReader Perm = cmd.ExecuteReader();
            if (Perm.Read())
            {
                Permisos = Perm["Permisos_rol"].ToString();
                con.Close();
            }

        }

    }
}

