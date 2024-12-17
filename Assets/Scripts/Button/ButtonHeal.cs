public class ButtonHeal : ButtonBase
{
    private int _heal = 10;

    protected override void ChangeHealth() =>
        Health.TakeHeal(_heal);    
}
