using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeedController : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    public PaddleController paddleLeft;
    public PaddleController paddleRight;
    
    private float timer = 6;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            manager.RemovePowerUp(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball){
            paddleLeft.ActivatePaddleSpeedUp();
            paddleRight.ActivatePaddleSpeedUp();
            manager.RemovePowerUp(gameObject);
        }
    }
}