using UnityEngine;

namespace MiningAndShooting
{
    [CreateAssetMenu(fileName = "CameraFactoryConfig", menuName = "Game/Factory/New CameraFactoryConfig", order = 0)]
    public class CameraFactoryConfig : ScriptableObject
    {
        public FollowCamera followCameraPrefab;
    }
}