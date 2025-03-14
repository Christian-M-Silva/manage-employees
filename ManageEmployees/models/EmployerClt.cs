
using ManageEmployees.interfaces;

namespace ManageEmployees.models
{
    public class EmployerClt(string name, double baseSalary) : Employees(name, baseSalary), IBenefits
    {
        public Benefits CalculateBenefits()
        {
            double transportVoucher = BaseSalary * 0.10;
            double foodVoucher = BaseSalary * 0.30;
            double total = foodVoucher + transportVoucher;

            return new Benefits
            {
                FoodVoucher = foodVoucher,
                Total = total,
                TransportVoucher = transportVoucher
            };

        }

        public override void CalculateSalary()
        {
            Benefits benefits = CalculateBenefits();
            double finalSalary = BaseSalary - benefits.Total;

            Console.WriteLine($"O Sálario base do {Name}, é R${BaseSalary}. Porém com os béneficios de vale-alimentação(R${benefits.FoodVoucher}) e vale-transporte(R${benefits.TransportVoucher}), será descontados R${benefits.Total} do sálario. Deixando um sálario final de R${finalSalary}.");
        }
    }
}
