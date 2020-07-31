using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class SimulateButton : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnButtonPressed;

    [SerializeField]
    private bool pressedInProgress = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            if (!pressedInProgress)
            {
                pressedInProgress = true;
                OnButtonPressed?.Invoke();
            }
        }
    }

    public void ButtonReturn()
    {
        pressedInProgress = false;
    }
}
