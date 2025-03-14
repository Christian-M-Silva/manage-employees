using ManageEmployees.models;

Employees joao = new EmployerClt("João", 2000);
joao.OnEmployeesRegister += () => Console.WriteLine(" ");
joao.Start();

Employees maria = new EmployerPj("Maria", 2000, 10);
maria.OnEmployeesRegister += () => Console.WriteLine(" ");
maria.Start();