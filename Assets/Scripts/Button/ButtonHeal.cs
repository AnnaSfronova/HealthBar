public class ButtonHeal : ButtonBase
{
    private int _heal = 10;

    protected override void ChangeHealth() =>
        _health.TakeHeal(_heal);    
}
