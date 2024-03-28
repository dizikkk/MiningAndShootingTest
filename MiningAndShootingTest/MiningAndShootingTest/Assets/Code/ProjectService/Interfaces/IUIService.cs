using System;

namespace MiningAndShooting
{
    public interface IUIService
    {
        public event Action onPlayButtonPressed;
        public event Action onRestartButtonPressed;
        public event Action onExitButtonPressed;
        public event Action onPauseButtonPressed;

        public void HandleOnPlayButtonPressed();
        public void HandleOnRestartButtonPressed();
        public void HandleOnExitButtonPressed();
        public void HandleOnPauseButtonPressed();
    }
}