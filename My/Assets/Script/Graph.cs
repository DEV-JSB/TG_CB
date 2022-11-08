using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace JSB
{
    public class Graph : MonoBehaviour
    {
        [SerializeField]
        protected List<Vector3> vectors;
        public List<Vector3> Vectors { get { return vectors; } }

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

    }

}
