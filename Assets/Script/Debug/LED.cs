using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LED : MonoBehaviour
{
    private bool active = false;
    [SerializeField]
    private Material offColor;
    [SerializeField]
    private Material onColor;

    public void switchOnOff()
    {
        if (active)
        {
            GetComponent<MeshRenderer>().material = offColor;
            active = false;
        }
        else if (!active)
        {
            GetComponent<MeshRenderer>().material = onColor;
            active = true;
        }
    }
}
