using UnityEngine;

public class CatapultSpring : MonoBehaviour
{
    [SerializeField] private SpringJoint _springJoint;
    
    public void SetSpring(float value)
    {
        _springJoint.spring = value;
    }
}