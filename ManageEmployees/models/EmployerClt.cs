
using ManageEmployees.interfaces;

namespace ManageEmployees.models
{
    public class EmployerClt(string name, double baseSalary) : Emoloyees(name, baseSalary), IBenefits
    {
        public Benefits CalculateBenefits()
        {
            double transportVoucher = (10 / 100) * BaseSalary;
            double foodVoucher = (30 / 100) * BaseSalary;
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
            double finalSalary = benefits.Total - BaseSalary;

            Console.WriteLine($"O Sálario base do {Name}, é R${BaseSalary}. Porém com os béneficios de vale-alimentação(R${benefits.FoodVoucher}) e  vale-transporte(R${benefits.TransportVoucher}), será descontados R${benefits.Total} do sálario. Deixando um sálario final de R$ {finalSalary}");
        }
    }
}
