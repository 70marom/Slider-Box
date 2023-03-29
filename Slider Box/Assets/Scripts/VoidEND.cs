using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidEND : MonoBehaviour
{
    public MovePosition movement2;
    public GameObject gameover;
    public GameObject ScoreTXT;
    public GameObject Score;
    public GameObject HighscoreTXT;
    public GameObject Highscore;
    private void OnTriggerEnter(Collider other)
    {
        gameover.SetActive(true);
        movement2.enabled = false;
        ScoreTXT.SetActive(false);
        Score.SetActive(false);
        HighscoreTXT.SetActive(false);
        Highscore.SetActive(false);
    }

}
