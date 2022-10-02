namespace Les4 {
  class Painter : Artist {
    public Painter(int numOfFans) : base(numOfFans) { }

    public void PainterPrint() {
      Console.WriteLine("I am a great painter");
    }
  }
}
