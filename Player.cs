using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
   public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;//물리 프레임 하나가 소모한 시간
        //Move position
        rigid.MovePosition(rigid.position + nextVec);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
