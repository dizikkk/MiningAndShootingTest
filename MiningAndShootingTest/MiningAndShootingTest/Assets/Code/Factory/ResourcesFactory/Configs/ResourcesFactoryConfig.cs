using UnityEngine;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "ResourcesFactoryConfig", menuName = "Game/Factory/New ResourcesFactoryConfig", order = 0)]
    public class ResourcesFactoryConfig : ScriptableObject
    {
        public Coal coalPrefab;
    }
}