namespace Les13
{
  class Date {
    private int day;
    private int month;
    private int year;

    public Date(int day, int month, int year) {
      this.day = day;
      this.month = month;
      this.year = year;
    }

    public bool Same(Date other) {
      return this.day == other.day && this.month == other.month && this.year == other.year;

    }
  }
}
