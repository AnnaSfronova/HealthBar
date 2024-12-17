public class ButtonAttack : ButtonBase
{
    private int _damage = 10;

    protected override void ChangeHealth() =>
        Health.TakeDamage(_damage);    
}
