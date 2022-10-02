class Room {
  private int roomNum;
  private int roomType;
  private int nightsReserved;

  public Room(int roomNum, int roomType, int nightsReserved) {
    this.roomNum = roomNum;
    this.roomType = roomType;
    this.nightsReserved = nightsReserved;
  }

  void GetRoomNum(int roomNum) { this.roomNum = roomNum; }

  void GetRoomType(int roomType) { this.roomType = roomType; }

  void GetNightsReserved(int nightsReserved) {
    this.nightsReserved = nightsReserved;
  }

  int SetRoomNum() { return roomNum; }

  int SetRoomType() { return roomType; }

  int SetNightsReserved() { return nightsReserved; }

  double Income() {
    double price = 50;

    if (this.roomType == 2) {
      price = 100;
    }

    return this.nightsReserved * price;
  }
}
