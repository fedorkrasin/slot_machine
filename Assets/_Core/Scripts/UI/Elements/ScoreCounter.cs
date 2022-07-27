using System;
using DG.Tweening;
using TapSlotsTest.Managers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using Zenject.Asteroids;

namespace TapSlotsTest.UI.Elements
{
    public class ScoreCounter : MonoBehaviour
    {
        [Inject] private StatisticsManager _statistics;
        
        [SerializeField] private ScoreCounterPositions _scoreCounterPositions;
        [SerializeField] private RectTransform _firstDigitScroll;
        [SerializeField] private RectTransform _secondDigitScroll;

        private void OnEnable()
        {
            _firstDigitScroll.DOMoveY(_scoreCounterPositions.Zero, 1);
            // _secondDigitScroll.SetY(_scoreCounterPositions.Zero);
            _firstDigitScroll.position.Set(0, _scoreCounterPositions.Zero,0 );
        }
    }
}