using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI_Controller : MonoBehaviour
{  //패널=====================
    [SerializeField]
    private GameObject StartPanel;

    [SerializeField]
    private GameObject SelectCharacter_Panel;

    [SerializeField]
    private GameObject InGame_Panel;

    [SerializeField]
    private GameObject GameOver_Panel;


    //버튼====================

    [SerializeField]
    private Button Character1_Btn;

    [SerializeField]
    private Button Character2_Btn;

    [SerializeField]
    private Button Character3_Btn;

    bool isC1_Selected = false;
    bool isC2_Selected = false;
    bool isC3_Selected = false;
    private int Select_Num = 0;


    //텍스트==================
    [SerializeField]
    private Text ScoreText;


    private void Awake()
    {
        StartPanel.SetActive(true);
        SelectCharacter_Panel.SetActive(false); 
        InGame_Panel.SetActive(false);
        GameOver_Panel.SetActive(false);
    }

    #region 버튼 이벤트

    public void GameStart_Btn_Clicked()
    {
        StartPanel.SetActive(false);
        InGame_Panel.SetActive(true);
        GameManager.instance.PlayerCharacter.transform.GetChild(Select_Num).gameObject.SetActive(true);
    }

    public void SelectCharacter_Btn_Clicked()
    {
        StartPanel.SetActive(false);
        SelectCharacter_Panel.SetActive(true);
    }

    public void Return()
    {
        SelectCharacter_Panel.SetActive(false);
        StartPanel.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Character1_Clicked()
    {
        if(!isC1_Selected)
        {
            isC1_Selected = true;

            isC2_Selected = false;
            isC3_Selected = false;

            Select_Num = 0;

            Character1_Btn.GetComponent<Outline>().effectColor = Color.green;
            Character1_Btn.GetComponent<Outline>().effectDistance = new Vector2(5f, 5f);


            Character2_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);
            Character3_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);

        }
        else
        {
            isC1_Selected = false;
            Character1_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);
        }
    }

    public void Character2_Clicked()
    {
        if (!isC2_Selected)
        {
            isC2_Selected = true;

            isC1_Selected = false;
            isC3_Selected = false;

            Select_Num = 1;

            Character2_Btn.GetComponent<Outline>().effectColor = Color.green;
            Character2_Btn.GetComponent<Outline>().effectDistance = new Vector2(5f, 5f);


            
            Character1_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);    
            Character3_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);

        }
        else
        {
            isC2_Selected = false;          
            Character2_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);
        }
    }



    public void Character3_Clicked()
    {
        if (!isC3_Selected)
        {
            isC3_Selected = true;

            isC1_Selected = false;
            isC2_Selected = false;

            Select_Num = 2;

            Character3_Btn.GetComponent<Outline>().effectColor = Color.green;
            Character3_Btn.GetComponent<Outline>().effectDistance = new Vector2(5f, 5f);

    
            Character1_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);            
            Character2_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);

        }
        else
        {
            isC3_Selected = false;
            Character3_Btn.GetComponent<Outline>().effectDistance = new Vector2(0f, 0f);
        }

    }



    #endregion






}
