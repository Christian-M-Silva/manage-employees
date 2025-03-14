namespace ManageEmployees.models
{
    public abstract class Emoloyees(string name, double baseSalary)
    {
        protected string? Name { get; set; } = name;
        protected double BaseSalary { get; set; } = baseSalary;
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
