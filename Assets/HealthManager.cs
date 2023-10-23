using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth = 100f;
    public Image healthBar;
    public AudioManager audio;
    
    void Start()
    {
     audio.Play("music");
    }

    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
        audio.Play("hurt");
        healthBar.fillAmount = playerHealth / 100f;
    }
    public void Heal(float healingAmount)
    {
        playerHealth += healingAmount;
        playerHealth = Mathf.Clamp(playerHealth, 0, 100);
        healthBar.fillAmount = playerHealth / 100f;
    }
}
