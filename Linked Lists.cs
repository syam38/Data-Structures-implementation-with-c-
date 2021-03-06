//The following program implements linked list using C# language with add at the front,add at the end,delete at the front,delete at the end.
// Program is written without using the collections provided by the framework.

 using System;

namespace DataStructures
{
    class mainscreen

    {
        static void Main(string[] args)
        {
            //Console.WriteLine("write a element to be  inerted into the linked list");
            //string elementToBeInserted = Console.ReadLine();
            LinkedList a = new LinkedList();
            string num;


            while (true)
            {
                Console.WriteLine("\nList Operations\n");
                Console.WriteLine("===============\n");
                Console.WriteLine("1.Insert element at the front\n");
                Console.WriteLine("2.Insert element at the end\n");
                Console.WriteLine("3.Display\n");
                Console.WriteLine("4.Delete element at the front\n");
                Console.WriteLine("5.Delete element at the end\n");
                //Console.WriteLine("4.Exit\n");
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice <= 0)
                {
                    Console.WriteLine("Enter only an Integer\n");
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the number to insert : ");
                            num = Console.ReadLine();
                            a.addElementFirst(num);
                            break;
                        case 2:
                            Console.WriteLine("Enter the number to insert : ");
                            num = Console.ReadLine();
                            a.addElementLast(num);
                            break;
                        case 3:
                            a.printelements();
                            break;
                        case 4:
                            a.deleteElementFirst();
                            break;
                        case 5:
                            a.deleteElementLast();
                            break;

                    }

                }
            }
        }
        // A node which contains the data and a class 
        class node
        {
            public node next;
            public Object num;
        }
        class LinkedList
        {
            private node head = null;
            private node current, newnode, previous;
            // method which adds element to the linked list 
            public void addElementLast(Object element)
            {
                if (head == null)
                {
                    head = new node();
                    head.num = element;
                    head.next = null;
                }
                else
                {
                    newnode = new node();
                    newnode.num = element;
                    newnode.next = null;
                    current = head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = newnode;
                    // head = newnode;
                    // newnode.num = element;
                    //newnode.next = null;
                }
            }
            // method which adds elemnt before the first node
            public void addElementFirst(Object element)
            {
                if (head == null)
                {
                    head = new node();
                    head.num = element;
                    head.next = null;
                }
                else {
                    current = new node();
                    current.num = element;
                    current.next = head;
                    head = current;
                }
                
            }
            //prints all the elements in the list 
            public void printelements()
            {
                node printcurrent = head;
                Console.WriteLine("Elements in the List are\n");
                while (printcurrent!= null)
                {
                     Console.Write("{0}\t", printcurrent.num);
                    printcurrent = printcurrent.next;
                }
            }
            //method which deletes the starting node
            public void deleteElementFirst()
            {
                current = head;
                head = current.next;
            }
            //method which deletes the last node
            public void deleteElementLast()
            {
                current = head;
                while (current.next != null)
                {
                    previous = current;
                    current = current.next;
                }
                previous.next = null;


            }
        }


    }
}
