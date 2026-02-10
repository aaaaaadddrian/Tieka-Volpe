using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour{
    public float speed;
    private GameObject currentCookie;
    public float offY;
    public GameObject cookie;
    public GameObject[] treatsToDrop;
    public float maxX;
    public float minX;
    private Queue<GameObject> queueOfTreats;
    
    
    
    //cookie -> peppermint -> jello -> sand -> donut -> muffin -> icecream -> cinnamon roll-> cupcake -> cake
    
    void Start(){
       queueOfTreats = new Queue<GameObject>();
       for (int i = 0; i < 10; i++)
       {
           queueOfTreats.Enqueue((treatsToDrop[Random.Range(0, treatsToDrop.Length)]));
       }
    }

    
    void Update()
    {
        
        if(currentCookie != null){
            Vector3 playerPos = transform.position;
            Vector3 cookieOffset = new Vector3(0.0f, offY, 0.0f);
            currentCookie.transform.position = playerPos + cookieOffset;
            Rigidbody2D body = currentCookie.GetComponent<Rigidbody2D>();
            body.gravityScale = 0f;
            Collider2D collider = currentCookie.GetComponent<Collider2D>();
            collider.enabled = false;
        }else{
            currentCookie = Instantiate(queueOfTreats.Dequeue());
            queueOfTreats.Enqueue((treatsToDrop[Random.Range(0, treatsToDrop.Length)]));
        }
        

        if(Keyboard.current.spaceKey.wasPressedThisFrame){
            Rigidbody2D body = currentCookie.GetComponent<Rigidbody2D>();
            body.gravityScale = 1.0f;
            Collider2D collider = currentCookie.GetComponent<Collider2D>();
            collider.enabled = true;
            currentCookie = null;
        }

        if((Keyboard.current.leftArrowKey.isPressed && transform.position.x > minX)|| (Keyboard.current.aKey.isPressed && transform.position.x > minX)){
            Vector3 newPosition = transform.position;
            newPosition.x = newPosition.x - speed;
            transform.position = newPosition;
            
        }

        if((Keyboard.current.rightArrowKey.isPressed && transform.position.x < maxX)|| (Keyboard.current.dKey.isPressed && transform.position.x < maxX)){
            Vector3 newPosition = transform.position;
            newPosition.x = newPosition.x + speed;
            transform.position = newPosition;
        }
        
    }
    
    
}
