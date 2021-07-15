using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject firstStair;

    public GameObject darkStair;
    public GameObject iceStair;
    public GameObject fireStair;
    public GameObject BlackStair;


    public float degre = 20;
    public bool GEN = false;
    List<GameObject> GOs = new List<GameObject>();
    void Awake()
    {

      

        Gen();
   
    }
    private void Start()
    {

        StartCounter();
    }



    public void  RecordScore()
    {
       
    }

    public void StartCounter()
    {
        StartCoroutine(Counter());
    }


    public GameObject player;


    public Text counter;
    public AudioSource tick;
    IEnumerator Counter()
    {
        counter.gameObject.SetActive(true);
        counter.text = 3+"";
        tick.Play();
        yield return new WaitForSeconds(0.5f);
        counter.text = 2 + "";
        tick.Play();
        yield return new WaitForSeconds(0.5f);
        counter.text = 1 + "";
        tick.Play();
        yield return new WaitForSeconds(0.5f);
        counter.text = "GO!";
        tick.Play();
        yield return new WaitForSeconds(0.5f);
        counter.gameObject.SetActive(false);
        player.GetComponent<Rigidbody>().useGravity = true;
        player.GetComponent<PlayerMove>().enabled = true;
        normalButton.enabled = true;
        yield  break;
    }
    public Button normalButton;
  
    void Update()
    {





    }

    public void Gen()
    {

      
        for (int i = 1; i < 666; i++)
        {

            var stair =  Instantiate(firstStair, new Vector3(0, i, 0), Quaternion.Euler(0, degre * i, 0));
            stair.isStatic = true;

            stair.tag = "normal";
            if (i >= 50)
            {

                if ((int)Random.Range(0, 5) == 0)
                {
                    SetElement(stair, Elements.Ice);
                    

                }
                
            }
            if (i >= 100)
            {

                if ((int)Random.Range(0, 5) == 0)
                {
                    SetElement(stair, Elements.Fire);

                }
            }
            if (i >= 150)
            {

                if ((int)Random.Range(0, 5) == 0)
                {
                    SetElement(stair, Elements.Dark);

                }
            }
            if (i >= 200)
            {

                if ((int)Random.Range(0, 5) == 0)
                {
                    SetElement(stair, Elements.Black);

                }
            }



        }

 

    }



    public void Restart()
    {

        SceneManager.LoadScene(1);


    }
    public void Home()
    {

        SceneManager.LoadSceneAsync(0);


    }


    public void SetElement(GameObject stair, Elements element)
    {

        if (element == Elements.Ice)
        {
            stair.GetComponentInChildren<MeshRenderer>().material = iceStair.GetComponentInChildren<MeshRenderer>().material;
            stair.GetComponentInChildren<MeshFilter>().mesh = iceStair.GetComponentInChildren<MeshFilter>().mesh;
            stair.GetComponentInChildren<MeshFilter>().gameObject.tag = "ice";

        }
        if (element == Elements.Fire)
        {
            stair.GetComponentInChildren<MeshRenderer>().material = fireStair.GetComponentInChildren<MeshRenderer>().material;
            stair.GetComponentInChildren<MeshFilter>().mesh = fireStair.GetComponentInChildren<MeshFilter>().mesh;
            stair.GetComponentInChildren<MeshFilter>().gameObject.tag = "fire";
        }
        if (element == Elements.Dark)
        {
            stair.GetComponentInChildren<MeshRenderer>().material = darkStair.GetComponentInChildren<MeshRenderer>().material;
            stair.GetComponentInChildren<MeshFilter>().mesh = darkStair.GetComponentInChildren<MeshFilter>().mesh;
            stair.GetComponentInChildren<MeshFilter>().gameObject.tag = "dark";
        }
        if (element == Elements.Black)
        {
            stair.GetComponentInChildren<MeshRenderer>().material = BlackStair.GetComponentInChildren<MeshRenderer>().material;
            stair.GetComponentInChildren<MeshFilter>().mesh = BlackStair.GetComponentInChildren<MeshFilter>().mesh;
            stair.GetComponentInChildren<MeshFilter>().gameObject.tag = "black";
        }

    }


 

}
