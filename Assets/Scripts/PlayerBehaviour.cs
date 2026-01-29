using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour{
    public float speed;
    public GameObject fruit;
    public float offY;

    void Start(){
       
    }

    
    void Update(){

        if(fruit != null){
            Vector3 playerPos = transform.position;
            Vector3 fruitOffset = new Vector3(0.0f, offY, 0.0f);
            fruit.transform.position = playerPos + fruitOffset;
            Rigidbody2D body = fruit.GetComponent<Rigidbody2D>();
            body.gravityScale = 0f;
            Collider2D collider = fruit.GetComponent<Collider2D>();
            collider.enabled = false;
        }

        if(Keyboard.current.spaceKey.wasPressedThisFrame){
            Rigidbody2D body = fruit.GetComponent<Rigidbody2D>();
            body.gravityScale = 1.0f;
            Collider2D collider = fruit.GetComponent<Collider2D>();
            collider.enabled = true;
            fruit = null;

        }

        if(Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed){
            Vector3 newPosition = transform.position;
            newPosition.x = newPosition.x - speed;
            transform.position = newPosition;
        }

        if(Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed){
            Vector3 newPosition = transform.position;
            newPosition.x = newPosition.x + speed;
            transform.position = newPosition;
        }
    }
}
