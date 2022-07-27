using System;
using TapSlotsTest.Managers;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace TapSlotsTest.Mechanics.Hands
{
    public abstract class Hand : MonoBehaviour
    {
        [Inject] protected GameManager gameManager;

        [SerializeField] protected Image _image;
        [SerializeField] protected Sprite _rockSprite;
        [SerializeField] protected Sprite _paperSprite;
        [SerializeField] protected Sprite _scissorsSprite;
    }
}