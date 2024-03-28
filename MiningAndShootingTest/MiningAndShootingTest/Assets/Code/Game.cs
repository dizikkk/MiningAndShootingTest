using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class Game : MonoBehaviour
    {
        private IGameFactory gameFactory;
        
        [Inject]
        public void Construct(IGameFactory gameFactory) => this.gameFactory = gameFactory;

        private void Start()
        {
            gameFactory.CreateGameplayEntities();
            gameFactory.CreateUI();
        }
    }
}