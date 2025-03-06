using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI kullanabilmek için tanýmlamak gerekli

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString();
    }
}
