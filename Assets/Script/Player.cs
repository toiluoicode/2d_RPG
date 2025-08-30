using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Config")]
    [SerializeField]
    private PlayerStatus playerStatus;
    public PlayerStatus Status => playerStatus;
    private PlayerAnimation playerAnimation;
    void Awake()
    {
        playerAnimation = GetComponent<PlayerAnimation>();
    }
    void Update()
    {

    }
    public void ResetPlayer()
    {
        playerStatus.ResetPlayer();
        playerAnimation.ResetPlayer();
    }
}