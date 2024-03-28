using System;
using UnityEngine;

namespace MiningAndShooting
{
    public class PlayerMoveService
    {
        private PlayerModel model;
        private Settings settings;
        private Rigidbody2D rigidbody;
        
        public PlayerMoveService(PlayerModel model, Settings settings)
        {
            this.model = model;
            this.settings = settings;
            rigidbody = this.model.GetRigidbody();
        }
        
        public void Move(Vector2 direction)
        {
            rigidbody.transform.up = Vector3.RotateTowards(
                rigidbody.transform.up, direction, 50f * Time.fixedDeltaTime, 5f);
            rigidbody.velocity = new Vector3(direction.x, direction.y, 0f) * settings.speed;
        }

        public void Stop() => model.GetRigidbody().velocity = Vector3.zero;
        
        [Serializable]
        public class Settings
        {
            public float speed;
        }
    }
}