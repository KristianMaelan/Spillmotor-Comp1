using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //[SerializeField] public GameObject gameq;
    public MovingMaybe bruh;
       float xVal;
       float yVal;
    float zVal;
    // Start is called before the first frame update
    void Start()
    {
        zVal -= 10;
    }

    // Update is called once per frame
    void Update()
    {
        xVal = bruh.xVal;
        yVal = bruh.yVal;
        // zVal = bruh.zVal;



        transform.Translate(xVal, yVal, 0);
        
    }
}
