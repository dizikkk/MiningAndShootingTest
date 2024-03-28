using System;
using TMPro;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class GameScreen : Screen
    {
        [SerializeField]
        private TextMeshProUGUI playerHealthText;
        
        private Player player;

        private float startedPlayerHealth;
        
        [Inject]
        public void Construct(Player player) => this.player = player;
        
        public override void Init() => startedPlayerHealth = player.GetHealth();

        private void Update() => playerHealthText.text = $"Player Health: {player.GetHealth()}/{startedPlayerHealth}";

        public override void Hide() => gameObject.SetActive(false);
    }
}