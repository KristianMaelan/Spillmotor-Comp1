using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
//Select in unity
    //Choosing the correct animation curve
    [SerializeField] private AnimationCurve animationCurveUp;
    [SerializeField] private AnimationCurve animationCurveDown;
    //Which bumper it is connected to
    [SerializeField] private int bumperNumber;
//Variables for use here
    private Rigidbody _rb;
    private float _timer = 1;
    private bool bumperUp = false;
    private float bumperResetTime = 0.35f;
    private Quaternion _startRot;

//When object is awake, calls this
    private void Awake()
    {
       
        //setting the variables when object wakes
        _rb = GetComponent<Rigidbody>();
        _startRot = transform.rotation;
        
    }

//Update is called every frame. 
    private void Update()
    {
        //Makes you unable to input anything until the animation is finished
        if (bumperUp == false)
        {  
            //Left bumper
            if (bumperNumber == 0)
            {
                
                if (_timer > bumperResetTime && Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    _timer = 0;
                    Debug.LogWarning($"Left Bumper pressed");
                    bumperUp = true;
                }
            }
            
            //Right bumper
            if (bumperNumber == 1)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    _timer = 0;
                    //inputTrue = true;
                    Debug.LogWarning($"Right Bumper pressed");
                    bumperUp = true;
                }
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            if (bumperNumber == 0)
            {
                
                if (_timer > 0.25)
                {
                    _timer = 0;
                }
                Debug.LogWarning($"Left Bumper released");
            bumperUp = false;
            }
        }
        
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            if (bumperNumber == 1)
            {
                
                if (_timer > 0.25)
                {
                    _timer = 0;
                }
                Debug.LogWarning($"Right Bumper released");
            bumperUp = false;
            }
        }


        _timer += Time.deltaTime;
    }

//Fixed update is called every physics update and not every frame. 
    private void FixedUpdate()
    {
        if (bumperUp)
        {
            _rb.MoveRotation(_startRot * Quaternion.Euler(0, 0, animationCurveUp.Evaluate(_timer) * 90f));
        }
        else if (!bumperUp )
        { 
            _rb.MoveRotation(_startRot * Quaternion.Euler(0, 0, animationCurveDown.Evaluate(_timer) * 90f));
        }
    }
    
    
    
};
