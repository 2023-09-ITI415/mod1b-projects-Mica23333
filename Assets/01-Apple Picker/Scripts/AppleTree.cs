using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]

    // Prefab for instantiating apples
    public GameObject applePrefab;

    // Speed at which the AppleTree moves
    public float speed = 10f;

    // Distance where AppleTree turns around
    public float leftAndRightEdge = 20f;

    // Chance that the AppleTree will change directions
    public float chanceToChangeDirection = 0.1f;

    // Rate at which Apples will be instantiated
    public float secondsBetweenAppleDrop = 1f;


    void Start()
    // Dropping apples every second
    {
        InvokeRepeating("DropApple", 2f, secondsBetweenAppleDrop);
    }
    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }



    // Update is called once per frame
    void Update()
    {
        // Basic Movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // Changing Direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left
        }
    }
    void FixedUpdate()
    {
        // Changing Direction Randomly
        if (Random.value < chanceToChangeDirection)
        {
            speed *= -1; // Change direction
        }
    }
}
    
 

