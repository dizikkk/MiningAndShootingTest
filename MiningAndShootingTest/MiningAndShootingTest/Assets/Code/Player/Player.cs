using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace MiningAndShooting
{
    public class Player : MonoBehaviour
    {
        private PlayerModel model;
        private PlayerMoveService moveService;
        private PlayerHealthService healthService;
        
        [Inject]
        private void Construct(PlayerModel model, PlayerMoveService moveService, PlayerHealthService healthService)
        {
            this.model = model;
            this.moveService = moveService;
            this.healthService = healthService;
        }

        public void Move(Vector2 direction) => moveService.Move(direction);

        public void Stop() => moveService.Stop();
        
        public Vector3 GetPosition() => model.GetRigidbody().transform.position;

        public void GetDamage()
        {
            healthService.GetDamage();
            CheckHealth();
        }
        
        private void CheckHealth()
        {
            if (!(healthService.GetHealthPoints() <= 0f)) return;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public float GetHealth() => healthService.GetHealthPoints();
    }
}
