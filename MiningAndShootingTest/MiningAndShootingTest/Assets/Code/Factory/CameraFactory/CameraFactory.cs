using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class CameraFactory : ICameraFactory
    {
        private readonly DiContainer diContainer;
        private readonly CameraFactoryConfig config;
        
        public CameraFactory(DiContainer diContainer, CameraFactoryConfig config)
        {
            this.diContainer = diContainer;
            this.config = config;
        }
        
        public void Create()
        {
            FollowCamera camera = diContainer.InstantiatePrefabForComponent<FollowCamera>(
                config.followCameraPrefab,
                Vector3.zero, 
                Quaternion.identity,
                null);

            //diContainer.BindInstance(camera).AsSingle().IfNotBound();
            diContainer.Bind<FollowCamera>().FromInstance(camera).AsSingle();
        }
    }
}