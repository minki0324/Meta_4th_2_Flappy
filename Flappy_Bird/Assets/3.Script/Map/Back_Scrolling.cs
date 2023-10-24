using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back_Scrolling : MonoBehaviour
{
    /*
        1. �� ��� �̹����� z���� ������ - ��Ų��.
        2. ���� ���̰� �Ǹ� ���� �ʺ� x2��ŭ z �������� ���� ������ �̵���Ų��.

        ����
        ��� �̵��ӵ�
        ��� �̵� ����
        ��� ������
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
