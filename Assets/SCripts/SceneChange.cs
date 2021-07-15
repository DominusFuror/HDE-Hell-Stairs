using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.LoadSceneAsync(1);
        scene.allowSceneActivation = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    AsyncOperation scene;
    public AudioSource portalSound;
    public void LoadScene()
    {



        portalSound.Play();

        this.GetComponent<Animator>().SetTrigger("LoadTr");
    }



    public void Load()
    {
        scene.allowSceneActivation = true;

    }
}
