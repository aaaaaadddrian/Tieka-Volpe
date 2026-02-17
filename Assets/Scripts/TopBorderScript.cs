using System;
using Unity.VisualScripting;
using UnityEngine;

public class TopBorderScript : MonoBehaviour
{

    private float timeout = 2f;
    private float timeStart;
    public GameObject gameOverScreen;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        timeStart = Time.time;
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Time.time - timeStart > timeout)
        {
            print("YOU LOSE");
            gameOverScreen.SetActive(true);
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>().enabled = false;
        }
    }

}
