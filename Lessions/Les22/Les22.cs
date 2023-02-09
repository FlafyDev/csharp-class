using System;
using Unit4.BinTreeUtilsLib;
using Unit4.CollectionsLib;

namespace Les22
{
    class Les22 : Lession
    {
     public static int CountAllBNodes(BinNode<int> bt)
    {
      if (bt == null) return 0;
      return CountAllBNodes(bt.GetLeft()) + CountAllBNodes(bt.GetRight()) + 1;
    }

    public static int SumTree(BinNode<int> bt)
    {
      if (bt == null) return 0;
      return SumTree(bt.GetLeft()) + SumTree(bt.GetRight()) + bt.GetValue();
    }

    public static int SumOfEvenBNodes(BinNode<int> bt)
    {
      if (bt == null) return 0;
      int val = 0;

      if (val % 2 == 0) val = bt.GetValue();

      return SumOfEvenBNodes(bt.GetLeft()) + SumOfEvenBNodes(bt.GetRight()) + val;
    }

    public static int SumOfLeavesBNodes(BinNode<int> bt)
    {
      if (bt == null) return 0;
      if (bt.GetLeft() == null && bt.GetRight() == null) return bt.GetValue();
      return SumOfLeavesBNodes(bt.GetLeft()) + SumOfLeavesBNodes(bt.GetRight());
    }

    public static int CountLeavesBNodes(BinNode<int> bt)
    {
      if (bt == null) return 0;
      if (bt.GetLeft() == null && bt.GetRight() == null) return 1;
      return CountLeavesBNodes(bt.GetLeft()) + CountLeavesBNodes(bt.GetRight());
    }

    public static int CountOnlyEvenBNodes(BinNode<int> bt)
    {
      if (bt == null) return 0;

      return CountOnlyEvenBNodes(bt.GetLeft()) + CountOnlyEvenBNodes(bt.GetRight()) + (1 - bt.GetValue() % 2);
    }

        public override void Main()
        {
            BinNode<int> bt = BinTreeUtils.BuildRandomTree(10, 0, 100);
            // BTreePrinter.Print(bt);
            Unit4.BinTreeCanvasLib.TreeCanvas.AddTree(bt);
            Console.WriteLine();
        }
    }
}
