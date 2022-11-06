/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterGraph : MonoBehaviour
{
    public int visionReach;
    public Graph visionGraph;
    public GameObject visorObj;

    private void Start()
    {
        if (visorObj == null)
            visorObj = gameObject;
    }

    public bool IsVisible(int[]visiblityNodes)
    {
        int vision = visionReach;
        int src = visionGraph.GetNearestVertex(visorObj);
        HashSet<int> visibleNodes = new HashSet<int>();

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(src);

        while(queue.Count != 0)
        {
            if (vision == 0)
                break;
            int v = queue.Dequeue();
            List<int> neighbours = visionGraph.GetNeighbours(v);
            foreach(int n in neighbours)
            {
                if(visibleNodes.Contains(n))
                {
                    continue;
                }
                queue.Enqueue(v);
                visibleNodes.Add(v);
            }
        }
        foreach(int vn in visibleNodes)
        {
            if (visibleNodes.Contains(vn))
                return true;
        }
        return false;
    }

}
*/