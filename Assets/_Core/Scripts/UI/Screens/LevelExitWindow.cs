using UnityEngine;
using Zenject;

namespace TapSlotsTest.Screens.UI
{
    public class LevelExitWindow : Screen
    {
        public void AcceptExit()
        {
            gameManager.ExitToMenu();
            screenManager.HideAll();
            screenManager.Show<MenuScreen>();
        }

        public void DeclineExit()
        {
            screenManager.Hide(this);
        }
    }
}