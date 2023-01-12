namespace Les13 {
class Diary {
  private Event[] events;

  public Diary() { this.events = new Event[1000]; }

  public PhoneCall[] AllCalls(Date date) {
    PhoneCall[] phoneCalls = new PhoneCall[100];
    int length = 0;
    for (int i = 0; i < this.events.Length; i++) {
      /* PhoneCall call = this.events[i] as PhoneCall; */
      /* if (call.Same(date)) { */
      /*   phoneCalls[length] = this.events[i] as PhoneCall; */
      /*   length++; */
      /* } */
    }
    return phoneCalls;
  }
}
}
