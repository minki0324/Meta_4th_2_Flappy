using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public GameObject[] childArrayUp;
    public GameObject[] childArrayDown;
    private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Awake()
    {
        childArrayDown = new GameObject[4];
        childArrayUp = new GameObject[4];

        for (int i = 0; i < 4; i++)
        {
            childArrayUp[i] = transform.GetChild(8 - i).gameObject;
            childArrayDown[i] = transform.GetChild(i + 1).gameObject;
            //Debug.Log($"업타일의 {i}번째 이름은{ childArrayUp[i].gameObject.name}");
            //Debug.Log($"다운타일의 {i}번째 이름은{childArrayDown[i].gameObject.name}");
        }
    }
    private void OnEnable()
    {
        for (int i = 0; i < 4; i++)
        {
            childArrayDown[i].gameObject.SetActive(true);
            childArrayUp[i].gameObject.SetActive(true);
        }
        int rand = Random.Range(0, 5);
        Debug.Log(rand);
        if (rand > 0) { 
        for (int i = 0; i < rand; i++)
        {
            childArrayDown[3 - i].gameObject.SetActive(false);
            //childArrayUp[3 - i].gameObject.SetActive(false);
        }
           
        }
        for (int i = 0; i < 4 - rand; i++)
        {
            //childArrayDown[3 - i].gameObject.SetActive(false);
            childArrayUp[3 - i].gameObject.SetActive(false);
        }

    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
    }
}
