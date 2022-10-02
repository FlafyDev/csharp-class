namespace Les4 {
  class Writer : Artist {
    public Writer(int numOfFans) : base(numOfFans) { }

    public void WriterPrint() {
      Console.WriteLine("I am a great writer");
    }
  }
}
