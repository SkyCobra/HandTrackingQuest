using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class PhysicButton : MonoBehaviour
{
    public Rigidbody upPosition;
    public Rigidbody pressedPosition;
    public ConfigurableJoint joint;

    [SerializeField]
    private UnityEvent onButtonPressed;
    [SerializeField]
    private bool stayPressed = false;
    private bool isActive = false;

    private void OnCollisionEnter(Collision collision)
    {
        onButtonPressed?.Invoke();
        if (stayPressed && !isActive)
        {
            joint.connectedBody = pressedPosition;
            isActive = true;
        }
        else if (stayPressed && isActive)
        {
            joint.connectedBody = upPosition;
            isActive = false;
        }
    }
}
