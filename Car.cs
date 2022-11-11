using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11dz
{
    public class Car
    {
        public string Company { get; set; }
        public string Model { get; set; }
        public double Speed { get; set; }

        public event StartCarDelegate? StartCar;
        public event DriveCarDelegate? DriveCar;

        public Car(string company, string model, double speed)
        {
            Company = company;
            Model = model;
            Speed = speed;
        }

        public void Start()
        {
            StartCar?.Invoke(this, new EventArgs());
        }
        public void Drive()
        {
            DriveCar?.Invoke(this, new EventArgs());
        }

        public delegate void StartCarDelegate(object auto_1, EventArgs e_1);
        public delegate void DriveCarDelegate(object auto_2, EventArgs e_2);
    }
}
