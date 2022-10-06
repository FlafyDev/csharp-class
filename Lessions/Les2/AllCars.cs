using System;

class AllCars {
  Car[] cars;
  int num;

  public AllCars(int max) {
    this.cars = new Car[max];
    this.num = 0;
  }

  public bool AddCar(Car car) {
    if (this.cars.Length == num) {
      return false;
    }

    cars[num++] = car;
    return true;
  }

  public void Print(int min, int max) {
    for (int i = 0; i < this.num; i++) {
      if (!cars[i].GetHadAccident() && cars[i].Range(min, max)) {
        Console.WriteLine(cars[i].GetLicenseNum());
      }
    }
  }
}
