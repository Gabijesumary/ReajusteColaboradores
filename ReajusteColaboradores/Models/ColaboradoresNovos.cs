using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReajusteColaboradores.Models
{
    public class ColaboradoresNovos : Colaboradores
    {
        public void ToString2()
        {
            Console.WriteLine($"\n** ATENÇÃO ** \nO Colaborador não atinge os requisitos necessários para ter ajuste salarial.\n" +
                   $"Escolha outro colaborador ou feche o programa!\n");

            Thread.Sleep(5000);
            Console.Clear();
        }
    }
}