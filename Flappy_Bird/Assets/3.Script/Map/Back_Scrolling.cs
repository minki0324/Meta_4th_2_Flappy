using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Scrolling : MonoBehaviour
{
    /*
        1. 뒷 배경 이미지의 z축을 무한히 - 시킨다.
        2. 일정 길이가 되면 기존 너비 x2만큼 z 포지션을 더해 앞으로 이동시킨다.

        변수
        배경 이동속도
        배경 이동 방향
        배경 사이즈
    */

    [SerializeField] private float Scroll_Speed = 3f;
    [SerializeField] private Vector3 Scroll_Dir = Vector3.forward;
    [SerializeField] private float Image_Size = 99f;

    private void Update()
    {
        transform.position += Scroll_Dir * Scroll_Speed * Time.deltaTime;

        if (transform.position.z >= Image_Size)
        {
            BackGroundOffset();
        }
    }
    

    public void BackGroundOffset()
    {
        Vector3 offset = new Vector3(0, 0, Image_Size * 2f);
        transform.position = transform.position - offset;
    }
}
