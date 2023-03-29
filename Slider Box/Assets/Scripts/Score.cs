using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Transform playerTransform;
    public TextMeshProUGUI txt;
    public TextMeshProUGUI highscore;
    public int score;
    float trans;
    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("HighScore").ToString("0");
    }
    void Update()
    {
        trans = playerTransform.position.z;
        txt.text = trans.ToString("0");
        if (trans > PlayerPrefs.GetFloat("HighScore"))
        {
            PlayerPrefs.SetFloat("HighScore", trans);
            highscore.text = trans.ToString("0");
        }
        
    }
}