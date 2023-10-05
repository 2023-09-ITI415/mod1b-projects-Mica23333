using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject launchPoint;
    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint"); 
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false); 
    }

    void OnMouseEnter()
    {
        //print("Shot:OnMouseEnter()");//
        launchPoint.SetActive(true);
    }
    void OnMouseExit()
    {
        //print("Shot:OnMouseExit()");//
        launchPoint.SetActive(false);
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
