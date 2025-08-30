using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private readonly int moveX = Animator.StringToHash("MoveX");
    private readonly int moveY = Animator.StringToHash("MoveY");
    private readonly int isMoving = Animator.StringToHash("isMoving");
    private readonly int isDead = Animator.StringToHash("Dead");

    private readonly int Revive = Animator.StringToHash("Revive");
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetMovingAnimation(bool value)
    {
        animator.SetBool(isMoving, value);
    }
    public void SetMoveAnimation(Vector2 vector)
    {
        animator.SetFloat(moveX, vector.x);
        animator.SetFloat(moveY, vector.y);
    }
    public void SetDeadAnimation()
    {
        animator.SetTrigger(isDead);
    }
    public void ResetPlayer()
    {
        animator.SetTrigger(Revive);
        SetMoveAnimation(Vector2.down);
        
    }
}
