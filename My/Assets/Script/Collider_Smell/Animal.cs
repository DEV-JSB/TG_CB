using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField]
    private GameObject smellObj;
    private Vector3 currentTrans;
    // Update is called once per frame
    private void Start()
    {
        currentTrans = this.transform.position;

    }
    void Update()
    {

        if (currentTrans != this.transform.position)
        {
            Instantiate(smellObj, this.transform.position,Quaternion.identity);
            currentTrans = this.transform.position;
        }
    }
}
