using System;
using TapSlotsTest.Managers;
using TapSlotsTest.Mechanics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Zenject;

namespace TapSlotsTest.UI.Elements
{
    public class ShapeSelectionButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [Inject] private GameManager _gameManager;
        
        [SerializeField] private GameShapes _shape;

        public void OnPointerEnter(PointerEventData eventData)
        {
            _gameManager.SelectPlayerShape(_shape);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            // Debug.Log("stop animation");
        }
    }
}