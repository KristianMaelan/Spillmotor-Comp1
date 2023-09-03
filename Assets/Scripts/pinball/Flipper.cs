using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{

[SerializeField] private AnimationCurve animationcurve;
private float _timer;



private void update(){

    if(Input.GetKeyDown(KeyCode.Space)){
    _timer = 0;

    }

_timer += Time.deltaTime;


float anglerotation = animationcurve.Evaluate(_timer) * 90;
Vector3 localRotation = new Vector3(0,0,anglerotation);

transform.localEulerAngles = localRotation;


}



}
