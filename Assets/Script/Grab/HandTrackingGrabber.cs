using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandTrackingGrabber : OVRGrabber
{
    private OVRHand m_hand;
    public float pinchTreshold = 0.7f;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        m_hand = GetComponent<OVRHand>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CheckIndexPinch();
    }

    void CheckIndexPinch()
    {
        float pinchStrenght = m_hand.GetFingerPinchStrength(OVRHand.HandFinger.Index);
        if (!m_grabbedObj && pinchStrenght > pinchTreshold && m_grabCandidates.Count > 0)
            GrabBegin();
        else if (m_grabbedObj && ! (pinchStrenght > pinchTreshold))
            GrabEnd();
    }

}
