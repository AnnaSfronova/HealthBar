using TMPro;
using UnityEngine;

public class HealthBarText : HealthBar
{
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        PrintHealth(_maxHealth);
    }

    public override void PrintHealth(int health)
    {
        _text.text = $"{health} / {_maxHealth}";
    }
}
