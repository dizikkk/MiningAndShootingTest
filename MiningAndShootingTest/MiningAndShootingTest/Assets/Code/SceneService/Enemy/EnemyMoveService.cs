using System;
using UnityEngine;

namespace MiningAndShooting
{
    public class EnemyMoveService
    {
        private EnemyModel model;
        private Settings settings;
        private Rigidbody2D rigidbody;
        private NavMeshAgent2D NavMeshAgent;
        
        public EnemyMoveService(EnemyModel model, Settings settings)
        {
            this.model = model;
            this.settings = settings;
            rigidbody = this.model.GetRigidbody();
            NavMeshAgent = this.model.GetNavMeshAgent();
        }
        
        public void Move(Vector3 playerPosition)
        {
            NavMeshAgent.destination = playerPosition;
        }
        
        [Serializable]
        public class Settings
        {
            public float speed;
        }
    }
}