using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Screen = TapSlotsTest.Screens.UI.Screen;

namespace TapSlotsTest.Managers
{
    public class ScreenManager : MonoBehaviour
    {
        [SerializeField] private List<Screen> _screens;

        public List<Screen> Screens => _screens;
        
        public T GetScreen<T>() where T : Screen
        {
            var screen = _screens.First(s => s is T);
            return screen as T;
        }

        public void Show<T>() where T : Screen
        {
            GetScreen<T>().Show();
        }

        public void Show(Screen screen)
        {
            screen.Show();
        }
        
        public void Hide<T>() where T : Screen
        {
            GetScreen<T>().Hide();
        }

        public void Hide(Screen screen)
        {
            screen.Hide();
        }

        public void HideAll()
        {
            _screens.ForEach(Hide);
        }

        public bool IsScreenVisible<T>() where T : Screen
        {
            var screen = GetScreen<T>();
            return screen != null && screen.IsActive();
        }

        public Screen GetCurrentScreen()
        {
            return _screens.First(s => s.IsActive());
        }
    }
}
