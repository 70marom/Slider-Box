using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FullscreenSave : MonoBehaviour
{
    public Toggle toggle;
    public bool tst;

    void Start()
    {
        tst = (PlayerPrefs.GetInt("value") != 0);
    }
    public void clickBack()
    {
        PlayerPrefs.SetInt("value", (tst ? 1 : 0));
        Debug.Log(PlayerPrefs.GetFloat("value"));
    }
}
