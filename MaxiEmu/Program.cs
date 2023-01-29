using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Timers;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace MaxiEmu
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine(" __  __    _    __  _____ _____                 \r\n|  \\/  |  / \\   \\ \\/ /_ _| ____|_ __ ___  _   _ \r\n| |\\/| | / _ \\   \\  / | ||  _| | '_ ` _ \\| | | |\r\n| |  | |/ ___ \\  /  \\ | || |___| | | | | | |_| |\r\n|_|  |_/_/   \\_\\/_/\\_\\___|_____|_| |_| |_|\\__,_|\r\n                                                ");

            string Game = System.Environment.CommandLine.Substring(System.Environment.CommandLine.Length - 3);
            string GameID = "WM6";
            string Dir = Environment.CurrentDirectory;

            //DirectoryInfo di = new DirectoryInfo(Mydir);
            //DirectoryInfo diParent = di.Parent;

                    Console.WriteLine(Game);

            if (Game == GameID)
                {



                var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                    Console.WriteLine("Start Terminal Emulaition");

                    //string CommandStr = System.Environment.CommandLine;

                    Process proc = new Process();

                    proc.StartInfo.FileName = Dir + @"\OpenParrotx64\MaxiTerminal\6\start.bat";
                    proc.StartInfo.Arguments = Dir + @"\OpenParrotx64\MaxiTerminal\6\";

                    Console.WriteLine("Game:" + Game);


                    proc.Start();

                System.Threading.Thread.Sleep(5000);

                // タイマーの間隔(ミリ秒)
                Timer timer = new Timer(3000);

                    // タイマーの処理
                    timer.Elapsed += (sender, e) =>
                    {

                        if (Process.GetProcessesByName("wmn6r").Length > 0)
                        {

                            //Console.WriteLine("起動しています");

                        }
                        else
                        {
                            Console.WriteLine("Stop Emulaition");
                            proc.CloseMainWindow();
                            proc.Close();
                            //proc.Kill();

                            Environment.Exit(0);

                        }

                    };

                    // タイマーを開始する
                    timer.Start();

                    Console.ReadKey();

                }
                else
                {



                var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

                    Console.WriteLine("Start Terminal Emulaition");

                    //string CommandStr = System.Environment.CommandLine;

                    Process proc = new Process();

                    proc.StartInfo.FileName = Dir + @"\OpenParrotx64\MaxiTerminal\6R\start.bat";
                    proc.StartInfo.Arguments = Dir + @"\OpenParrotx64\MaxiTerminal\6R\";

                    Console.WriteLine("Game:" + Game);

                System.Threading.Thread.Sleep(5000);

                proc.Start();

                    // タイマーの間隔(ミリ秒)
                    Timer timer = new Timer(3000);

                    // タイマーの処理
                    timer.Elapsed += (sender, e) =>
                    {

                        if (Process.GetProcessesByName("wmn6r").Length > 0)
                        {

                            //Console.WriteLine("起動しています");

                        }
                        else
                        {
                            Console.WriteLine("Stop Emulaition");
                            proc.CloseMainWindow();
                            proc.Close();
                            //proc.Kill();

                            Environment.Exit(0);

                        }

                    };

                    // タイマーを開始する
                    timer.Start();

                    Console.ReadKey();

                }

            }



 
    }

}
