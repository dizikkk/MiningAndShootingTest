using Zenject;

namespace MiningAndShooting
{
    public class CoalBlock : Block
    {
        private IResourcesFactory resourcesFactory;
        
        [Inject]
        private void Construct(IResourcesFactory resourcesFactory) => 
            this.resourcesFactory = resourcesFactory;

        public override void CheckHealth()
        {
            if (health <= 0f)
            {
                Coal coal = resourcesFactory.CreateCoal();
                coal.transform.position = transform.position;
                Destroy(gameObject);
            }
        }
    }
}