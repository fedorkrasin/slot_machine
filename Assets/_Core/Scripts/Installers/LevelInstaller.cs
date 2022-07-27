using TapSlotsTest.Managers;
using UnityEngine;
using Zenject;

namespace TapSlotsTest.Installers
{
    public class LevelInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallGameManager();
            InstallScreenManager();
        }
        
        private void InstallGameManager()
        {
            Container
                .Bind<GameManager>()
                .AsSingle();
        }
        
        private void InstallScreenManager()
        {
            Container
                .Bind<ScreenManager>()
                .FromComponentInHierarchy()
                .AsSingle();
        }
    }
}