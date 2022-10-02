namespace Les8 {
  class Book : Product {
    private string bookName;
    private string author;

    public Book(int id, double price, string bookName, string author) : base(id, price) {
      this.bookName = bookName;
      this.author = author;
    }
  }
}
