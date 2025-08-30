using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("Status")]
    [SerializeField] private PlayerStatus playerStatus;

    [Header("Bar")]
    [SerializeField] private Image healBar;
    [SerializeField] private Image manaBar;
    [SerializeField] private Image expBar;

    [Header("Text")]
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI heathText;
    [SerializeField] private TextMeshProUGUI manaText;
    [SerializeField] private TextMeshProUGUI expText;
    void Update()
    {
        UpdatePlayer();
    }
    public void UpdatePlayer()
    {
        healBar.fillAmount =  Mathf.Lerp(healBar.fillAmount, (playerStatus.health / playerStatus.health), 10f*Time.deltaTime); 
        manaBar.fillAmount =  Mathf.Lerp(manaBar.fillAmount, (playerStatus.mana / playerStatus.maxMana), 10f*Time.deltaTime); 
        expBar.fillAmount =  Mathf.Lerp(expBar.fillAmount, (playerStatus.currentEXP / playerStatus.nextLeveExp), 10f*Time.deltaTime); 
    
        levelText.text  = $"Level {playerStatus.Level}";
        heathText.text  = $"{playerStatus.health}/{playerStatus.maxHealth}";
        manaText.text   = $"{playerStatus.mana}/{playerStatus.maxMana}";
        expText.text    = $"{playerStatus.currentEXP}/{playerStatus.nextLeveExp}";
    }
}
