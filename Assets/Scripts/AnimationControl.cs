using System;
using UnityEngine;

internal class AnimationControl : MonoBehaviour
{
    private Animator Animator;
    private Entity Entity;

    private void Awake()
    {
        Animator = GetComponentInChildren<Animator>();
        Entity = GetComponent<Entity>();
    }
    private void OnEnable()
    {
        Entity.OnPositionUpdate += SetVelocity;
        Entity.OnAttack += Attack;
    }
    private void OnDisable()
    {
        Entity.OnPositionUpdate -= SetVelocity;
        Entity.OnAttack -= Attack;
    }
    private void Attack()
    {
        Animator.SetTrigger("attack");
    }
    public void SetVelocity (float velocity)
    {
        Animator.SetFloat("velocity", velocity);
    }
}