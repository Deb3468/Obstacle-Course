using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotators : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float x = 0.0f;
    [SerializeField] float y = 0.0f;
    [SerializeField] float z = 0.0f;

    void Update()
    {
       transform.Rotate(x , y , z); 
    }
}
