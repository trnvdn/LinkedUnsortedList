using System;

namespace LinkedUnsortedList;

class Program
{
    public static void Main(string[] args)
    {
        var solution = new Solution();
        
        solution.AddItem(4);
        solution.AddItem(1);
        solution.AddItem(22);
        solution.AddItem(10);
        solution.AddItem(13);
        solution.AddItem(9);
        solution.AddItem(0);
        
        solution.PrintAll();
        
        solution.BubleSort();
        
    }
}