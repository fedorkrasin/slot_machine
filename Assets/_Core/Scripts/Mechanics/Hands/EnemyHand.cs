using System;
using Random = UnityEngine.Random;

namespace TapSlotsTest.Mechanics.Hands
{
    public class EnemyHand : Hand
    {
        private void OnEnable()
        {
            gameManager.StartMatch += RandomizeShape;
        }

        private void OnDisable()
        {
            gameManager.StartMatch -= RandomizeShape;
        }

        private void RandomizeShape()
        {
            var gameShapesArray = Enum.GetValues(typeof(GameShapes));
            var randomShapeIndex = Random.Range(0, gameShapesArray.Length);
            var randomShape = (GameShapes)gameShapesArray.GetValue(randomShapeIndex);

            _image.sprite = randomShape switch
            {
                GameShapes.Rock => _rockSprite,
                GameShapes.Paper => _paperSprite,
                GameShapes.Scissors => _scissorsSprite,
                _ => _image.sprite
            };

            gameManager.SelectEnemyShape(randomShape);
        }
    }
}