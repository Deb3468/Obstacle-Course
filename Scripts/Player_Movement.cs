using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float movementSpeed = 0.0f;
    void Start()
    {
        printIntroduction();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime;
        transform.Translate(xValue * movementSpeed , 0, zValue * movementSpeed);
    }

    void printIntroduction()
    {
        Debug.Log("-> You have to dodge the obstacles and reach the end");
        Debug.Log("-> Use WASD or arrows to move");
        Debug.Log("-> Good luck");
    }
}
