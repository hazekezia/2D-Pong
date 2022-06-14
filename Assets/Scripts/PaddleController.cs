using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;
    public KeyCode upKey, downKey;
    private Rigidbody2D rig;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Paddle speed: " + speed);
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector2 movement;
        movement = GetInput();

        MoveObject(movement);
    }

    private Vector2 GetInput(){

        //user input
        if(Input.GetKey(upKey)){
            //atas
            return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey)){
            //bawah
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement){
        //gerakan object
        rig.velocity = movement;
    }
}