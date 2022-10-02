namespace Les4 {
  class Les4 : Lession {
    public override void Main() {
      // 2
      // `singer.PainterPrint();` is wrong. Singer doesn't have the function "PainterPrint".
      // `artist1.SingerPrint();` is wrong. Artist doesn't have the function "SingerPrint".
      // `((Singer)artist1).SingerPrint();` is wrong. Artist can not be casted into Singer.
      // `artist2.SingerPrint();` is wrong. Artist doesn't have the function "SingerPrint".

      // Without the wrong lines:
      Singer singer = new Singer (4);
      singer.SingerPrint();
      singer.ArtistPrint();
      Artist artist1 = new Artist (200);
      artist1.ArtistPrint();
      Artist artist2 = new Singer(68);
      artist2.ArtistPrint();

      // 3
      // Output:
      //
      // I am a great singer
      // I have a very special soul because I am an artist, I have 4 fans that admire me
      // I have a very special soul because I am an artist, I have 200 fans that admire me
      // I have a very special soul because I am an artist, I have 68 fans that admire me
    }
  }
}
