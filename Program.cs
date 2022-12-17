// all the shit up here is auto generated so im too scared to see what removing it does
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Save_Deletor 
{
    internal class Program
    {

        static void hm1_deleter()
        {
            string name = Environment.UserName;

            while (true)
            {
                Process[] hotline = Process.GetProcessesByName("HotlineGL");
                if (hotline.Length == 0)
                {
                    Thread.Sleep(2);
                    File.Delete($@"C:\Users\{name}\Documents\My Games\HotlineMiami\SaveData.sav");
                    Console.WriteLine($"Save Game Deleted || {DateTime.Now}");
                    Thread.Sleep(2);
                    break;
                }
            }
        }

        static void hm2_deleter()
        {
            string name = Environment.UserName;

            while (true)
            {
                Process[] hotline = Process.GetProcessesByName("HotlineMiami2");
                if (hotline.Length == 0)
                {
                    Thread.Sleep(2);
                    File.Delete($@"C:\Users\{name}\Documents\My Games\HotlineMiami2\savedata.vfs");
                    Console.WriteLine($"Save Game Deleted || {DateTime.Now}");
                    Thread.Sleep(2);
                    break;
                }
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Made by Auzie#1557\n\n[1] Hotline Miami 1\n\n--------------------\n\n[2] Hotline Miami 2\n\n ");
            string version = Console.ReadLine();
            if (version == "1")
            {
                Console.WriteLine("Selected Hotline 1");
                while (true) { 
                    hm1_deleter();
            }

            }
            else if (version == "2")
            {
                Console.WriteLine("Selected Hotline 2");
                while (true){
                    hm2_deleter();
                }

            }
            else
            {
                Console.WriteLine("Not an avaliable option");
                Console.ReadLine();
            }

        }
    }
}
    
