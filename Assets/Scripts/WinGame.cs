using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinGame : MonoBehaviour
{
    public GameObject MainWin;
    public double total = 0;
    public Point p;

    private float time_play = 120f;
    public TextMeshProUGUI text;

    public GameManager gm;

    private void Start()
    {
        p = GameObject.FindObjectOfType<Point>().GetComponent<Point>();
        gm = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }

    private void Update()
    {
        time_play -= Time.deltaTime;
        if(time_play <= 0)
        {
            winGame();
        }
        if (time_play > 0 && gm.check_pause == false) Time.timeScale = 1;
            
    }



    public void winGame()
    {
        total = p.point;
        Time.timeScale = 0;
        MainWin.SetActive(true);
        ShowScore();
        
    }

    public void ShowScore()
    {
        text.text = "Total: " + total;
    }

}
