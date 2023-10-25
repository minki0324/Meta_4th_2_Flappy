using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] float JumpForce = 5f;
    [SerializeField] Animator ani;

    Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        TryGetComponent(out ani);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) )
        {
            rigidbody.velocity = new Vector3(0, JumpForce, 0);
            ani.SetTrigger("Jump");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
            GameManager.instance.EndGame();
    }

}
