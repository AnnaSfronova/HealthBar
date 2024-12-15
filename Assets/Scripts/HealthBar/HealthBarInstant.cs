using UnityEngine;
using UnityEngine.UI;

public class HealthBarInstant : HealthBar
{
    [SerializeField] private Slider _slider;

    private void Start()
    {
        _slider.maxValue = _maxHealth;
        _slider.value = _maxHealth;
    }

    public override void PrintHealth(int health)
    {
        _slider.value = health;
    }
}
