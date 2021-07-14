using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorSpeedText : MonoBehaviour
{
    public UnityEngine.UI.Text text;

    

    IEnumerator AlphaRemover()
    {
        while (true)
        {
            text.color -= new Color(0, 0, 0, 2 * Time.deltaTime);
            yield return null;

        }

  


    }

    private void OnEnable()
    {
        text.color = Color.white;
    }
    public void  OffText()
    {
        StopCoroutine(AlphaRemover());
        gameObject.SetActive(false);


    }
    public void  StartHideText()
    {
        StartCoroutine(AlphaRemover());

    }


}
