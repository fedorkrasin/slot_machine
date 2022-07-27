using System;
using UnityEngine;
using Zenject;

namespace TapSlotsTest.Managers
{
    public class StatisticsManager : IInitializable
    {
        private int _highScore;
        private int _currentScore;

        public int HighScore => _highScore;
        public int CurrentScore => _currentScore;

        public event Action ChangeHighScore;
        public event Action ChangeCurrentScore;

        public void Initialize()
        {
            _highScore = PlayerPrefs.GetInt(nameof(_highScore), 0);
        }
        
        protected virtual void OnHighScoreChanged()
        {
            ChangeHighScore?.Invoke();
        }
        
        private void OnCurrentScoreChanged()
        {
            ChangeCurrentScore?.Invoke();
            CheckHighScore();
        }

        public void RecordPlayerVictory()
        {
            _currentScore++;
            OnCurrentScoreChanged();
        }
        
        public void RecordPlayerLoss()
        {
            _currentScore--;
            OnCurrentScoreChanged();
        }

        private void CheckHighScore()
        {
            if (_currentScore > _highScore)
            {
                UpdateHighScore();
                OnHighScoreChanged();
            }
        }

        private void UpdateHighScore()
        {
            _highScore = _currentScore;
            PlayerPrefs.SetInt(nameof(_highScore), _highScore);
        }

        public void ResetHighScore()
        {
            _highScore = 0;
            OnHighScoreChanged();
        }

        public void ResetCurrentScore()
        {
            _currentScore = 0;
            OnCurrentScoreChanged();
        }
    }
}