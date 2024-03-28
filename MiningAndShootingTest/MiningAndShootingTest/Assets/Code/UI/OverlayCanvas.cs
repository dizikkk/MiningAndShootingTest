using System.Linq;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class OverlayCanvas : Canvas
    {
        [SerializeField]
        private Screen[] screens;

        private Screen currentScreen;

        public override void Init()
        {
            ShowScreen<GameScreen>();
        }

        private void ShowScreen<T>() where T : Screen
        {
            TryHideCurrentScreen();
            Screen screen = screens.First(x => x is T);
            if (screen == null) return;
            currentScreen = screen;
            screen.gameObject.SetActive(true);
            screen.Init();
        }

        private void TryHideCurrentScreen()
        {
            if (currentScreen == null) return;
            currentScreen.Hide();
        }
    }
}