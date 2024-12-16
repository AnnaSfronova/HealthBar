public class ButtonAttack : ButtonBase
{
    private int _damage = 10;

    protected override void ChangeHealth() =>
        _health.TakeDamage(_damage);    
}
