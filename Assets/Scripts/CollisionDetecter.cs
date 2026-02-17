using TMPro;
using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public GameObject[] treats;
    
    
    
    void Start()
    {
        
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
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>().updateScore((int)(100 * this.gameObject.transform.localScale.x));
        }
        else
        {
            if (this.gameObject.tag == collision.gameObject.tag && this.gameObject.tag == "cake")
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>().updateScore(1000);
            }
        }
    }
    
    
}
