using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerStatus", menuName = "Scriptable/PlayerStatus")]
public class PlayerStatus : ScriptableObject
{
    [Header("Config")]
    public int Level;

    [Header("Health")]
    public float health;
    public float maxHealth;

    [Header("Mana")]
    public float mana;
    public float maxMana;


    [Header("EXP")]

    public float currentEXP;
    public float nextLeveExp;
    public float InitialNextLevelExp;
    [Range(1f, 100f)] public float ExpMultiplier;
    public void ResetPlayer()
    {
        health = maxHealth;
        mana = maxMana;
        Level = 1;
        currentEXP = 0;
        nextLeveExp = InitialNextLevelExp;
    } 
}
