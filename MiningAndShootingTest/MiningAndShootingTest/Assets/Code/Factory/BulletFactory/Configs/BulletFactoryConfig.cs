using UnityEngine;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "BulletFactoryConfig", menuName = "Game/Factory/New BulletFactoryConfig", order = 0)]
    public class BulletFactoryConfig : ScriptableObject
    {
        public Bullet bulletPrefab;
    }
}