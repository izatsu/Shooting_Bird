using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject ViewFinder;
    private Vector3 tagre;

    //music shooting
    public AudioSource au;
    public AudioClip Shooting;

    public GameObject Shooting_prefabs;


    void Start()
    {
        Cursor.visible = false;
    }

    
    

    // Update is called once per frame
    void Update()
    {
        tagre = transform.GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        ViewFinder.transform.position = new Vector2(tagre.x,tagre.y);

        if (Input.GetMouseButtonDown(0) == true)
        {
            Shooting_prefabs.SetActive(true);
            StartCoroutine(delay());
            au.PlayOneShot(Shooting);
        }
    }

    private IEnumerator delay()
    {
        yield return new WaitForSeconds(0.25f);
        Shooting_prefabs.SetActive(false);
    } 
        
}
