
using ManageEmployees.interfaces;

namespace ManageEmployees.models
{
    public class EmployerClt : Emoloyees, IBenefits
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
            throw new NotImplementedException();
        }
    }
}
