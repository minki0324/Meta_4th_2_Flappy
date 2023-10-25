using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private static GameManager instance = null;

    public GameObject PlayerCharacter;

    private int Score = 0;

    public float SurviveTime { get; private set; } = 0f;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            Destroy(gameObject);
        }
    }


    private void Update()
    {
        
    }

    public void AddScore(int score)
    {
        Score += score;
    }
}

