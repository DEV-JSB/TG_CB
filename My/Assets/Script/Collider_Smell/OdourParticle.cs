using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JSB
{
    public class OdourParticle : MonoBehaviour
    {
        public float timespan;
        private float timer;

        private void Start()
        {
            if (timespan < 0f)
                timespan = 0f;
            timer = timespan;
        }



        private void Update()
        {
            timer -= Time.deltaTime;
            if (timer < 0f)
            {
                Debug.Log("ůů ������ ��������..!");
                Destroy(gameObject);
            }
        }

    }

}
