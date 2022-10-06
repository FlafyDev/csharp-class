
namespace Les10 {
  class GameOfLifeOptions {
    private int size = 10;
    private bool autoRestart = false; 
    private int aliveChance = 1; 
    private bool autoContinue = false; 

    public int GetSize() {
      return size;
    }

    public void SetSize(int size) {
      this.size = size;
    }

    public bool GetAutoRestart() {
      return autoRestart;
    }

    public void SetAutoRestart(bool autoRestart) {
      this.autoRestart = autoRestart;
    }

    public int GetAliveChance() {
      return aliveChance;
    }

    public void SetAliveChance(int aliveChance) {
      this.aliveChance = aliveChance;
    }

    public bool GetAutoContinue() {
      return autoContinue;
    }

    public void SetAutoContinue(bool autoContinue) {
      this.autoContinue = autoContinue;
    }
  }
}
