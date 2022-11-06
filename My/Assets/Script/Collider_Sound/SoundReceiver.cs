using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundReceiver : MonoBehaviour
{

    public float soundThreshold;

    public virtual void Receive(float intensity, Vector3 position)
    {
        Debug.Log(this.name + "�ƾ� ���� " + intensity.ToString() + "��ŭ ��� �־��");
    }
}
