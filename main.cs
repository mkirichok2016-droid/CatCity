using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Security.Cryptography;
using System.Buffers;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Numerics;

namespace CatCity {
public class Program
{ 
    public static void Main(string[] args)
    {
            City city_df = new City("ji");
            Cat cat_bruh = new Cat(125 , "trollbro");
            Cat cat_baybe = new Cat(1 , "troll");
            
            city_df.AddCats(cat_bruh);
            city_df.AddCats(cat_baybe);
            city_df.ShowStats();
            city_df.ShowCats();
    }
}
}
//   C# CODE:                                      ASSEMBLY CODE !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!:
//   Console.WriteLine("Hi");      
//                                                    /\_____________________________________/\
//                                                   /                                         \
//                                                  /                \_           _/            \
//                                                 (                   =   0.0   =               )
//                                                  \                   >   ^   <               /
//                                                   \_______                                  _/  /-------------------------------------------------\
//                                                           (                                )   <"I just spent 1000000000 years allocating stack bytes|
//                                                            )                              (     |    to print the letter H"                        |
//                                                           /                                \     \-------------------------------------------------/
//                                                         /                                    \
//                                                       /       .------------------------.       \
//                                                      /       /                          \       \
//                                                     |       |         M  O  V            |       |
//                                                     |       |         R  A  X            |       |    [ REGISTER STATUS LOGS ]
//                                                     |       |         1                  |       |    ▪ Change byte 5
//                                                     |       |                            |       |    ▪ 1-111
//                                                     |       |         M  O  V            |       |    ▪ 100111010 iii gpu == 122
//                                                   .-'-------|_________R__D__I____________|-------'-.  ▪ Memory Space: Infinite
//                                                  (          \                            /          )
//                                                   \________  [X]   [X]   [X]   [X]   [X]  ________/
// 