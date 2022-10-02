namespace Les1 {
  class Vacation {
    private string name;
    private int nights;
    private string visitPlace;
    private string sleepSpot;
    private bool isAbroad;

    public Vacation(string name, int nights, string visitPlace, string sleepSpot,
                    bool isAbroad) {
      this.name = name;
      this.nights = nights;
      this.visitPlace = visitPlace;
      this.sleepSpot = sleepSpot;
      this.isAbroad = isAbroad;
    }

    public void SetNights(int nights) { this.nights = nights; }

    public void AddNight() { this.nights++; }

    public override string ToString() {
      return $"{this.name} stayed {this.nights} nights in {this.sleepSpot} in ${this.visitPlace} {(this.isAbroad ? "abroad" : "")}";
    }

    public bool IsAbroad() {
      return this.isAbroad;
    }
  }
}
