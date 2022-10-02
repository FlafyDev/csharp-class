namespace Les4 {
  class Artist {
    protected int numOfFan;

    public Artist(int numOfFan) {
      this.numOfFan = numOfFan;
    }

    public void ArtistPrint() {
      Console.WriteLine($"I have a very special soul because I am an artist, I have {this.numOfFan} fans that admire me");
    }
  }
}
