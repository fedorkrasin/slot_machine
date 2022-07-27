using TapSlotsTest.Managers;
using UnityEngine;
using Zenject;

namespace TapSlotsTest.Screens.UI
{
    public abstract class Screen : MonoBehaviour
    {
        [Inject] protected GameManager gameManager;
        [Inject] protected ScreenManager screenManager;
        
        public virtual void Show() => gameObject.SetActive(true);
        public virtual void Hide() => gameObject.SetActive(false);

        public virtual bool IsActive() => gameObject.activeSelf;
    }
}