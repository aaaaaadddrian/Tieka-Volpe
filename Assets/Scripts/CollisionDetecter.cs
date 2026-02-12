using TMPro;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public GameObject[] treats;
    public GameObject scorePanel;
    private int score;
    
    
    void Start()
    {
        // score = 0;
        // scorePanel.GetComponentInChildren<TextMeshPro>().text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == this.gameObject.tag && this.gameObject.transform.position.y > collision.gameObject.transform.position.y) && this.gameObject.tag != "cake")
        {
            Destroy(collision.gameObject);
            Vector3 pos = this.gameObject.transform.position;
            Destroy(this.gameObject);
            Instantiate(treats[0], pos, Quaternion.identity).GetComponent<Collider2D>().enabled = true;
            // scorePanel.GetComponentInChildren<TextMeshPro>().text =  "Score: " + score + (int)(100 * this.gameObject.transform.localScale.x);
            // score = score + (int)(100 * this.gameObject.transform.localScale.x);
        }
        else
        {
            if (this.gameObject.tag == collision.gameObject.tag && this.gameObject.tag == "cake")
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
                // scorePanel.GetComponentInChildren<TextMeshPro>().text = "Score: " + score + 1000;
                // score = score + 1000;
            }
        }
    }
    
    
}
