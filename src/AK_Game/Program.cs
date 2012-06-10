//-----------------------------------------------------------------------------
// FSM Implementation
// (c) 2012, Andr� Kishimoto
//-----------------------------------------------------------------------------

using System;

namespace AK_Game
{
    static class Program
    {
        //-----------------------------------------------------------------------------
        // Start point
        //-----------------------------------------------------------------------------
        static void Main(string[] args)
        {
            using (GameExample game = new GameExample())
            {
                game.Run();
            }
        }
    }
}

