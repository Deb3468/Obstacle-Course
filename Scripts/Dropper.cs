using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int setTimer = 3;
    private MeshRenderer render;
    private Rigidbody physicsBody;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        physicsBody = GetComponent<Rigidbody>();

        render.enabled = false;
        physicsBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > setTimer){
            Debug.Log(setTimer.ToString() +" seconds Timer has elapsed");
            render.enabled = true;
            physicsBody.useGravity = true;
        }
    }
}
