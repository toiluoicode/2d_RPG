using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMana : MonoBehaviour
{
    [SerializeField] private PlayerStatus playerStatus;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            UseMana(5f);
        }
    }
    public void UseMana(float amout)
    {
        if (playerStatus.mana >= 0)
        {
           playerStatus.mana =  Mathf.Max(playerStatus.mana -= amout, 0);
        }
    }
}
