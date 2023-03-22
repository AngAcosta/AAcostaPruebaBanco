using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Banco
    {
        public static void Add()
        {
            ML.Banco banco = new ML.Banco();

            Console.WriteLine("Ingresa el Nombre del Banco: ");
            banco.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el No de Empleados: ");
            banco.NoEmpleados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el No de Sucursal: ");
            banco.NoSucursales = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Id del Pais: ");
            banco.Pais = new ML.Pais();
            banco.Pais.IdPais = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Capital del Banco: ");
            banco.Capital = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Id de Razon Social: ");
            banco.RazonSoial = new ML.RazonSoial();
            banco.RazonSoial.IdRazonSocial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el No de Clientes: ");
            banco.NoClientes = int.Parse(Console.ReadLine());

            ML.Result result = BL.Banco.Add(banco);
            
            if (result.Correct)
            {
                result.Message = "Banco Agregado";
            }
            else
            {
                result.Message = "Banco no Agregado";
            }
        }

        public static void Update()
        {
            ML.Banco banco = new ML.Banco();

            Console.WriteLine("Ingresa el Id del Banco: ");
            banco.IdBanco = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Nombre del Banco: ");
            banco.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa el No de Empleados: ");
            banco.NoEmpleados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el No de Sucursal: ");
            banco.NoSucursales = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Id del Pais: ");
            banco.Pais = new ML.Pais();
            banco.Pais.IdPais = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Capital del Banco: ");
            banco.Capital = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el Id de Razon Social: ");
            banco.RazonSoial = new ML.RazonSoial();
            banco.RazonSoial.IdRazonSocial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el No de Clientes: ");
            banco.NoClientes = int.Parse(Console.ReadLine());

            ML.Result result = BL.Banco.Update(banco);

            if (result.Correct)
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

        public static void Delete()
        {
            ML.Banco banco = new ML.Banco();

            Console.WriteLine("Ingresa el Id del Banco: ");
            banco.IdBanco = int.Parse(Console.ReadLine());

            ML.Result result = BL.Banco.Delete(banco);

            if (result.Correct)
            {
                result.Message = "Banco Eliminado";
                Console.ReadKey();
            }
            else
            {
                result.Message = "Banco no Eliminado";
                Console.ReadKey();
            }
        }
    }
}