using System;
using TapSlotsTest.Managers;
using TapSlotsTest.Mechanics;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace TapSlotsTest.Screens.UI
{
    public class GameScreen : Screen
    {
        private const string HighScoreLabelText = "High score: {0}";
        private const string CurrentScoreLabelText = "Current score: {0}";
        
        [Inject] private StatisticsManager _statistics;
        
        [SerializeField] private TMP_Text _highScoreLabel;
        [SerializeField] private TMP_Text _currentScoreLabel;
        
        private void OnEnable()
        {
            UpdateHighScoreLabel();
            _statistics.ChangeHighScore += UpdateHighScoreLabel;
            _statistics.ChangeCurrentScore += UpdateCurrentScoreLabel;
        }

        private void OnDisable()
        {
            _statistics.ChangeHighScore -= UpdateHighScoreLabel;
            _statistics.ChangeCurrentScore -= UpdateCurrentScoreLabel;
        }

        public void StartMatch()
        {
            gameManager.OnMatchStarted();
        }

        public void ExitToMenu()
        {
            screenManager.Show<LevelExitWindow>();
        }
        
        private void UpdateHighScoreLabel()
        {
            _highScoreLabel.text = string.Format(HighScoreLabelText, _statistics.HighScore);
        }
        
        private void UpdateCurrentScoreLabel()
        {
            _currentScoreLabel.text = string.Format(CurrentScoreLabelText, _statistics.CurrentScore);
        }
    }
}