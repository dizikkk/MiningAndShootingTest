using UnityEngine;

namespace MiningAndShooting
{
    public class PlayerModel
    {
        private readonly Rigidbody2D rigidbody;

        public PlayerModel(Rigidbody2D rigidbody)
        {
            this.rigidbody = rigidbody;
        }

        public Rigidbody2D GetRigidbody() => rigidbody;
    }
}