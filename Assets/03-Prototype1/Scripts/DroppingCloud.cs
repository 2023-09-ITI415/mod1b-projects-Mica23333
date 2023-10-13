using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroppingCloud : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Prefab for instantiating apples
    public GameObject DroppingPrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenDroppingDrops = 0.6f;



    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropDropping", 2f); // a
    }
    void DropDropping()
    {
        GameObject apple = Instantiate<GameObject>(DroppingPrefab); // c
        apple.transform.position = transform.position; // d
        Invoke("DropDropping", secondsBetweenDroppingDrops); // e
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position; // b
        pos.x += speed * Time.deltaTime; // c
        transform.position = pos; // d
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed); // Move right // b
        }
        else if (pos.x > leftAndRightEdge)
        { // c
            speed = -Mathf.Abs(speed); // Move left // c
        }
    }

    void FixedUpdate()
    {
            if (Random.value < chanceToChangeDirections)
                { // b
                    speed *= -1; // Change direction
                }
            }
        }


   
