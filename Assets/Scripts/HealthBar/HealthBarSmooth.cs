using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSmooth : HealthBar
{
    [SerializeField] private Slider _slider;

    private Coroutine _coroutine;
    private float _speed = 0.2f;

    private new void OnEnable()
    {
        base.OnEnable();

        _slider.maxValue = Health.MaxValue;
        _slider.value = Health.MaxValue;
    }

    protected override void PrintHealth(int health)
    {
        SetCoroutine(health);
    }

    private void SetCoroutine(int health)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
            _coroutine = null;
        }

        _coroutine = StartCoroutine(PrintHealthSmooth(health));
    }

    private IEnumerator PrintHealthSmooth(int health)
    {
        while (_slider.value != health)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, health, _speed);

            yield return null;
        }
    }
}
