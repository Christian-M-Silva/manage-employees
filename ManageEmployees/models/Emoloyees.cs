namespace ManageEmployees.models
{
    public abstract class Emoloyees
    {
        protected string? Name { get; set; }
        protected double SalarioBase { get; set; }
        public abstract void CalculateSalary();

        delegate void emoloyeesRegisterHandler();
        event emoloyeesRegisterHandler? OnEmoloyeesRegister;

        public void Start()
        {
            CalculateSalary();
            OnEmoloyeesRegister?.Invoke();
        }
    }
}
