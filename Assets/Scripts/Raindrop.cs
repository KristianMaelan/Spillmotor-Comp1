using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrop : MonoBehaviour
{
public float xPosition;
public float yPosition;
public float zPosition;
[SerializeField] float dropMass = 200;
[SerializeField] float RandomRangeMinus = -8.0f;
[SerializeField] float RandomRangeplus = 8.0f;
private Vector3 position;
Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        xPosition =   Random.Range(RandomRangeMinus, RandomRangeMinus);
        yPosition = Random.Range(RandomRangeMinus, RandomRangeplus);
        
              




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
