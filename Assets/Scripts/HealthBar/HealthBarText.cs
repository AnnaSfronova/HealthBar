using TMPro;
using UnityEngine;

public class HealthBarText : HealthBar
{
    [SerializeField] private TextMeshProUGUI _text;

    private new void OnEnable()
    {
        base.OnEnable();

        PrintHealth(Health.MaxValue);
    }

    protected override void PrintHealth(int health)
    {
        _text.text = $"{health} / {Health.MaxValue}";
    }
}
