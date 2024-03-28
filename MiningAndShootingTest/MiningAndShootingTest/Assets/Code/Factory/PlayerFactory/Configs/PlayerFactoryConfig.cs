using UnityEngine;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "PlayerFactoryConfig", menuName = "Game/Factory/New PlayerFactoryConfig", order = 0)]
    public class PlayerFactoryConfig : ScriptableObject
    {
        public Player playerPrefab;
        public Vector3 spawnPosition;
    }
}