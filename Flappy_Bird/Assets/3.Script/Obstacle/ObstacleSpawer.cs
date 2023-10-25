using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawer : MonoBehaviour
{
    //Ǯ���� ������Ʈ
    [SerializeField] private GameObject obstacle;
    [SerializeField]private int count;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject[] upOb;
    [SerializeField] private GameObject[] downOb;
    private Vector3 PoolPosition;
    private Vector3 SpawnPositon;
    private float genTime = 1.0f; // �����ֱ�
    private float timer = 0f;
    //Ǯ���� ������Ʈ�� ���� ����Ʈ
    private Queue<GameObject> ob_Pool = new Queue<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        PoolPosition = new Vector3(0, 40, 0);
       
        for (int i = 0; i < count; i++)
        {
            GameObject ob = Instantiate(obstacle, PoolPosition, Quaternion.identity);
            ob_Pool.Enqueue(ob);
            ob.SetActive(false);


        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= genTime)
        {
            SpawnOb();
            timer = 0f;
        }
        
    }

    private void SpawnOb()
    {
        if(ob_Pool.Count > 0)
        //  ������ ��Ҵ� �÷��̾ �ٶ󺸴� ���⿡���� �Ÿ� 10��������.
        SpawnPositon = new Vector3(player.transform.position.x, 0, -20);

        //SpawnPositon = player.wo
        GameObject ob = ob_Pool.Dequeue();
        ob.SetActive(true);

        ob.transform.position = SpawnPositon;


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            other.gameObject.SetActive(false);
            ob_Pool.Enqueue(other.gameObject);
            //GameObject[] Up = other.GetComponent<ObstacleMove>().childArrayUp;
            //GameObject[] Down = other.GetComponent<ObstacleMove>().childArrayDown;
            //for (int i = 0; i < Up.Length; i++)
            //{
            //    Up[i].SetActive(true);
            //    Down[i].SetActive(true);
            //}
        }
    }
}
