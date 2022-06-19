using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    public Vector2 speed;

    public Vector2 resetPosition;
    private Rigidbody2D rig;
    public Text pressSpace;
    public Text ballSpeed;
    private string MakeStr;

    // Start is called before the first frame update
    void Start()
    {
        pressSpace.enabled = true; 
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = new Vector3(0, 0, 2);
        
    }

    public void Update(){
        ballSpeed.text = ("Ball Speed : " + Mathf.Abs(Mathf.RoundToInt(rig.velocity.x)));
        if (Input.GetKeyDown("space")){
            pressSpace.enabled = false;
            var valueAcak = Random.Range(-10f,10f);
            if (valueAcak<=0){
                valueAcak=-10f;
            }
            else{
                valueAcak=10f;
            }
        rig.velocity = speed = new Vector3(valueAcak, Random.Range(-10f,10f), 2);
        }
        if (Input.GetKeyDown("r")){
            ResetBall();
        }
    }

    // Update is called once per frame
    public void ResetBall(){
        pressSpace.enabled = true;
        rig.velocity = speed = new Vector3(0, 0, 2);
        transform.position = new Vector3(resetPosition.x,resetPosition.y,2);
    }

    public void ActivatePUSpeedUp(float magnitude){
        rig.velocity *= magnitude;
        Debug.Log("Ball Speed : " + rig.velocity.x);
    }
}
