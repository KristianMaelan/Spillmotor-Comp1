using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Raindrop : MonoBehaviour
{
public float xPosition;
public float yPosition;
public float zPosition;
//[SerializeField] float dropMass = 200;
//[SerializeField] float RandomRangeMinus = -8.0f;
//[SerializeField] float RandomRangeplus = 8.0f;
private Vector3 position;
Rigidbody rb;
[SerializeField] private float bounceForce;
[SerializeField] public UIScript uiSript;

[SerializeField] public int pointsForHit = 10;


public int ScoreCounter;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //xPosition =   Random.Range(RandomRangeMinus, RandomRangeMinus);
        //yPosition = Random.Range(RandomRangeMinus, RandomRangeplus);

        ScoreCounter = 0;

    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Points")
        {
        Debug.LogWarning($"Ball Collided");
        Vector3 bounceDir = collision.GetContact(0).normal;

        bounceForce = collision.gameObject.GetComponent<Bumper>().BumperStrength;
        
        
        rb.AddForce(bounceDir * bounceForce, ForceMode.Impulse);
        uiSript.Score += pointsForHit;  
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y <= -15.0f )
        {
            
             this.transform.position.Set(this.transform.position.x, 45.0f,this.transform.position.z);

        }
    }
}
