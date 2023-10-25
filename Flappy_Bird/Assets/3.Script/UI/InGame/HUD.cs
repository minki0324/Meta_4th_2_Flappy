using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    private Text timer;

    private void Awake()
    {
        timer = GetComponent<Text>();
    }

    private void Update()
    {
        int sec = Mathf.FloorToInt(GameManager.instance.GameTime % 60f);
        int min = Mathf.FloorToInt(GameManager.instance.GameTime / 60f);
        timer.text = $"{min:D2} : {sec:D2}";
    }
}
