using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class Spike : Observer
{
    GameObject spikeObj;
    int currentEvent = 0;

    int eventTriggerNumber = 1;

    public override void OnNotify()
    {
        currentEvent++;
        if(currentEvent == eventTriggerNumber)
            spikeObj.GetComponent<Rigidbody>().AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
    }

    public Spike(GameObject spikeObj, int eventTriggerNumber)
    {
        this.spikeObj = spikeObj;
        this.eventTriggerNumber = eventTriggerNumber;
    }
}