using UnityEngine;

public class CollisionDetecter : MonoBehaviour
{
    public GameObject[] treats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void onCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == this.gameObject.tag)
            {
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                Instantiate(treats[0]);
            }
        }
    }


}
