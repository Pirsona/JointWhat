using System.Collections;
using UnityEngine;

public class CatapultController : MonoBehaviour
{
    
    [SerializeField] private CatapultInput _catapultInput;
    [SerializeField] private CatapultSpring _catapultSpring;
    [SerializeField] private ProjectileSpawner  _projectileSpawner;
    [SerializeField] private float _activeSpringForce;
    [SerializeField] private float _deactiveSpringForce;
    [SerializeField] private float _reloadDelay;
    
    private bool _isFired = false;
    private WaitForSeconds _wait;
    private Coroutine _projectileSpawnerCoroutine;
    
    private void Awake()
    {
        _wait = new WaitForSeconds(_reloadDelay);
    }

    private void Update()
    {
        if (_catapultInput.IsShootPressed && !_isFired)
        {
            _catapultSpring.SetSpring(_activeSpringForce);
            _isFired = true;
        }
        
        if (_catapultInput.IsReloading  && _isFired)
        {
           _projectileSpawnerCoroutine = StartCoroutine(ReloadCatapult());
        }
    }
    
    private IEnumerator ReloadCatapult()
    {
        _catapultSpring.SetSpring(_deactiveSpringForce);

        yield return _wait;
        _projectileSpawner.SpawnProjectile();
        _isFired = false;
    }
}