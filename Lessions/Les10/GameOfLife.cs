using System;
using System.Threading;

namespace Les10 {
  class GameOfLife {
    private int[,] matrix;
    private Random random;
    private GameOfLifeOptions options;

    public GameOfLife(GameOfLifeOptions options) {
      this.options = options;
      this.random = new Random();

      matrix = new int[options.GetSize(),options.GetSize()];
      for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
          matrix[i, j] = 1 - Math.Min(random.Next(0, options.GetAliveChance()+1), 1);
        }
      }
    }

    private int GetCellNum(int row, int col) {
      if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1)) {
        return this.matrix[row, col];
      }
      return 0;
    }

    public int CountNeightbors(int row, int col) {
      return GetCellNum(row+1, col)
        + GetCellNum(row+1, col+1)
        + GetCellNum(row+1, col-1)
        + GetCellNum(row-1, col)
        + GetCellNum(row-1, col+1)
        + GetCellNum(row-1, col-1)
        + GetCellNum(row, col-1)
        + GetCellNum(row, col+1);
    }
    
    public int NextLife(bool isAlive, int numNeighbors) {
      if (isAlive) {
        if (numNeighbors == 2 || numNeighbors == 3) {
          return 1;
        }
      } else if (numNeighbors == 3) {
        return 1;
      }
      return 0;
    }

    public bool UpdateNextGeneration() {
      int[,] newMatrix = new int[this.matrix.GetLength(0),this.matrix.GetLength(1)];
      bool isStuck = false;

      for (int i = 0; i < newMatrix.GetLength(0); i++) {
        for (int j = 0; j < newMatrix.GetLength(1); j++) {
          newMatrix[i, j] = NextLife(matrix[i, j] == 1, CountNeightbors(i, j));

          if (newMatrix[i, j] != matrix[i, j]) {
            isStuck = true;
          }
        }
      }
      
      this.matrix = newMatrix;
      return isStuck;
    }

    public void PrintGeneration() {
      for (int i = 0; i < this.matrix.GetLength(0); i++) {
        for (int j = 0; j < this.matrix.GetLength(1); j++) {
          if (this.matrix[i, j] == 1) {
            Console.Write(" ■ ");
          } else {
            Console.Write("   ");
          }
        }
        Console.WriteLine();
      }
    }
    
    public bool GameLoop() {
      while (true) {
        Console.Clear();
        this.PrintGeneration();
        if (this.options.GetAutoContinue()) {
          Thread.Sleep(200);
        } else {
          Console.ReadLine();
        }
        if (!this.UpdateNextGeneration()) {
          // It's stuck!
          if (this.options.GetAutoRestart()) {
            Thread.Sleep(1000);
            return true;
          } else {
            Console.ReadLine();
            return false;
          }
        };
      }
    }
  }
}
