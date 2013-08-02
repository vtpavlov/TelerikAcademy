/*
 * Implement the "Falling Rocks" game in the text console. 
 * A small dwarf stays at the bottom of the screen and can 
 * move left and right (by the arrows keys). A number of rocks 
 * of different sizes and forms constantly fall down and you 
 * need to avoid a crash.
 * Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed 
 * with appropriate density. The dwarf is (O). 
 * Ensure a constant game speed by Thread.Sleep(150).
 * Implement collision detection and scoring system.
*/

using System;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;

class FallingRocks
{
    struct Position
    {
        public int X, Y;
        public string symbol;
        public ConsoleColor color;

        public Position(int x, int y, string symbol, ConsoleColor color)
        {
            this.X = x;
            this.Y = y;
            this.symbol = symbol;
            this.color = color;
        }
    }

    static void Main()
    {
        Thread oThread = new Thread(new ThreadStart(Mainn));
        Thread aThread = new Thread(new ThreadStart(Clr));
        
        aThread.Start();
        oThread.Start();
        oThread.Join();
        aThread.Join();
    }

    static void Clr()
    {
        while (true)
        {
            Thread.Sleep(10);
            Console.Clear();
        }
    }
    static void Mainn()
    {
        //Random generator for rocks color, position and symbol
        Random randomGenerator = new Random();
        
        //Sleep time for the game loop
        double sleepTime = 150;
        //Console settings
        Console.CursorVisible = false;
        Console.BufferHeight = Console.WindowHeight;
        
        //number of rocks in the Array rocks
        int rocksCount = 0;

        //array with the symbols of the rocks
        string[] symbols = new string[] { "^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" };
        
        //array with colors for the rocks
        ConsoleColor[] colors = new ConsoleColor[] {ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.Gray};
        
        //array with rocks
        Position[] rocks = new Position[200];
        
        //position for the dwarf
        Position dwarf = new Position(10, Console.WindowHeight  - 1,"(0)",ConsoleColor.Red);
        
        //bool variable to say when the game loop to be over
        bool gameLoop = true;

        //variable keeping the score
        ulong score = 0;

        //the game loop
        while (gameLoop)
        {
            //score is growing as the cycle runs
            score++;

            //setting the Y component for all the rocks in the array to grow with 2
            for (int i = 0; i <= rocks.Length - 1; i++)
            {
                rocks[i].Y = rocks[i].Y + 2;
            }

            //generating rocks
            for (int x = 0; x <= randomGenerator.Next(2, 4); x++)
            {
                rocks[rocksCount] = new Position(randomGenerator.Next(x * 15, x * 15 + 20), 0
                    , symbols[randomGenerator.Next(0, symbols.Length - 1)]
                    , colors[randomGenerator.Next(0, colors.Length - 1)]);
                if (rocksCount >= 199) rocksCount = 0;
                rocksCount++;
            }

            //printing the rocks and other stuff
            foreach (var item in rocks)
            {
                foreach (var rock in rocks)
                {
                    //checking for colision
                    if ((rock.X >= dwarf.X) && (rock.X <= (dwarf.X + 2)) && (rock.Y == dwarf.Y))
                    {
                        gameLoop = false;
                        break;
                    }
                } 

                //printing the rocks
                if (item.Y < Console.WindowHeight)
                {                    
                    Console.SetCursorPosition(item.X, item.Y);
                    Console.ForegroundColor = item.color;
                    Console.Write(item.symbol);
                }

                //checking for key pressed
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        if(dwarf.X < Console.WindowWidth - 20)
                        {
                            //removing the old positions of the dwarf and increasing his X value
                            Console.SetCursorPosition(dwarf.X, dwarf.Y);
                            Console.Write("   ");
                            dwarf.X++;
                        }
                    }
                    if (pressedKey.Key == ConsoleKey.LeftArrow)                       
                    {
                        if(dwarf.X >= 1)
                        {
                            //removing the old positions of the dwarf and decreasing his X value
                            Console.SetCursorPosition(dwarf.X, dwarf.Y);
                            Console.Write("   ");
                            dwarf.X--;
                        }
                    }
                }
            }
          
            //printing the dwarf
            Console.SetCursorPosition(dwarf.X, dwarf.Y);
            Console.ForegroundColor = dwarf.color;
            Console.Write(dwarf.symbol);            
            
            //sleeping the loop for sometime
            //Thread.Sleep((int)sleepTime);

            //reducing the sleep time of the loop
            sleepTime -= 0.5;

            
            //removing the rocks 
            //foreach (var item in rocks)
            //{
            //    if (item.Y < Console.WindowHeight)
            //    {
            //        Console.SetCursorPosition(item.X, item.Y);
            //        Console.Write(" ");
            //    }
            //}                        
        }
        //Printing the score after the game is over
        Console.Clear();
        Console.WriteLine("Game over! Your score is: " + score);

    }
}
