using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class Banco
    {
        public static ML.Result Add(ML.Banco banco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConection()))
                {
                    string query = "BancoAdd";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[7];

                        collection[0] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[0].Value = banco.Nombre;

                        collection[1] = new SqlParameter("NoEmpleados", SqlDbType.Int);
                        collection[1].Value = banco.NoEmpleados;

                        collection[2] = new SqlParameter("NoSucursales", SqlDbType.Int);
                        collection[2].Value = banco.NoSucursales;

                        collection[3] = new SqlParameter("IdPais", SqlDbType.Int);
                        collection[3].Value = banco.Pais.IdPais;

                        collection[4] = new SqlParameter("Capital", SqlDbType.Money);
                        collection[4].Value = banco.Capital;

                        collection[5] = new SqlParameter("IdRazonSocial", SqlDbType.Int);
                        collection[5].Value = banco.RazonSoial.IdRazonSocial;

                        collection[6] = new SqlParameter("NoClientes", SqlDbType.Int);
                        collection[6].Value = banco.NoClientes;
                        
                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            result.Message = "Banco Agregado";
                        }
                        else
                        {
                            result.Message = "Banco no Agregado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static ML.Result Update(ML.Banco banco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConection()))
                {
                    string query = "BancoUpdate";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[8];

                        collection[0] = new SqlParameter("IdBanco", SqlDbType.Int);
                        collection[0].Value = banco.IdBanco;

                        collection[1] = new SqlParameter("Nombre", SqlDbType.VarChar);
                        collection[1].Value = banco.Nombre;

                        collection[2] = new SqlParameter("NoEmpleados", SqlDbType.Int);
                        collection[2].Value = banco.NoEmpleados;

                        collection[3] = new SqlParameter("NoSucursales", SqlDbType.Int);
                        collection[3].Value = banco.NoSucursales;

                        collection[4] = new SqlParameter("IdPais", SqlDbType.Int);
                        collection[4].Value = banco.Pais.IdPais;

                        collection[5] = new SqlParameter("Capital", SqlDbType.Money);
                        collection[5].Value = banco.Capital;

                        collection[6] = new SqlParameter("IdRazonSocial", SqlDbType.Int);
                        collection[6].Value = banco.RazonSoial.IdRazonSocial;

                        collection[7] = new SqlParameter("NoClientes", SqlDbType.Int);
                        collection[7].Value = banco.NoClientes;

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            result.Message = "Banco Modificado";
                            Console.ReadKey();
                        }
                        else
                        {
                            result.Message = "Banco no Modificado";
                            Console.ReadKey();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static ML.Result Delete(ML.Banco banco)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConection()))
                {
                    string query = "BancoDelete";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] collection = new SqlParameter[1];

                        collection[0] = new SqlParameter("IdBanco", SqlDbType.Int);
                        collection[0].Value = banco.IdBanco;         

                        cmd.Parameters.AddRange(collection);
                        cmd.Connection.Open();

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            result.Message = "Banco Eliminado";
                        }
                        else
                        {
                            result.Message = "Banco no Eliminado";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}