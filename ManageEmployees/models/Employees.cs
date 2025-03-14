namespace ManageEmployees.models
{
    public abstract class Employees(string name, double baseSalary)
    {
        protected string? Name { get; set; } = name;
        protected double BaseSalary { get; set; } = baseSalary;
        public abstract void CalculateSalary();

        public delegate void emoloyeesRegisterHandler();
        public event emoloyeesRegisterHandler? OnEmployeesRegister;

        public void Start()
        {
            CalculateSalary();
            OnEmployeesRegister?.Invoke();
        }
    }
}
