using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class ExitGameService : MonoBehaviour, IExitGameService
    {
        private IUIService uiService;
        
        [Inject]
        private void Construct(IUIService uiService) => this.uiService = uiService;

        public void Exit()
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
            
            Application.Quit();
        }

        public void Initialize() => uiService.onExitButtonPressed += Exit;

        private void OnDestroy() => uiService.onExitButtonPressed -= Exit;
    }
}