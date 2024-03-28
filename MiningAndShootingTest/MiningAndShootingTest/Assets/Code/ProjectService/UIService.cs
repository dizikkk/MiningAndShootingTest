using System;
using UnityEngine;

namespace MiningAndShooting
{
    public class UIService : MonoBehaviour, IUIService
    {
        public event Action onPlayButtonPressed;
        public event Action onRestartButtonPressed;
        public event Action onExitButtonPressed;
        public event Action onPauseButtonPressed;
        
        public void HandleOnPlayButtonPressed() => onPlayButtonPressed?.Invoke();

        public void HandleOnRestartButtonPressed() => onRestartButtonPressed?.Invoke();

        public void HandleOnExitButtonPressed() => onExitButtonPressed?.Invoke();
        public void HandleOnPauseButtonPressed() => onPauseButtonPressed?.Invoke();
    }
}