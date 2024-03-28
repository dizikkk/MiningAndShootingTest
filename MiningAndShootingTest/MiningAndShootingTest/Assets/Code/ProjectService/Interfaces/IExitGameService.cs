using Zenject;

namespace MiningAndShooting
{
    public interface IExitGameService : IInitializable
    {
        public void Exit();
    }
}