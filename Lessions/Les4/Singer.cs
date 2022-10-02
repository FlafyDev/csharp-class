namespace Les4 {
  class Singer : Artist {
    public Singer(int numOfFans) : base(numOfFans) { }

    public void SingerPrint() {
      Console.WriteLine("I am a great singer");
    }
  }
}
