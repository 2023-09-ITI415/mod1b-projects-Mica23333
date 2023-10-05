using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject LaunchPoint;
    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint"); 
        LaunchPoint = launchPointTrans.gameObject;
        LaunchPoint.SetActive(false); 
    }

    void OnMouseEnter()
    {
        //print("Shot:OnMouseEnter()");//
        LaunchPoint.SetActive(true);
    }
    void OnMouseExit()
    {
        //print("Shot:OnMouseExit()");//
        LaunchPoint.SetActive(false);
    }
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
