using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace MiningAndShooting
{
    public class PauseScreen : Screen
    {
        [SerializeField]
        private Button playButton;
        
        [SerializeField]
        private Button restartButton;
        
        [SerializeField]
        private Button exitButton;

        private IUIService uiService;
        
        [Inject]
        public void Construct(IUIService uiService) => this.uiService = uiService;

        public override void Init()
        {
            SubscribeButtons();
        }

        public override void Hide()
        {
            UnsubscribeButtons();
            gameObject.SetActive(false);
        }

        private void SubscribeButtons()
        {
            playButton.onClick.AddListener(uiService.HandleOnPlayButtonPressed);
            restartButton.onClick.AddListener(uiService.HandleOnRestartButtonPressed);
            exitButton.onClick.AddListener(uiService.HandleOnExitButtonPressed);
        }
        
        private void UnsubscribeButtons()
        {
            playButton.onClick.RemoveAllListeners();
            restartButton.onClick.RemoveAllListeners();
            exitButton.onClick.RemoveAllListeners();
        }
    }
}