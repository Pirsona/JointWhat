using UnityEngine;

public class CatapultInput : MonoBehaviour
{
    private const KeyCode ShootKey = KeyCode.Space;
    private const KeyCode ReloadKey = KeyCode.R;
    
    public bool IsShootPressed {get; private set;}
    public bool IsReloading {get; private set;}
    
    private void Update()
    {
        IsShootPressed = Input.GetKeyDown(ShootKey);
        IsReloading = Input.GetKeyDown(ReloadKey);
    }
}