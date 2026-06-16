using System;
using System.Threading;

namespace RockPaperScissor;
internal class Display
{
    internal static void StartScreen()
    {
        Console.WriteLine("Test");
    }
    internal class Hand
    {
        internal class Dual
        {
            internal static void FistShake()
            {
                Console.WriteLine("""


                    ____________                                  ____________
                  /              \                              /              \
                 /                |_____                  _____|                \
                /          __     |     \                /     |     __          \
                           ___\    \ ___/                \____/    /___           
                          /    \    \   \                /   /    /    \          
                          \_____\___/___/                \___\___/_____/          
                           /            \                /            \           
                           \____________/                \____________/           
                            /           \                /           \            
                            \___________/                \___________/            
                \___________________/                        \___________________/


                """);
            }
        }
        internal class Left
        {
            internal static void Fist()
            {
                Console.Write("""


                    ____________
                  /              \  
                 /                |_____
                /          __     |     \
                           ___\    \ ___/
                          /    \    \   \
                          \_____\___/___/
                           /            \
                           \____________/
                            /           \
                            \___________/
                \___________________/
                

                """);
            }
        }
        internal class Right
        {
            internal static void Fist()
            {
                Console.WriteLine("""


                                                                 ____________
                                                               /              \
                                                         _____|                \
                                                        /     |     __          \
                                                        \____/    /___           
                                                        /   /    /    \          
                                                        \___\___/_____/          
                                                        /            \           
                                                        \____________/           
                                                        /           \            
                                                        \___________/            
                                                            \___________________/


                """);
            }
            internal static void Rock()
            {
                Console.WriteLine("""


                                                                 ____________
                                                               /              \
                                                         _____|_____           \
                                                        /            \          \
                                                        \____________/           
                                                        /             \          
                                                        \_____________/          
                                                        /            \           
                                                        \____________/           
                                                        /           \            
                                                        \___________/            
                                                            \___________________/


                """);
            }
            internal static void Paper()
            {
                Console.WriteLine("""


                                                                 ____________
                                                               /              \
                                            __________________/                \
                                          /     |      |     /     ______       
                                        __\_____|______|____|    /        \  
                                       /      |      |       \__/          
                                       \______|______|_________          
                                          /     |      |                        
                                          \_____|______|_________            
                                               /     |      |                     
                                               \_____|______|_______             
                                                            \___________________/


                """);
            }
            internal static void Scissor()
            {
                Console.WriteLine("""
                                         ,---_  
                                        |      `-_
                                         `-_   /   `-_           ____________
                                             `-_       `-_     /              \
                                                 `-_  /    `-_/                \
                                                     `-_     /     ______       
                                                        `-__|    /        \  
                                                ____---´´´   \__/          
                                       ,----´´´´   \     ____________    
                                      |     \   ____----/            \           
                                       ´----´´´´        \____________/           
                                                        /           \            
                                                        \___________/            
                                                            \___________________/


                """);
            }
        }
    }
}