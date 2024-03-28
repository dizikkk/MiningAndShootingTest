using UnityEngine;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "ToolsFactoryConfig", menuName = "Game/Factory/New ToolsFactoryConfig", order = 0)]
    public class ToolsFactoryConfig : ScriptableObject
    {
        public Pickaxe pickaxePrefab;
    }
}