class Car {
  string licenseNum;
  bool hadAccident;
  int price;

  public Car(string licenseNum, bool hadAccident, int price) {
    this.licenseNum = licenseNum;
    this.hadAccident = hadAccident;
    this.price = price;
  }

  public bool Range(int min, int max) {
    return this.price >= min && this.price <= max;
  }

  public int GetPrice() {
    return price;
  }

  public bool GetHadAccident() {
    return hadAccident;
  }

  public string GetLicenseNum() {
    return licenseNum;
  }

  public void SetPrice(int price) {
    this.price = price;
  }

  public void SetHadAccident(bool hadAccident) {
    this.hadAccident = hadAccident;
  }

  public void SetLicenseNum(string licenseNum) {
    this.licenseNum = licenseNum;
  }
}
