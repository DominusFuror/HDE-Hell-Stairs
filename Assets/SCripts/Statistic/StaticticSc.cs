using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticticSc : MonoBehaviour
{
    static  public int totalDies = 0;
    static public int totalJumps = 0;

    static public int totalIceStairsComplete = 0;
    static public int totalFireStairsComplete = 0;
    static public int totalBlackStairsComplete = 0;
    static public int totalDarkStairsComplete = 0;
    static public int maxStair = 0;

    public void Start()
    {
        GetInfo();

    }

    public static void GetInfo()
    {
        totalDies = PlayerPrefs.GetInt("totalDies");
        totalJumps = PlayerPrefs.GetInt("totalJumps");
        maxStair = PlayerPrefs.GetInt("maxStair");
        totalIceStairsComplete = PlayerPrefs.GetInt("totalIceStairsComplete");
        totalFireStairsComplete = PlayerPrefs.GetInt("totalFireStairsComplete");
        totalDarkStairsComplete = PlayerPrefs.GetInt("totalDarkStairsComplete");
        totalBlackStairsComplete = PlayerPrefs.GetInt("totalBlackStairsComplete");
    }

    private void OnApplicationQuit()
    {
      
    }

    public static void UpdateInfo()
    {
        PlayerPrefs.SetInt("totalDies", totalDies);
        PlayerPrefs.SetInt("totalJumps", totalJumps);
        PlayerPrefs.SetInt("maxStair", maxStair);
        PlayerPrefs.SetInt("totalIceStairsComplete", totalIceStairsComplete);
        PlayerPrefs.SetInt("totalFireStairsComplete", totalFireStairsComplete);
        PlayerPrefs.SetInt("totalDarkStairsComplete", totalDarkStairsComplete);
        PlayerPrefs.SetInt("totalBlackStairsComplete", totalBlackStairsComplete);
        PlayerPrefs.Save();
    }

    public void ShowStatistick() {
        GetInfo();


        StatisticUI.SetActive(true);
        totalJumpsText.text = totalJumps +"";
        totalDiesText.text = totalDies+"";
        maxSaitrText.text = maxStair + "";
        totalIceStairsCompleteText.text = totalIceStairsComplete+"";
        totalFireStairsCompleteText.text = totalFireStairsComplete+"";
        totalDarkStairsCompleteText.text = totalDarkStairsComplete+"";
        totalBlackStairsCompleteText.text = totalBlackStairsComplete+"";






    }
    public GameObject StatisticUI;
    public UnityEngine.UI.Text totalJumpsText;
    public UnityEngine.UI.Text totalDiesText;
    public UnityEngine.UI.Text maxSaitrText;
    public UnityEngine.UI.Text totalIceStairsCompleteText;
    public UnityEngine.UI.Text totalFireStairsCompleteText;
    public UnityEngine.UI.Text totalDarkStairsCompleteText;
    public UnityEngine.UI.Text totalBlackStairsCompleteText;


}
