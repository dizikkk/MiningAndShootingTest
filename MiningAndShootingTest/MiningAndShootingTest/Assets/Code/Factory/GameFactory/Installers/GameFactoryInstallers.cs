﻿using Zenject;

namespace MiningAndShooting
{
    public class GameFactoryInstallers : MonoInstaller
    {
        public override void InstallBindings() => BindGameFactory();

        private void BindGameFactory() => Container.Bind<IGameFactory>().To<GameFactory>().AsSingle();

    }
}