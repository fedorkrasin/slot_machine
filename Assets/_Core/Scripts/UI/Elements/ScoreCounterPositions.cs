using UnityEngine;

namespace TapSlotsTest.UI.Elements
{
    [CreateAssetMenu(fileName = "ScrollCounterPositions", menuName = "ScriptableObjects/ScrollCounterPositions")]
    public class ScoreCounterPositions : ScriptableObject
    {
        [SerializeField] private float _zero;
        [SerializeField] private float _one;
        [SerializeField] private float _two;
        [SerializeField] private float _three;
        [SerializeField] private float _four;
        [SerializeField] private float _five;
        [SerializeField] private float _six;
        [SerializeField] private float _seven;
        [SerializeField] private float _eight;
        [SerializeField] private float _nine;
        
        public float Zero => _zero;
        public float One => _one;
        public float Two => _two;
        public float Three => _three;
        public float Four => _four;
        public float Five => _five;
        public float Six => _six;
        public float Seven => _seven;
        public float Eight => _eight;
        public float Nine => _nine;
    }
}