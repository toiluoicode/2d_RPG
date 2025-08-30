using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{
    [Header("Config")]
    [SerializeField]
    private PlayerStatus playerStatus;
    private PlayerAnimation playerAnimation;
    public void TakeDame(float amout)
    {
        playerStatus.health = Mathf.Max( playerStatus.health -= amout, 0);
        if (playerStatus.health <= 0)
        {
            PlayerDead();
        }
    }
    void Awake()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
    }
    public void PlayerDead()
    {
        playerAnimation.SetDeadAnimation();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDame(1f);
        }
    }
}
