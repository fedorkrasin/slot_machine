using System;
using TapSlotsTest.Managers;
using TMPro;
using UnityEngine;
using Zenject;

namespace TapSlotsTest.Screens.UI
{
    public class MenuScreen : Screen
    {
        private const string HighScoreLabelText = "High score: {0}";
        
        [Inject] private StatisticsManager _statistics;
        
        [SerializeField] private TMP_Text _bestScoreLabel;

        private void OnEnable()
        {
            UpdateHighScoreLabel();
        }

        private void Start()
        {
            UpdateHighScoreLabel();
        }

        public void StartGame()
        {
            screenManager.Show<GameScreen>();
            screenManager.Hide(this);
        }

        private void UpdateHighScoreLabel()
        {
            _bestScoreLabel.text = string.Format(HighScoreLabelText, _statistics.HighScore);
        }
    }
}