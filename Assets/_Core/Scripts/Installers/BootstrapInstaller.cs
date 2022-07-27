using TapSlotsTest.Managers;
using Zenject;

namespace TapSlotsTest.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            InstallStatisticsManager();
        }
        
        private void InstallStatisticsManager()
        {
            Container
                .BindInterfacesAndSelfTo<StatisticsManager>()
                .AsSingle();
        }
    }
}