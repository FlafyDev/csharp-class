class Weight {
  private int kilo;
  private int gram;

  public Weight(int kilo, int gram) {
    this.kilo = kilo;
    this.gram = gram;
  }

  public Weight(int totalGram) {
    this.kilo = totalGram / 1000;
    this.gram = totalGram % 1000;
  }

  public void Add(Weight other) {
    this.kilo += other.kilo;
    this.gram += other.gram;
  }

  public bool Less(Weight other) {
    return other.kilo * 1000 + other.gram > this.kilo * 1000 + this.gram;
  }

  public int GetKilo() {
    return this.kilo;
  }

  public int GetGram() {
    return this.gram;
  }
}

class AllWeight {
  private Weight[] arr;

  public AllWeight(Weight[] arr) {
    this.arr = arr;
  }

  public Weight Sum() {
    int totalGram = 0;
    for (int i = 0; i < arr.Length; i++) {
      Weight weight = arr[i];
      totalGram += weight.GetGram() + weight.GetKilo() * 1000;
    }
    return new Weight(totalGram);
  }
}
