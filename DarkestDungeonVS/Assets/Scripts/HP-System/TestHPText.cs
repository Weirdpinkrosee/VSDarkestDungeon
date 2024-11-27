using TMPro;
using UnityEngine;

public class TestHPText : MonoBehaviour
{
    public HPSystem health;  // References to the HPSystem component
    public TMP_Text textField;  // References to the TMP_Text component

    void Awake()
    {
        // Ensures health is set up properly.
        if (health == null)
        {
            health = FindObjectOfType<HPSystem>();  // Automatically finds the HPSystem component in the scene
        }

        if (textField == null)
        {
            textField = GetComponent<TMP_Text>();  // Makes sure the TMP_Text field is properly assigned
        }
    }

    void Update()
    {
        UpdateHealthDisplay();  // Continuously update the health display
    }

    void UpdateHealthDisplay()
    {
        // Update the UI text with the current HP value
        textField.text = "HP: " + health.hp.ToString();
    }
}