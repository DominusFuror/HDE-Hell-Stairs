using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine.SocialPlatforms;

public class PlayerMove : MonoBehaviour
{
    public float speed = 1.1f;
     float startSpeed = 0.1f;

    float radius;
    public float jumpPower;

    bool isJump = false;


    public int steps = 0;

    Collider lastCollider=null;
    const string leaderBoardID = "CgkIj475x8ACEAIQAQ";
    public GameManager gameManager;
    Animator playerAnimator;
    private void Start()
    {
        startSpeed = speed;
        playerAnimator = GetComponentInChildren<Animator>(); 
        radius =  Mathf.Abs(this.transform.position.x);

        playerElement = Elements.Normal;
    }
    private void FixedUpdate()
    {
        this.transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1 , 0),360 * speed *Time.fixedDeltaTime);

       // speed += 0.01f;
    }

    private void Update()
    {

      
    }

    public Elements playerElement;

    public void Jump()
    {
        if (!isJump)
        {
            StaticticSc.totalJumps++;
            isJump = true;
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpPower, 0));
            playerAnimator.SetTrigger("JumpTr");
        }
      

    }

    public GameObject ScoreScreen;
    public GameObject playerModel;
    public GameObject dieParticl;
    public Text yourScore;


   












    public void OnDeath()
    {
        ScoreScreen.SetActive(true);
        playerModel.SetActive(false);
        dieParticl.SetActive(true);
        yourScore.text = "You score:" + steps;

        StaticticSc.totalDies++;
       if (StaticticSc.maxStair < steps)
        {
            StaticticSc.maxStair = steps;
        }
        StaticticSc.UpdateInfo();
        Destroy(this.GetComponent<Rigidbody>());
        Destroy(this);  
    

    }

    private void OnCollisionEnter(Collision collision)
    {
        isJump = false;
        if (collision.gameObject.tag == "Death")
        {


            OnDeath();


        }
        
        else
        {
            if (collision.gameObject.tag != playerElement.ToString().ToLower())
            {


                OnDeath();


            }

            else
            {

         
                if(collision.collider != lastCollider)
                {
                    steps++;
                    lastCollider = collision.collider;
                    stepsText.text = steps + "";

                    if (steps != 0 && steps % 20 == 0)
                    {

                        SpeedTextInc.SetActive(true);
                        speed += startSpeed / 25;

                    }
                    if (steps == 40)
                    {
                        iceButton.SetActive(true);
                    }
                    if (steps == 90)
                    {
                        fireButton.SetActive(true);
                    }
                    if (steps == 140)
                    {
                        darkButton.SetActive(true);
                    }
                    if (steps == 190)
                    {
                        Blakcbutton.SetActive(true);
                    }
                }
            }
        }
    }
    public Text stepsText;
    public GameObject SpeedTextInc;

    public GameObject iceButton;
    public GameObject fireButton;
    public GameObject darkButton;
    public GameObject Blakcbutton;
}


public enum Elements
{

    Ice,
    Dark,
    Fire,
    Black,
    Normal

}
