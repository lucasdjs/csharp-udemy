﻿using System.Collections.Generic;

//HashSet<string> set = new HashSet<string>();

//set.Add("TV");
//set.Add("Notebook");
//set.Add("Tablet");

//Console.WriteLine(set.Contains("pc"));

//foreach (string p in set)
//{
//    Console.WriteLine(p);
//}


SortedSet<int> a = new SortedSet<int>() {0,1,2,4,5,8,10 };

SortedSet<int> b = new SortedSet<int>() { 3,5, 6, 7, 8, 9, 10 };


//union 

 SortedSet<int> c = new SortedSet<int>(a);

c.UnionWith(b);

PrintCollection(c);

//intersection

SortedSet<int> d = new SortedSet<int>(a);

d.IntersectWith(b);

PrintCollection(d);

//difference

SortedSet<int> e = new SortedSet<int>(a);

e.ExceptWith(b);

PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}