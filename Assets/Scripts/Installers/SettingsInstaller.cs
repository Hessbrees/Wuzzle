using UnityEngine;
using Zenject;
using Zenject.Asteroids;

[CreateAssetMenu(fileName = "SettingsInstaller", menuName = "Installers/SettingsInstaller")]
public class SettingsInstaller : ScriptableObjectInstaller<SettingsInstaller>
{
    [SerializeField] private GameSettings gameSettings;

    public override void InstallBindings()
    {
        Container.BindInstance(gameSettings).AsSingle().NonLazy();
    }
}