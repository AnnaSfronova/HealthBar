using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected int _maxHealth;

    private void OnEnable()
    {
        _health.Changed += PrintHealth;
    }

    private void OnDisable()
    {
        _health.Changed -= PrintHealth;
    }

    private void Awake()
    {
        _maxHealth = _health.MaxValue;
    }

    public virtual void PrintHealth(int health) { }
}
