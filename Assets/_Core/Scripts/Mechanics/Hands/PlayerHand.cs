using UnityEngine;

namespace TapSlotsTest.Mechanics.Hands
{
    public class PlayerHand : Hand
    {
        private void OnEnable()
        {
            gameManager.SelectShape += ChangeHandAppearance;
        }

        private void OnDisable()
        {
            gameManager.SelectShape -= ChangeHandAppearance;
        }

        private void ChangeHandAppearance()
        {
            _image.sprite = gameManager.PlayerShape switch
            {
                GameShapes.Rock => _rockSprite,
                GameShapes.Paper => _paperSprite,
                GameShapes.Scissors => _scissorsSprite,
                _ => _image.sprite
            };
        }
    }
}