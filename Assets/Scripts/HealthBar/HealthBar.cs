using UnityEngine;

public abstract class HealthBar : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected void OnEnable()
    {
        Health.Changed += PrintHealth;
    }

    private void OnDisable()
    {
        Health.Changed -= PrintHealth;
    }

    protected virtual void PrintHealth(int health) { }
}
