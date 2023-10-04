using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScript : MonoBehaviour
{
    private float CurrentTime;
    [SerializeField] TMP_Text TimerText;
    [SerializeField] TMP_Text ScoreText;
   // [SerializeField] public Raindrop RaindropPF;
    public int Score = -120;
    
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = 0.0f;
        TimerText.text = CurrentTime.ToString("F1");
        Score = 0;
    }

    private void FixedUpdate()
    {
        //Score = RaindropPF.ScoreCounter;
        CurrentTime += Time.deltaTime;
        TimerText.text = "Time: " + CurrentTime.ToString("F1");
        ScoreText.text = "Score: " + Score.ToString("");
    }
}
