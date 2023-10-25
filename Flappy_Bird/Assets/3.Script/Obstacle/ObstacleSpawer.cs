using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawer : MonoBehaviour
{
    //풀링할 오브젝트
    [SerializeField] private GameObject obstacle;
    [SerializeField]private int count;
    [SerializeField] private Transform player;
    [SerializeField] private GameObject[] upOb;
    [SerializeField] private GameObject[] downOb;
    private Vector3 PoolPosition;
    private Vector3 SpawnPositon;
    private float genTime = 1.0f; // 생성주기
    private float timer = 0f;
    //풀링할 오브젝트를 담을 리스트
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
        //  스폰될 장소는 플레이어가 바라보는 방향에서의 거리 10떨어진곳.
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
