using UnityEngine;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;           // Ссылка на скрипт с жизнями
    public TextMeshProUGUI healthText;          // UI текст

    void Update()
    {
        if (playerHealth != null && healthText != null)
        {
            healthText.text = "Health: " + playerHealth.GetCurrentHealth().ToString();
        }
    }
}