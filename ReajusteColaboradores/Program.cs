using ReajusteColaboradores.Models;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Colaboradores Employee = new Colaboradores();


            do
            {
                Console.WriteLine("===== CADASTRO DE FUNCIONARIOS =====\n");
                Console.WriteLine("\nQual operação deseja realizar no momento:");
                Console.WriteLine("\n [1] Atualizar salário;\n [2] Fechar programa;\n");
                Console.Write("Digite a opção >>> ");
                string choice = Console.ReadLine();
                if (choice == "2")
                {
                    break;
                }
                Console.Clear();

                Console.WriteLine("\n===== ATUALIZAR SALÁRIO =====\n");
                Console.Write("Digite o nome do colaborador: ");
                Employee.NameEmployee = Console.ReadLine();

                Console.Write("Digite o cargo do colaborador: ");
                Employee.RoleEmployee = Console.ReadLine();

                Console.Write("Digite a data de contratação do colaborador: ");
                Employee.InitialDate = Console.ReadLine();

                Console.Write("Digite o salário do colaborador: ");
                Employee.SalaryEmployee = Convert.ToDouble(Console.ReadLine());

                Employee.VerifyDate(Employee.InitialDate);

            }
            while (true);

        }




    }
}