using System;
using Unit4.CollectionsLib;

namespace Les17
{
    static class NewYearsWork
    {
        // From the question.
        public class Person
        {
            private string name;
            private bool isPositive;//מאומת לקורונה
            private int drinks;//כמות משקאות
            private bool hasBeenKissed;

            public Person(string name, bool isPositive, int drinks, bool isKiss)
            {
                this.name = name;
                this.isPositive = isPositive;
                this.drinks = drinks;
                this.hasBeenKissed = isKiss;
            }

            public Person(Person person)//copy sonstructor
            {
                this.name = person.name;
                this.isPositive = person.isPositive;
                this.drinks = person.drinks;
                this.hasBeenKissed = person.hasBeenKissed;
            }
            public int GetDrinks()
            {
                return drinks;
            }
            public bool GetIsPositive()
            {
                return isPositive;
            }
            public void SetIsPositiveForTrue()
            {
                isPositive = true;
            }
            public string GetName()
            {
                return name;
            }
            public void SetName(string name)
            {
                this.name = name;
            }
            public bool GetIsKiss()
            {
                return hasBeenKissed;
            }
        }
        public class Party
        {
            private Node<Person> partyPeople;

            public Party()
            {
                this.partyPeople = null;
            }

            public void AddPerson(Person person)
            {
                Node<Person> p = this.partyPeople;
                if (p == null)
                {
                    this.partyPeople = new Node<Person>(person);
                    return;
                }

                while (p.GetNext() != null)
                {
                    p = p.GetNext();
                }

                p.SetNext(new Node<Person>(person));
            }

            public void PrintDrinks()
            {
                Node<Person> p = this.partyPeople;
                int totalDrinks = 0;
                while (p != null)
                {
                    totalDrinks += p.GetValue().GetDrinks();
                    p = p.GetNext();
                }
                Console.WriteLine(totalDrinks);
            }

            public int CountPositive()
            {
                Node<Person> p = this.partyPeople;
                int positives = 0;
                while (p != null)
                {
                    if (p.GetValue().GetIsPositive())
                    {
                        positives += 1;
                    }
                    p = p.GetNext();
                }
                return positives;
            }

            public bool IsBetweenTwoPositive(string name)
            {
                Node<Person> p = this.partyPeople;
                Node<Person> prev = null;
                while (p != null)
                {
                    Node<Person> next = p.GetNext();
                    if (prev != null && next != null && prev.GetValue().GetIsPositive() && next.GetValue().GetIsPositive() && p.GetValue().GetName() == name)
                    {
                        return true;
                    }
                    prev = p;
                    p = next;
                }
                return false;
            }

            public void UpdatePositive()
            {
                Node<Person> p = this.partyPeople;
                while (p != null)
                {
                    if (p.GetValue().GetIsKiss())
                    {
                        p.GetValue().SetIsPositiveForTrue();
                    }
                    p = p.GetNext();
                }
            }

            public void UpdatePositiveIfBetween()
            {
                Node<Person> p = this.partyPeople;
                while (p != null)
                {
                    if (p.GetValue().GetIsKiss())
                    {
                        if (IsBetweenTwoPositive(p.GetValue().GetName()))
                        {
                            p.GetValue().SetIsPositiveForTrue();
                        }
                    }
                    p = p.GetNext();
                }
            }
        }
    }
}
