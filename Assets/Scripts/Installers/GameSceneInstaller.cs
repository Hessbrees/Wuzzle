using UnityEngine;
using Zenject;

public class GameSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<GridCellsContainer>().FromComponentInHierarchy().AsSingle().NonLazy();
        Container.Bind<GridItemsContainer>().FromComponentInHierarchy().AsSingle().NonLazy();
    }
}