using System;

namespace ProyectoEquipoX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Sistema de Gestión de Stock ---");
            Console.Write("Ingrese cantidad actual: ");
            int cantidad = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"El stock total cargado es: {cantidad} unidades.");
        }
    }
}