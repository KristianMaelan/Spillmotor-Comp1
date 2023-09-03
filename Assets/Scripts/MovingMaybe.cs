using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMaybe : MonoBehaviour
{
    [SerializeField] public float xVal;
    [SerializeField] public float yVal;
    [SerializeField] public float zVal;
    [SerializeField] float SpeedVal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        xVal = Input.GetAxis("Horizontal") * SpeedVal  * Time.deltaTime;
        yVal = Input.GetAxis("Vertical") * SpeedVal * Time.deltaTime;
        transform.Translate(xVal, yVal, zVal);


    }
}
