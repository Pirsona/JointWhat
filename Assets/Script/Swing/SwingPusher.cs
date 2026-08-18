using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SwingPusher : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private Vector3 _direction = Vector3.forward;
    
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    
    public void Push()
    {
        Vector3 worldDirection = transform.TransformDirection(_direction.normalized);
        _rigidbody.AddForce(worldDirection * _force, ForceMode.Impulse);
    }
}