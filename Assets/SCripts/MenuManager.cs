using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames.BasicApi;
using GooglePlayGames;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{


    public bool autorez = false;
    // Start is called before the first frame update
    void Start()
    {
    

       
        
    }


    public void EnterGogole()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();




        //Social.localUser.Authenticate(succes =>
        //{

        //    autorez = succes;


        //});

        PlayGamesPlatform.Instance.Authenticate((result, mess) => {
            GameObject.Find("DT").GetComponent<Text>().text = $"{result} | {mess}";

        });

    }

    public void OpenLeadersTab()
    {

        PlayGamesLeaderboard board = new PlayGamesLeaderboard(GPGSIds.leaderboard_hell_stairs_top);
        board.LoadScores(succes =>
        {
            
            GameObject.Find("DT").GetComponent<Text>().text = succes + " !";

        }
        );
        print("T");
    }

    public void Exit()
    {

        Application.Quit();

    }
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        
    }

}
