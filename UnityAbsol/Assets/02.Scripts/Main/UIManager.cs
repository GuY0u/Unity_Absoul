using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnClickStartBtn(RectTransform rt)
    {
        //Debug.Log("Click Button : " + msg);
        //Debug.Log("Scale X : " + rt.localScale.x.ToString());

        SceneManager.LoadScene("SceneLoader");
        //SceneManager.LoadScene("ManagementScenes_Level1");
        //SceneManager.LoadScene("ManagementScenes_Play", LoadSceneMode.Additive);
    }
}
