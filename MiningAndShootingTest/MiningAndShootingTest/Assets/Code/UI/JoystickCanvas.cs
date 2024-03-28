using UnityEngine;
using Zenject;

namespace MiningAndShooting
{
    public class JoystickCanvas : Canvas
    {
        [SerializeField]
        private Joystick joystick;
        
        [SerializeField]
        private float joystickSensitivity = 0.2f;

        private Player player;
        
        [Inject]
        private void Construct(Player player) => this.player = player;

        public override void Init()
        {
                
        }
        
        private void FixedUpdate()
        {
            float joystickMagnitude = joystick.Direction.magnitude;
            if (joystickMagnitude > joystickSensitivity)
            {
                player.Move(joystick.Direction);
            }
            else player.Stop();
        }
    }
}