using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Edge
{
    public float cost;
    public Vertex vertex;

    public Edge(Vertex vertex = null,float cost = 1f)
    {
        this.vertex = vertex;
        this.cost = cost;
    }
    public int CompareTo(Edge other)
    {
        float resault = cost - other.cost;
        int idA = vertex.GetInstanceID();
        int IdB = other.vertex.GetInstanceID();
        if (idA == IdB)
            return 0;
        return (int)resault;
    }
    public bool Eqals(Edge other)
    {
        return (other.vertex.id == this.vertex.id);
    }
    public override bool Equals(object obj)
    {
        Edge other = (Edge)obj;
        return (other.vertex.id == this.vertex.id);
    }
    public override int GetHashCode()
    {
        return this.vertex.GetHashCode();
    }
}
