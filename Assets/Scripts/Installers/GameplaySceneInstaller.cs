using Scripts;
using UnityEngine;
using Zenject;

public class GameplaySceneInstaller : MonoInstaller
{
    [SerializeField] private Player _playerPrefab;
    [SerializeField] private Transform _playerSpawnPoint;
    [SerializeField] private PlayerConfig _playerConfig;

    public override void InstallBindings()
    {
        BindPlayer();
        BindMovementService();
    }

    private void BindMovementService()
    {
        Container.BindInterfacesAndSelfTo<MovementHandler>().AsSingle().NonLazy();
    }

    private void BindPlayer()
    {
        Container.Bind<PlayerConfig>().FromInstance(_playerConfig).AsSingle();
        Player player = Container.InstantiatePrefabForComponent<Player>(_playerPrefab, _playerSpawnPoint.position, Quaternion.identity, null);
        Container.BindInterfacesAndSelfTo<Player>().FromInstance(player).AsSingle();
    }
}