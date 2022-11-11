using ConsoleApp11dz;

//Почему то из-за DriveCar все ломается!!!(Вродебы все ок, не могу понять ?почему?)

Car car_1 = new Car("BMW", "X5", 100);
car_1.StartCar += StartAuto;
car_1.Start();

Console.WriteLine("------------------------------------------");

Car car_2 = new Car("Toyota", "Camry", 90);
car_2.DriveCar += DriveAuto;
car_2.Start();

Console.WriteLine("------------------------------------------");

Car car_3 = new Car("Mercedes", "C-Class", 120);
car_3.StartCar += StartAuto;
car_3.DriveCar += DriveAuto;
car_3.Start();

void StartAuto(object auto_1, EventArgs e_1)
{
    if (auto_1 is Car car)
    {
        Console.WriteLine($"Заведена машина {car.Company } {car.Model}");
    }
}

void DriveAuto(object auto_2, EventArgs e_2)
{
    if (auto_2 is Car car)
    {
        Console.WriteLine($"Стартовала машина {car.Company } {car.Model} со скоростью {car.Speed} км/час");
    }
}

