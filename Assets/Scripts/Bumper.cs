using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using Timer = System.Timers.Timer;

public class Bumper : MonoBehaviour
{


    [SerializeField] public UIScript uiSript;
    [SerializeField] public float BumperStrength = 5.0f;
    [SerializeField] public int PointsForHit = 10;

    [SerializeField] private AnimationCurve animationCurve;
    private Vector3 scaleMode;
    
    Rigidbody _rb;

    private float scalingTimer;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        scalingTimer = 1.0f;
        scaleMode = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Points")
        {
            Debug.LogWarning($"Ball Collided");
            
            scalingTimer = 0.0f;

        }
    }

    private void FixedUpdate()
    { 
        scalingTimer += Time.deltaTime;
        transform.localScale = new Vector3(animationCurve.Evaluate(scalingTimer) * scaleMode.x, scaleMode.y, animationCurve.Evaluate(scalingTimer) * scaleMode.z);
        
    }
}
