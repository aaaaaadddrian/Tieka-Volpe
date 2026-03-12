using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    private GameObject[] bcks;
    public GameObject background;

    private float pivot = -5.12f;

    private float speed = 0.05f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bcks = new GameObject[3];
        for (int i = 0; i < 3; i++)
        {
            float xPos = pivot - ((pivot/2) * i);
            float yPos = pivot -  ((pivot/2) * i);
            Vector2 pos = new Vector2(xPos, yPos);
            bcks[i] = Instantiate(background, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 3; i++)
        {
            float xPos = bcks[i].transform.position.x + speed;
            float yPos = bcks[i].transform.position.y + speed;
            Vector2 pos = new Vector2(xPos, yPos);
            if (bcks[i].transform.position.x > -pivot/2)
            {
                pos = new Vector2(pivot, pivot);
            }
            bcks[i].transform.position = pos;
        }
        
    }
}
