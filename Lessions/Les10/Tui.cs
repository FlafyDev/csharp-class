using System;

namespace Les10 {
  class Tui {
    private GameOfLifeOptions options = new GameOfLifeOptions();
    private int selected = 0;

    public string Render() {
      string[] rowSymbol = new string[5];
      for (int i = 0; i < rowSymbol.Length; i++) {
        if (selected == i) {
          rowSymbol[i] = "-> ";
        } else {
          rowSymbol[i] = "   ";
        }
      }
string output = $@"-------------------
{rowSymbol[0]}Board Size:  {this.options.GetSize()}
{rowSymbol[1]}Auto restart: {BooleanToString(this.options.GetAutoRestart())}
{rowSymbol[2]}Alive chance: 1/{this.options.GetAliveChance()}
{rowSymbol[3]}Auto continue:  {BooleanToString(this.options.GetAutoContinue())}

{rowSymbol[4]}START
-------------------
      ".Trim();

      return output;
    }

    public bool BlockInput() {
      var keyInfo = Console.ReadKey();
      switch (keyInfo.Key) {
        case ConsoleKey.UpArrow:
          selected = (selected - 1) % 5;
          break;
        case ConsoleKey.DownArrow:
          selected = (selected + 1) % 5;
          break;
        case ConsoleKey.RightArrow:
          switch (selected) {
            case 0:
              this.options.SetSize(this.options.GetSize()+10);
              break;
            case 1:
              this.options.SetAutoRestart(!this.options.GetAutoRestart());
              break;
            case 2:
              this.options.SetAliveChance(this.options.GetAliveChance()+1);
              break;
            case 3:
              this.options.SetAutoContinue(!this.options.GetAutoContinue());
              break;
            case 4:
              return false;
          }
          break;
        case ConsoleKey.LeftArrow:
          switch (selected) {
            case 0:
              this.options.SetSize(this.options.GetSize()-10);
              break;
            case 1:
              this.options.SetAutoRestart(!this.options.GetAutoRestart());
              break;
            case 2:
              this.options.SetAliveChance(this.options.GetAliveChance()-1);
              break;
            case 3:
              this.options.SetAutoContinue(!this.options.GetAutoContinue());
              break;
            case 4:
              return false;
          }
          break;
      }

      return true;
    }

    public GameOfLifeOptions GetOptions() {
      return this.options;
    }

    private string BooleanToString(bool arg) {
      if (arg) return "Yes"; else return "No";
    } 
  }
}

