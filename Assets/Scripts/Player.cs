public class Player 
{
    private int _level = 1;
    private int _startLevel;
    private int _hp = 20;
    private int _startHp;
    private int _bonusHp = 10;

    public int Level => _level;
    public int Hp => _hp;

    public Player()
    {
        _startHp = _hp;
        _startLevel = _level;
    }

    public void LevelUp()
    {
        _level++;
        _hp += _bonusHp;
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;
    }

    public void Reset()
    {
        _level = _startLevel;
        _hp = _startHp;
    }
}
