using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_UI : MonoBehaviour
{

    [SerializeField]
    private GameObject StartPanel;

    [SerializeField]
    private GameObject SelectCharacter_Panel;

    [SerializeField]
    private GameObject InGame_Panel;

    [SerializeField]
    private GameObject GameOver_Panel;

    private void Awake()
    {
        StartPanel.SetActive(true);
        SelectCharacter_Panel.SetActive(false);
        InGame_Panel.SetActive(false);
        GameOver_Panel.SetActive(false);

    }


    public void SelectCharacter_Btn()
    {
        StartPanel.SetActive(false);
        SelectCharacter_Panel.SetActive(true);
    }
}
