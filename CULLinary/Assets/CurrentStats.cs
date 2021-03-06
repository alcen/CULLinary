using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentStats : MonoBehaviour
{
    [SerializeField] private Text healthValue;
    [SerializeField] private Text rangeValue;
    [SerializeField] private Text meleeValue;
    [SerializeField] private Text critValue;

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (PlayerManager.playerData == null) return;

        healthValue.text = PlayerManager.playerData.currentHealth + "/" + PlayerManager.playerData.GetMaxHealth();
        rangeValue.text = PlayerManager.playerData.GetRangeDamage() + " dmg";
        meleeValue.text = PlayerManager.playerData.GetMeleeDamage() + " dmg";
        critValue.text = PlayerManager.playerData.GetCritRate() + "%";
    }
}
