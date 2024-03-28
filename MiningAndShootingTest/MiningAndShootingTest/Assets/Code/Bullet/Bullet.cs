using UnityEngine;

namespace MiningAndShooting
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] 
        private float speed;
        
        private void Update()
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out Enemy enemy))
            {
                enemy.GetDamage();
                Destroy(gameObject);
            }
        }
    }
}