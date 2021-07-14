using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    int score = 0;

    public void RaiserScore(int s)
    {
        score += s;
        scoreText.text = score + "";
        //Debug.Log(score);

        if (score == 5)
        {
          SceneManager.LoadScene ("Escena2");
        }
    }
}
