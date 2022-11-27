using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject pause;
    public bool check_pause = false;

    public void StartGame()
    {

        SceneManager.LoadScene("SampleScene");
        check_pause = false;
    }
    
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        check_pause = false;
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        check_pause = false;
    }


    public void PauseGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        check_pause = true;
    }
    
    public void PlayGame()
    {
        Time.timeScale = 1f;
        pause.SetActive(false);
        check_pause = false;
    } 
        
        

}
