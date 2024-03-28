using UnityEngine;

namespace MiningAndShooting
{
    public class Block : MonoBehaviour
    {
        [SerializeField]
        private protected float health;

        public void GetDamage()
        {
            health--;
            CheckHealth();
        }

        public virtual void CheckHealth()
        {
            if (health <= 0f) Destroy(gameObject);
        }
    }
}