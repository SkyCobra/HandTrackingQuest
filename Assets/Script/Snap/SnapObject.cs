using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SnapObject : MonoBehaviour
{
    [SerializeField]
    private UnityEvent OnSnap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SnapZone"))
        {
            Debug.Log("coucou ? ");
            transform.position = other.transform.position;
            transform.rotation = other.transform.rotation;
            GetComponent<GrabbableObject>().GrabEnd(Vector3.zero, Vector3.zero);
            OnSnap?.Invoke();
        }
    }

    //private void OnTriggerExit(Collider other)
    //{

    //}
}
