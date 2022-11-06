using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smeller : MonoBehaviour
{
    private Vector3 target;
    private Dictionary<int, GameObject> particles;

    private void Start()
    {
        particles = new Dictionary<int, GameObject>();
    }

    private void OnTriggerExit(Collider other)
    {

        GameObject obj = other.gameObject;
        int objId = obj.GetInstanceID();
        bool isRemoved;
        isRemoved = particles.Remove(objId);
        if (!isRemoved)
            return;
        //UpdateTarget();
    }

    private void UpdateTarget()
    {
        Vector3 centroid = Vector3.zero;
        foreach(GameObject p in particles.Values)
        {
            Vector3 pos = p.transform.position;
            centroid += pos;
        }
        target = centroid;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Å¯Å¯ ³¿»õ°¡³­´Ù");
       

        GameObject obj = other.gameObject;
        OdourParticle op;
        op = obj.GetComponent<OdourParticle>();
        if (op == null)
            return;
        int objId = obj.GetInstanceID();
        particles.Add(objId, obj);
        //UpdateTarget();
    }

    public Vector3? GetTargetPosition()
    {
        if (particles.Keys.Count == 0)
            return null;
        return target; 
    }

}
