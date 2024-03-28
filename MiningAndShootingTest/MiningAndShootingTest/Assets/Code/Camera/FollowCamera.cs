using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class FollowCamera : MonoBehaviour
    {
        [SerializeField]
        private new Camera camera;
        
        private Player player;
        private LevelBoundary levelBoundary;

        [Inject]
        private void Construct(Player player, LevelBoundary levelBoundary)
        {
            this.player = player;
            this.levelBoundary = levelBoundary;
            this.levelBoundary.SetFollowCamera(camera);
        }

        private void Update()
        {
            transform.position = new Vector3(player.GetPosition().x, player.GetPosition().y, -10f);
        }
    }
}