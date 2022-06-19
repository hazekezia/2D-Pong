using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedController : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    private float timer = 6;

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision == ball){
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
