using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
   public void PressPlay()
    {
        SceneManager.LoadScene("Scenes/Pinball");
        
    }

   public void PressQuit()
    {
        Application.Quit();
    }
}
