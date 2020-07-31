using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLimit : MonoBehaviour
{
    [SerializeField]

    private GameObject buttonTrigger;

    private Vector3 originalPosition;

    private float mindistance;

    private float maxDistance;

    private Rigidbody rb;

    private void Awake()
    {
        // calculate the min distance between activator and the trigger
        mindistance = Vector3.Distance(buttonTrigger.transform.position, transform.position);

        maxDistance = buttonTrigger.transform.position.z;

        originalPosition = transform.position;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 localVelocity = transform.InverseTransformDirection(rb.velocity);
        localVelocity.x = 0;
        localVelocity.y = 0;

        rb.velocity = transform.TransformDirection(localVelocity);
    }
}
