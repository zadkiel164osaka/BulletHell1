using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayControl : MonoBehaviour
{
    public static GamePlayControl instance;
   void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if(instance == null )
        {
            instance = this;
        }
    }
    [SerializeField]
    private GameObject PausePanel,GameOverPanel;
    public void PauseGame()
    {
        PausePanel.SetActive(true); // hiện bảng pause panel
        Time.timeScale = 0f; // đứng thời gian , cho mọi thứ trong game tạm đứng im
    }

    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RestartButton()
    {
        GameOverPanel.SetActive(false);
        Application.LoadLevel("GamePlay"); 
    }

    public void MenuButton()
    {
        Application.LoadLevel("MainMenu");
    }

    public void DestroyedPlayer()
    {
        GameOverPanel.SetActive(true);
        Debug.Log("Collison");
    }
    
}
