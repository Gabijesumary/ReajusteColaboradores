using System.Security.Cryptography.X509Certificates;

namespace ReajusteColaboradores.Models
{

    public class Colaboradores : IEmployee
    {
        public string NameEmployee;
        public string RoleEmployee;
        public double SalaryEmployee;
        public string InitialDate;


        public override string ToString()
        {
            return "Colaborador cadastrado com sucesso: " + NameEmployee + ", " + RoleEmployee + " e " + SalaryEmployee.ToString("C");
        }

        public void VerifyDate(string date)
        {
            ColaboradoresAntigos OldEmployee = new ColaboradoresAntigos(SalaryEmployee);


            DateTime date1, date2;
            TimeSpan result;

            date1 = DateTime.Parse(date);
            date2 = DateTime.Now;

            result = date2 - date1;
            int time = (result.Days / 30 / 12);

            if (time < 4)
            {
                ColaboradoresNovos NewEmployee = new ColaboradoresNovos();
                NewEmployee.ToString2();
            }
            else
            {
                OldEmployee = new ColaboradoresAntigos(SalaryEmployee);
                OldEmployee.Bonus(SalaryEmployee);
            }


        }


    }
}