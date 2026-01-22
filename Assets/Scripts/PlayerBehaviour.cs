using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour{
    public float speed;

    void Start(){
       
    }

    
    void Update(){
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
