using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{

    private Point a;
    public GameObject blood;
    

    private void Start()
    {
        a = GameObject.FindObjectOfType<Point>().GetComponent<Point>();
    }

    private void OnMouseDown()
    {
        a.point += 100;
        Destroy(gameObject);

        GameObject b = Instantiate(blood, transform.position, Quaternion.identity);
        Destroy(b, 1.5f);
    }
}
