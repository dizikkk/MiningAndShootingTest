using ModestTree;
using UnityEngine;

namespace MiningAndShooting
{
    public class LevelBoundary
    {
        private Camera camera;

        public void SetFollowCamera(Camera camera)
        {
            this.camera = camera;
        }
        
        public float Bottom => -ExtentHeight;

        public float Top => ExtentHeight;

        public float Left => -ExtentWidth;

        public float Right => ExtentWidth;

        public float ExtentHeight => camera.orthographicSize;

        public float Height => ExtentHeight * 2.0f;

        public float ExtentWidth => camera.aspect * camera.orthographicSize;

        public float Width => ExtentWidth * 2.0f;
        
        public Vector3 ChooseRandomStartPosition()
        {
            var side = Random.Range(0, 3);
            var posOnSide = Random.Range(0, 1.0f);

            float buffer = 2.0f;

            switch (side)
            {
                case 0:
                {
                    return new Vector3(
                        Left + posOnSide * Width,
                        Top + buffer, 0);
                }
                case 1:
                {
                    return new Vector3(
                        Right + buffer,
                        Top - posOnSide * Height, 0);
                }
                case 2:
                {
                    return new Vector3(
                        Left + posOnSide * Width,
                        Bottom - buffer, 0);
                }
                case 3:
                {
                    return new Vector3(
                        Left - buffer,
                        Top - posOnSide * Height, 0);
                }
            }
            throw Assert.CreateException();
        }
    }
}