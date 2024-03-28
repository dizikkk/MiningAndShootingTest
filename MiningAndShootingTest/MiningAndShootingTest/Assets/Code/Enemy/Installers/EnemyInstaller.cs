using System;
using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class EnemyInstaller : MonoInstaller
    {
        [SerializeField]
        private Settings settings;
        
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<EnemyMoveService>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyHealthService>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyAttackService>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyAttackTargetService>().AsSingle();
            Container.BindInterfacesAndSelfTo<EnemyModel>().AsSingle().WithArguments(settings.rigidbody, settings.navMeshAgent);
        }
        
        [Serializable]
        public class Settings
        {
            [Header("Enemy Model")] 
            public Rigidbody2D rigidbody;

            public NavMeshAgent2D navMeshAgent;
        }
    }
}