using System;
using GPSParser;

public class MultiRecv
{
    public static void Main()
    {       
        Console.Write("Port to listen: ");
        int port = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Creating server...");
   
        AsynchronousIoServer Serv = new AsynchronousIoServer(port);
        Serv.Start();       

        Console.ReadLine();               
    }   
}