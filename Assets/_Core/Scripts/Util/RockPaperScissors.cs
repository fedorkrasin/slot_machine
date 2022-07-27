using System;
using TapSlotsTest.Mechanics;

namespace TapSlotsTest.Util
{
    public static class RockPaperScissors
    {
        public static bool IsFirstShapeWinner(GameShapes firstShape, GameShapes secondShape)
        {
            return firstShape switch
            {
                GameShapes.Rock => secondShape == GameShapes.Scissors,
                GameShapes.Paper => secondShape == GameShapes.Rock,
                GameShapes.Scissors => secondShape == GameShapes.Paper,
                _ => false
            };
        }

        public static bool IsDraft(GameShapes firstShape, GameShapes secondShape)
        {
            return firstShape == secondShape;
        }
    }
}