using System;
using Unit4.CollectionsLib;

namespace Les21
{
    class Student
    {
        private string id;
        private int age;
        private bool isExist;

        public Student(string id, int age, bool isExist)
        {
            this.id = id;
            this.age = age;
            this.isExist = isExist;
        }

        public string GetId()
        {
            return id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public bool GetIsExist()
        {
            return isExist;
        }
        public void SetIsExist(bool isExist)
        {
            this.isExist = isExist;
        }
    }
    class Game
    {
        private string team1Name;
        private string team2Name;
        private int team1Score;
        private int team2Score;

        public Game(string team1Name, string team2Name, int team1Score, int team2Score)
        {
            this.team1Name = team1Name;
            this.team2Name = team2Name;
            this.team1Score = team1Score;
            this.team2Score = team2Score;
        }

        public virtual void PrintWinner()
        {
            if (team1Score == team2Score)
            {
                Console.WriteLine("Tie");
            }
            else if (team1Score > team2Score)
            {
                Console.WriteLine(team1Name);
            }
            else
            {
                Console.WriteLine(team2Name);
            }
        }


        public string GetTeam1Name()
        {
            return team1Name;
        }
        public void SetTeam1Name(string team1Name)
        {
            this.team1Name = team1Name;
        }
        public string GetTeam2Name()
        {
            return team2Name;
        }
        public void SetTeam2Name(string team2Name)
        {
            this.team2Name = team2Name;
        }
    }
    class HeziGame : Game
    {
        private bool wasFight;

        public HeziGame(string team1Name, string team2Name, int team1Score, int team2Score, bool wasFight) : base(team1Name, team2Name, team1Score, team2Score)
        {
            this.wasFight = wasFight;
        }

        public bool GetWasFight()
        {
            return this.wasFight;
        }

        public override void PrintWinner()
        {
            if (GetWasFight()) Console.WriteLine("There was a fight");
            base.PrintWinner();
        }
    }
    class Les21 : Lession
    {

        public static int NodeLength(Node<int> node)
        {
            int length = 0;
            while (node != null)
            {
                length += 1;
                node = node.GetNext();
            }
            return length;
        }

        public Node<int> Question1(Node<int> first)
        {
            int length = NodeLength(first);
            if (length == 1) return null;
            Node<int> p = first;
            if (length % 2 == 0)
            {
                int sum = 0;
                Node<int> middleNode = null;
                for (int i = 0; i < length; i++)
                {
                    sum += p.GetValue();

                    if (i == length / 2 - 1)
                    {
                        middleNode = p;
                        p = p.GetNext();
                        middleNode.SetNext(new Node<int>(sum, p));
                        sum = 0;
                    }
                    else
                    {
                        p = p.GetNext();
                    }
                }
                middleNode.GetNext().SetNext(new Node<int>(sum, middleNode.GetNext().GetNext()));
            }
            else
            {
                for (int i = 0; i < length / 2 - 1; i++)
                {
                    p = p.GetNext();
                }
                p.SetNext(p.GetNext().GetNext());
            }
            return first;
        }
        public void PrintNodeList(Node<int> first)
        {
            Node<int> p = first;
            while (p != null)
            {
                Console.Write(p.GetValue() + " -> ");
                p = p.GetNext();
            }
            Console.WriteLine("null");
        }
        public int CountExistStudents(Node<Student> first)
        {
            int count = 0;
            Node<Student> p = first;
            while (p != null)
            {
                if (p.GetValue().GetIsExist())
                {
                    count++;
                }
                p = p.GetNext();
            }
            return count;
        }
        // I changed the name from "GetExistStudent" to "GetNotExistStudent" 
        public Node<string> GetNotExistStudent(Node<Student> first)
        {
            Node<string> firstNames = null;
            Node<Student> p = first;
            while (p != null)
            {
                if (!p.GetValue().GetIsExist())
                {
                    firstNames = new Node<string>(p.GetValue().GetId(), firstNames);
                }
                p = p.GetNext();
            }
            return firstNames;
        }
        public Node<Student> AddStudent(Node<Student> first, Student s)
        {
            if (first == null) return new Node<Student>(s);
            Node<Student> p = first;
            while (p.GetNext() != null)
            {
                p = p.GetNext();
            }
            p.SetNext(new Node<Student>(s));
            return first;
        }

        public void PrintAllGames(Game[] games)
        {
            for (int i = 0; i < games.Length; i++)
            {
                Console.WriteLine("Game groups: " + games[i].GetTeam1Name() + ", " + games[i].GetTeam2Name());
                if (games[i] is HeziGame)
                {
                    ((HeziGame)games[i]).PrintWinner();
                }
                else
                {
                    games[i].PrintWinner();
                }
                Console.WriteLine("---------");
            }
        }

        public int CountAllGames(Game[] games)
        {
            int count = 0;
            for (int i = 0; i < games.Length; i++)
            {
                if (games[i] is HeziGame && ((HeziGame)games[i]).GetWasFight())
                {
                    count++;
                }
            }
            return count;
        }

        public override void Main()
        {
            // Node<int> n6 = new Node<int>(13);
            // Node<int> n5 = new Node<int>(6, n6);
            // Node<int> n4 = new Node<int>(10, n5);
            // Node<int> n3 = new Node<int>(0, n4);
            // Node<int> n2 = new Node<int>(-9, n3);
            // Node<int> n1 = new Node<int>(88, n2);
            //
            // 0 1 2 3 4 5 6 7

            // BiList biList = CreateBiList(n1);
            // PrintNodeList(biList.ls1);
            // PrintNodeList(biList.ls2);


            // Node<int> n6 = new Node<int>(9);
            Node<int> n5 = new Node<int>(15);
            Node<int> n4 = new Node<int>(7, n5);
            Node<int> n3 = new Node<int>(4, n4);
            Node<int> n2 = new Node<int>(-4, n3);
            Node<int> n1 = new Node<int>(3, n2);

            PrintNodeList(n1);
            Question1(n1);
            PrintNodeList(n1);



            // Node<int> n5 = new Node<int>(4);
            // Node<int> n4 = new Node<int>(8, n5);
            // Node<int> n3 = new Node<int>(2, n4);
            // Node<int> n2 = new Node<int>(1, n3);
            // Node<int> n1 = new Node<int>(5, n2);
            // 
            // Node<int> newFirst = Move(n1, 2);

            // PrintNodeList(newFirst);
        }
    }
}
