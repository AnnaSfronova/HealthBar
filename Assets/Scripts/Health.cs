using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxValue;

    public event Action<int> Changed;

    public int Value { get; private set; }
    public int MaxValue => _maxValue;

    private void Awake()
    {
        Value = _maxValue;
    }

    public void TakeDamage(int damage)
    {
        Value -= damage;

        if (Value <= 0)
        {
            Value = 0;
        }

        Changed?.Invoke(Value);
    }

    public void TakeHeal(int heal)
    {
        Value += heal;
        ClampHeal();

        Changed?.Invoke(Value);
    }

    private void ClampHeal()
    {
        if (Value > _maxValue)
            Value = _maxValue;
    }
}
