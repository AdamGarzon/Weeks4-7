using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovements : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rightArrowKey.isPressed == true) 
        {
            Debug.Log("Move Right");
            Vector2 newPosition = transform.position;
            newPosition.x += 1;
            //newPosition.x -= speed * Time.deltaTime;
            transform.position = newPosition; 
        }

    }
}
