using UnityEngine;

public class SwingController : MonoBehaviour
{ 
    [SerializeField] private SwingPusher _swingPusher;
    [SerializeField] private SwingInput _swingInput;
    
    private void Update()
    {
        if (_swingInput.IsSwing)
        {
            _swingPusher.Push();
        }
    }
}