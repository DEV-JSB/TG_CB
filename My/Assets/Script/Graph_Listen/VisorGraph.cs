using JSB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisorGraph : MonoBehaviour
{
    public int visionReach;
    public GameObject visorObj;
    [SerializeField]
    public Graph visionGraph;
    [SerializeField]
    private List<GameObject> objList = new List<GameObject>();


    List<Vector3> correctionVertexes = new List<Vector3>();
    List<Vector3> correctionVertexes2 = new List<Vector3>();

    private void Start()
    {
        if (visionGraph == null)
            visorObj = gameObject;
    }

    private void OnDrawGizmos()
    {
        foreach(GameObject obj in objList)
        {
            if (null == obj.GetComponent<VisorGraph>())
                continue;
            List<Vector3> otherVertexes = obj.GetComponent<VisorGraph>().visionGraph.Vectors;
            List<Vector3> myVertexes = visionGraph.Vectors;
            
            foreach (Vector3 vec in myVertexes)
            {
                correctionVertexes.Add(vec + this.transform.position);
            }
            foreach (Vector3 vec in otherVertexes)
            {
                correctionVertexes2.Add(vec + obj.transform.position);
            }
            foreach (Vector3 vec in correctionVertexes)
            {
                foreach(Vector3 otherVec in correctionVertexes2)
                {
                    /*Physics.Raycast(vec,otherVec,out hitInfo);
                    if (hitInfo.collider.tag == "obstacle")
                    {
                        Gizmos.color = Color.red;
                    }
                    else
                        Gizmos.color = Color.white;*/
                    Vector3 dir = (otherVec - vec).normalized;
                    float distance = Vector3.Distance(vec, otherVec);
                    Gizmos.DrawRay(vec, dir* distance);
                }
            }
            correctionVertexes.Clear();
            correctionVertexes2.Clear();
        }
    }
    public bool IsVisible(int[] visibiltiyNodes)
    {
        int vision = visionReach;
        //int src = visionGraph.GetNearestVertex();
        HashSet<int> visibleNodes = new HashSet<int>();
        Queue<int> queue = new Queue<int>();
        //queue.Enqueue(src);
        return false;
    }


    private void Update()
    {
        
    }

}
