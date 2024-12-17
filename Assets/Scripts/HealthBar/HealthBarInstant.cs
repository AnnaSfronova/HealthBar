using UnityEngine;
using UnityEngine.UI;

public class HealthBarInstant : HealthBar
{
    [SerializeField] private Slider _slider;

    private new void OnEnable()
    {
        base.OnEnable();

        _slider.maxValue = Health.MaxValue;
        _slider.value = Health.MaxValue;
    }

    protected override void PrintHealth(int health)
    {
        _slider.value = health;
    }
}
