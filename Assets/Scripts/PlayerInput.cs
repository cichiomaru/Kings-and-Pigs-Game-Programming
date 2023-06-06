using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private IMove move;
    private IJump jump;
    private IAttack attack;

    private void Awake()
    {
        move = GetComponent<IMove>();
        jump = GetComponent<IJump>();
        attack = GetComponent<IAttack>();
    }

    private void Update()
    {
        move.SetDirection(Input.GetAxisRaw("Horizontal"));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            attack.Attack();
        }
    }
}
