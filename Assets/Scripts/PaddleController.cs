using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaddleController : MonoBehaviour
{
    public int speed, resetSpeed;
    public KeyCode upKey, downKey;
    private Rigidbody2D rig;
    private Vector3 scale;
    bool ActivePaddleLength = false, ActivePaddleSpeed = false;
    private float timer = 5;
    public Text paddleSpeed, paddleLength;
    
    // Start is called before the first frame update
    void Start(){
        rig = GetComponent<Rigidbody2D>();
        scale = transform.localScale;
        resetSpeed = speed;
    }

    // Update is called once per frame
    private void Update(){
        Vector2 movement;
        movement = GetInput();

        MoveObject(movement);

        paddleSpeed.text = ("Paddle Speed : " + speed);
        paddleLength.text = ("Paddle Length : " + transform.localScale.y);

        if (ActivePaddleLength == true){
            timer -= Time.deltaTime;
            if (timer <= 0){
                ResetPaddleLength();
                ActivePaddleLength = false;
                timer = 5;
            }
        }
        else if (ActivePaddleSpeed == true){
            timer -= Time.deltaTime;
            if (timer <= 0){
                ResetPaddleSpeed();
                ActivePaddleSpeed = false;
                timer = 5;
            }
        }

    }

    private Vector2 GetInput(){
        if(Input.GetKey(upKey)){
            return Vector2.up * speed;
        }
        else if(Input.GetKey(downKey)){
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement){
        //gerakan object
        rig.velocity = movement;
    }

    public void ActivatePaddleSpeedUp(){
        speed *= 2;
        ActivePaddleSpeed = true;
        Debug.Log("Paddle speed : " + speed);
    }

    public void ActivatePaddleLengthUp(){
        transform.localScale = new Vector3(scale.x, scale.y * 2, 2);
        ActivePaddleLength = true;
        Debug.Log("Paddle length : " + transform.localScale.y);
    }

    public void ResetPaddleSpeed(){
        speed = resetSpeed;
        Debug.Log("Paddle speed : " + speed);
    }

    public void ResetPaddleLength(){
        transform.localScale = scale;
        Debug.Log("Paddle length : " + scale.y);
    }

}
