using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    protected List<Vector3> vectors;
    public List<Vector3> Vectors{ get { return vectors; } }
    public virtual void Start()
    {
        Load();
    }
    public virtual void Load() { }

    public virtual int GetSize()
    {
        if (ReferenceEquals(vectors, null))
            return 0;
        return vectors.Count;
    }
    // 주어진 점에서 가장 가까운 지점을 구하기 위한 함수를 정의한다..
    public virtual Vertex GetNearestVertex(Vector3 position)
    {
        return null;
    }
    public virtual List<Vector3> GetNeighbours(Vector3 v)
    {
        return null;
    }

}
