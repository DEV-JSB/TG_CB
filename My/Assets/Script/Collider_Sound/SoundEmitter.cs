using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEmitter : MonoBehaviour
{
    public float soundIntensity;
    public float soundAttenuation;
    public GameObject emitterObject;
    private Dictionary<int, SoundReceiver> receiverDic;

    private void Start()
    {
        receiverDic = new Dictionary<int, SoundReceiver>();
        if (emitterObject == null)
            emitterObject = gameObject;
    }

    public void OnTriggerEnter(Collider other)
    {
        SoundReceiver receiver;
        receiver = other.gameObject.GetComponent<SoundReceiver>();
        if (receiver == null)
            return;
        int objId = other.gameObject.GetInstanceID();
        receiverDic.Add(objId, receiver);
    }

    private void Update()
    {
        Emit();
    }

    public void Emit()
    {
        Debug.Log("소리 발산중");
        GameObject srObj;
        Vector3 srPos;
        float intensity;
        float distance;
        Vector3 emitterPos = emitterObject.transform.position;

        foreach(SoundReceiver sr in receiverDic.Values)
        {
            srObj = sr.gameObject;
            srPos = srObj.transform.position;
            distance = Vector3.Distance(srPos, emitterPos);
            intensity = soundIntensity;
            intensity -= soundAttenuation * distance;
            if (intensity < sr.soundThreshold)
                continue;
            sr.Receive(intensity, emitterPos);
        }

    }


}
