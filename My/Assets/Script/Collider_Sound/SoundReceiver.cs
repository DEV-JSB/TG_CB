using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundReceiver : MonoBehaviour
{

    public float soundThreshold;

    public virtual void Receive(float intensity, Vector3 position)
    {
        Debug.Log(this.name + "아아 나는 " + intensity.ToString() + "만큼 듣고 있어요");
    }
}
