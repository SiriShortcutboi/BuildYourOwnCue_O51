using System;
using System.Runtime.InteropServices.Marshalling;

public class Program //BuildYourOwnQueueO51
{
	public static void Main()
	{
		SimpleQueue queue = new SimpleQueue();

        queue.Enqueue("Knight");
        queue.Enqueue("Mage");
        queue.Enqueue("Archer");

        //Console.WriteLine(queue.Dequeue());
       // Console.WriteLine(queue.Dequeue());
       // Console.WriteLine(queue.Dequeue());
	}
}

public class SimpleQueue
{
    //Array<string> array = new Array<string> {"1", "2","3","4","5","6","7", "8", "9", "10",};
    private string[] items = new string[10]; //declare 10 slots automatically
    private int count = 0;

    public void Enqueue(string item)
    {
        items.Append(item);
        count++;
        
    }

    public string Dequeue()
    {
        string temp = items[0];
        items.RemoveAt(0);//test this
        count--; 
        return temp;
     

    }
}

