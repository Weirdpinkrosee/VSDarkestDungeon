using TMPro;
using UnityEngine;

public class TestHPText : MonoBehaviour
{
    public HPSystem health;  // References to the HPSystem component
    public TMP_Text textField;  // References to the TMP_Text component


    public void HealthCheck()
    {
        if (health.hp <= 0)
        {
            health.hp = 0;
        }
    }
    public void UpdateHealthDisplay()
    {
        // Update the UI text with the current HP value
        textField.text = "HP: " + health.hp.ToString();
    }
}