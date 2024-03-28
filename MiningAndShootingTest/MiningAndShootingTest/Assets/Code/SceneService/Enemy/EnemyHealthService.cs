using System;

namespace MiningAndShooting
{
    public class EnemyHealthService
    {
        private Settings settings;
        
        private float healthPoints;
        
        public EnemyHealthService(Settings settings)
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