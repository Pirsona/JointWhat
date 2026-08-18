using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _projectileSpawnPoint;
    
    public void SpawnProjectile()
    {
        Instantiate(_projectile, _projectileSpawnPoint.position, _projectile.transform.rotation);
    }
}
