using System;

namespace Les10 {
  class Les10 : Lession {
    public override void Main() {
      Tui tui = new Tui();

      while (true) {
        Console.Clear();
        Console.WriteLine(tui.Render());
        while (tui.BlockInput()) {
          Console.Clear();
          Console.WriteLine(tui.Render());
        }

        GameOfLife gameOfLife = new GameOfLife(tui.GetOptions());
        while (gameOfLife.GameLoop()) {
          gameOfLife = new GameOfLife(tui.GetOptions());
        }
      }
    }
  }
}
