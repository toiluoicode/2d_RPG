using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEXP : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private PlayerStatus playerStatus;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            AddExp(5);
        }
    }
    public void AddExp(float amout)
    {
        playerStatus.currentEXP += amout;
        Debug.Log(playerStatus.currentEXP);
        while (playerStatus.currentEXP >= playerStatus.nextLeveExp)
        {
            playerStatus.currentEXP -= playerStatus.nextLeveExp;
            NextLevel();
        }
    }
    public void NextLevel()
    {
        playerStatus.Level++;
        float currentExpRequired = playerStatus.nextLeveExp;
        float newNextLevel = Mathf.Round(
            currentExpRequired + playerStatus.nextLeveExp * (playerStatus.ExpMultiplier / 100)
            );
        playerStatus.nextLeveExp = newNextLevel;
    }
}
