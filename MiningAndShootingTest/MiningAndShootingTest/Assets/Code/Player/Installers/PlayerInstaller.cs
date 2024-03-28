using System;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField]
        private Settings settings;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<PlayerInputService>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerMoveService>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerShootService>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyCollectorService>().AsSingle();
            Container.BindInterfacesAndSelfTo<BlockCollectorService>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerHealthService>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerMineService>().AsSingle();
            Container.BindInterfacesAndSelfTo<PlayerModel>().AsSingle().WithArguments(settings.rigidbody);
        }

        [Serializable]
        public class Settings
        {
            [Header("Player Model")] 
            public Rigidbody2D rigidbody;
        }
    }
}