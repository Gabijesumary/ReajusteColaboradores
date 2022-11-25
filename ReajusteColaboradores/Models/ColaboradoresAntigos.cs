using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteColaboradores.Models
{
    internal class ColaboradoresAntigos : Colaboradores
    {
        public ColaboradoresAntigos(double salaryEmployee)
        {
            SalaryEmployee = salaryEmployee;
        }

        public void Bonus(double salary)
        {
            this.SalaryEmployee = salary;
            double n, percent;

            if (salary > 7000)
            {
                n = 10;
            }
            else
            {
                Console.Write("Digite a porcentagem do aumento. ** APENAS NÚMEROS **  :  ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            percent = (n / 100) * salary;
            salary = salary + percent;

            Console.WriteLine("\nO salário atualizado é: " + salary.ToString("C"));
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
}