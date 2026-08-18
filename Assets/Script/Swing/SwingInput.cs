using UnityEngine;

public class SwingInput : MonoBehaviour
{
    private const KeyCode SwingKey = KeyCode.Space;
    
    public bool IsSwing {get; private set;}
    
    private void Update()
    {
        IsSwing = Input.GetKeyDown(SwingKey);
    }
}