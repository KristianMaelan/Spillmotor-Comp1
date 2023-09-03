using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainCloud : MonoBehaviour
{
    [SerializeField] private GameObject RaindropPF;
    [SerializeField] private Vector2 SpawnSize = Vector2.one * 10;


     void SpawnRainDrop()
     {
        GameObject rainDropGameObject = Instantiate(RaindropPF, GetRandomPos(), Quaternion.identity);
        

        Destroy(rainDropGameObject, 4.0f);
     }

    Vector3 GetRandomPos(){

    //Randomizing the position
        float x = Random.Range(-SpawnSize.x, SpawnSize.x);
        float z = Random.Range(-SpawnSize.y, SpawnSize.y);

        Vector3 position = transform.position;
        position.x += x;
        position.z += z;

    return position;
    }

private void Start(){

    InvokeRepeating(nameof(SpawnRainDrop), 0.0f, 0.4f);
    SpawnRainDrop();
}


private void OnDrawGizmosSelected(){

Gizmos.color = Color.red;

    Vector3 Size = new Vector3(SpawnSize.x, 0.1f, SpawnSize.y);


Gizmos.DrawWireCube(transform.position, Size*2);

}


}
