using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public double point = 0;
    public CanvasScripts can;

    private void Update()
    {
        can.ShowScore(point);
    }
}
