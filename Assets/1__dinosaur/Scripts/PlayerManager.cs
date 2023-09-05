using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public VariableJoystick joy;
    public VariableJoystick rotY;

    public float playerSpeed = 3f;
    public float playerRotSpeed = 2f;

    private Animator anim;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        Move();
        
    }

    void Move()
    {
        float horizontalInput = joy.Horizontal;
        float verticalInput = joy.Vertical;

        // 이동 벡터 계산
        Vector3 dir = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        if(dir != Vector3.zero)
        {
            transform.LookAt(transform.position + dir);
            Vector3 movement = dir * playerSpeed * Time.deltaTime;
            movement.y = 0f;
            transform.Translate(movement, Space.World);

            anim.SetTrigger("ToRun_Idle");
        }
        else
        {
            anim.SetTrigger("ToIdle");
        }

    }


}
