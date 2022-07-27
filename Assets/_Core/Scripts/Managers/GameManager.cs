using System;
using TapSlotsTest.Mechanics;
using TapSlotsTest.Util;
using UnityEngine;
using Zenject;

namespace TapSlotsTest.Managers
{
    public class GameManager
    {
        [Inject] private StatisticsManager _statistics;
        
        private GameShapes _playerShape;
        private GameShapes _enemyShape;

        public GameShapes PlayerShape => _playerShape;

        public event Action StartMatch;
        public event Action SelectShape;
        
        public void OnMatchStarted()
        {
            StartMatch?.Invoke();
            DetectWinner();
        }

        private void OnShapeSelected()
        {
            SelectShape?.Invoke();
        }

        public void SelectPlayerShape(GameShapes shape)
        {
            _playerShape = shape;
            OnShapeSelected();
        }

        public void SelectEnemyShape(GameShapes shape)
        {
            _enemyShape = shape;
        }

        private void DetectWinner()
        {
            if (RockPaperScissors.IsDraft(_playerShape, _enemyShape))
            {
                Debug.Log("DRAFT");
            }
            else
            {
                if (RockPaperScissors.IsFirstShapeWinner(_playerShape, _enemyShape)) _statistics.RecordPlayerVictory();
                else _statistics.RecordPlayerLoss();
            }
        }

        public void ExitToMenu()
        {
            _statistics.ResetCurrentScore();
        }
    }
}