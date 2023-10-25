using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject PlayerCharacter;
    public GameObject GameoverText;
    public Text Recordtext;

    private int Score = 0;

    private bool isLive = true;

    public float GameTime = 0;

    private void Awake()
    {
        Stop();

        instance = this;


    }


    private void Update()
    {
        GameTime += Time.deltaTime;
    }

    public void AddScore(int score)
    {
        Score += score;
    }

    public void Stop()
    {
        isLive = false;
        Time.timeScale = 0;
    }

    public void Resume()
    {
        isLive = true;
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        isLive = true;
        Time.timeScale = 0;
        GameoverText.SetActive(true);

        float BestTime = PlayerPrefs.GetFloat("BestTime");

        if (GameTime > BestTime)
        {
            BestTime = GameTime;
            PlayerPrefs.SetFloat("BestTime", BestTime);
        }

        Recordtext.text = $"최고기록 : {(int)BestTime}";
    }
}

