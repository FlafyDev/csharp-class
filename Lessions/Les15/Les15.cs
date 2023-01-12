using System;
using Unit4.CollectionsLib;

namespace Les15
{
    class Trempiada
    {
        Queue<string> queueM;
        Queue<string> queueF;
        Queue<string> queueC;

        public Trempiada()
        {
            queueM = new Queue<string>();
            queueF = new Queue<string>();
            queueC = new Queue<string>();
        }

        public void AddPerson(string name, char t)
        {
            switch (t)
            {
                case 'm':
                    queueM.Insert(name);
                    return;
                case 'f':
                    queueF.Insert(name);
                    return;
                case 'c':
                    queueC.Insert(name);
                    return;
            }
        }

        public string RemovePerson()
        {
            if (!queueF.IsEmpty()) return queueF.Remove();
            else if (!queueM.IsEmpty()) return queueM.Remove();
            else return queueC.Remove();
        }

        public bool IsEmpty()
        {
            return queueM.IsEmpty() && queueF.IsEmpty() && queueC.IsEmpty();
        }
    }

    public class C
    {
        public virtual void Dolt(D d) { Console.WriteLine("a"); }
    }

    public class D : C
    {
        public override void Dolt(D d) { Console.WriteLine("b"); }
        public void Dolt(C c) { Console.WriteLine("x"); }
    }

    class Les15 : Lession
    {
        public void GiveRides(Trempiada trempiada, int freeSlots)
        {
            if (freeSlots < 1) return;
            if (trempiada.IsEmpty())
            {
                Console.WriteLine("No one  needs a ride.");
                return;
            }
            Console.WriteLine(trempiada.RemovePerson());
            GiveRides(trempiada, freeSlots - 1);
        }

        public void QueCouples(Queue<int> que)
        {
            Queue<int> queTemp = new Queue<int>();
            Queue<int> queTemp2 = new Queue<int>();
            Queue<int> newQue = new Queue<int>();
            while (!que.IsEmpty())
            {
                queTemp.Insert(que.Head());
                queTemp2.Insert(que.Remove());
            }
            while (!queTemp.IsEmpty())
            {
                while (!queTemp2.IsEmpty())
                {


                }
                que.Insert(queTemp.Remove());
            }



        }


        public override void Main()
        {
            C cd = new D();
            D dd = (D) cd;


        }

    }
}
