using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public void PlayButton()
    {
        Application.LoadLevel("GamePlay");
    }
    public void QuitButton()
    {
        Application.Quit();
    } 
}
