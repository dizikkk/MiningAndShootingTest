using System;

namespace MiningAndShooting
{
    public class PlayerHealthService
    {
        private Settings settings;
        
        private float healthPoints;
        
        public PlayerHealthService(Settings settings)
        {
            this.settings = settings;
            healthPoints = this.settings.healthPoints;
        }

        public void GetDamage() => healthPoints--;

        public float GetHealthPoints() => healthPoints;
        
        [Serializable]
        public class Settings
        {
            public float healthPoints;
        }
    }
}