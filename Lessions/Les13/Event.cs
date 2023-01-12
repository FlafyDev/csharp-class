namespace Les13 {
  class Event {
    private Date date;
    private int hour;

    public Event(Date date, int hour) {
        this.date = date;
        this.hour = hour;
    }

    public virtual bool Match(string name) {
      return false;
    }

  }

  class Meeting : Event {
    private string[] arrNames;
    private int duration;
    private string location;

    public Meeting(Date date, int hour, string[] arrNames, int duration, string location) : base(date, hour) {
      this.arrNames = arrNames;
      this.duration = duration;
      this.location = location;
    }

    public override bool Match(string name) {
      for (int i = 0; i < this.arrNames.Length; i++) 
      {
        if (name == this.arrNames[i]) {
          return true;
        }
      }
      return false;
    }
  }

  class PhoneCall : Event {
    public string phoneNumber;
    public string name;

    public PhoneCall(Date date, int hour, string phoneNumber, string name) : base(date, hour) {
      this.phoneNumber = phoneNumber;
      this.name = name;
    }

    public override bool Match(string name) {
      return this.name == name;
    }
  }

  class Task : Event {
    private string title;

    public Task(Date date, int hour, string title) : base(date, hour) {
      this.title = title;
    }
  }
}
