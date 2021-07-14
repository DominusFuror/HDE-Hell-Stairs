using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMaterialChanger : MonoBehaviour
{
    public PlayerMove playerMoveSC;
    public MeshRenderer meshRendererSC;
    void Start()
    {
        
        

    }

    public Material iceMat;
    public Material fireMat;
    public Material normalMat;
    public Material darkMat;
    public Material blackMat;

   
    public void IcePressed()
    {
        playerMoveSC.playerElement = Elements.Ice;
        meshRendererSC.material = iceMat;
        playerMoveSC.Jump();
        StaticticSc.totalIceStairsComplete++;
    }
    public void DarkPressed()
    {
        playerMoveSC.playerElement = Elements.Dark;
        meshRendererSC.material = darkMat;
        playerMoveSC.Jump();
        StaticticSc.totalDarkStairsComplete++;
    }
    public void BlackPressed()
    {
        playerMoveSC.playerElement = Elements.Black;
        meshRendererSC.material = blackMat;
        playerMoveSC.Jump();
        StaticticSc.totalBlackStairsComplete++;
    }
    public void StandartPressed()
    {
        playerMoveSC.playerElement = Elements.Normal;
        meshRendererSC.material = normalMat;
        playerMoveSC.Jump();
 
    }
    public void FirePressed()
    {
        playerMoveSC.playerElement = Elements.Fire;
        meshRendererSC.material = fireMat;
        playerMoveSC.Jump();
        StaticticSc.totalFireStairsComplete++;
    }
}
