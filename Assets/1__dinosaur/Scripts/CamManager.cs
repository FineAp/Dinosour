using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public Transform player;
    
    private Transform camTrans;
    public Vector3 camOffSet = new Vector3(0f,0f,0f);
    void Start()
    {
        camTrans = transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        camTrans.position = player.position + camOffSet;
        
    }
}
