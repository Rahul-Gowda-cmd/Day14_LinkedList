﻿using System;

namespace LinkedList_Implimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wlcome to LinkedList program");
            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(70);
            //Console.WriteLine("The list before inserting 30 is : ");
            //list.Display();
            //list.InsertAtParticularPosition(2,30);
            //Console.WriteLine("The list after inserting 30 is : ");
            //list.Display();
            //list.InsertAtParticularPosition(3, 40);
            //Console.WriteLine("The list after inserting 40 is :  ");
            //list.Display();
            ////list.RemoveLastNode();
            ////Console.WriteLine("The list after removing last node is : ");
            ////list.Display();
            ////Console.WriteLine("Serach elment");
            ////list.Search(30);
            ////list.Display();
            //Console.WriteLine("After deleting 40");
            //list.Delete(40);
            //list.Display();
            SortedLinkedList list = new SortedLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("The ordered list after inserting 56,30,40,70 using sorted linked list is : ");
            list.Display();


        }
    }
}
