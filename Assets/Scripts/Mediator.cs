using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] private Level level;
    [SerializeField] private UI ui;
    
    private Player _player;
    
    private void Start()
    {
        level.SetMediator(this);
        ui.SetMediator(this);
        _player = new Player();
        UpdateUI();
    }

    public void PlayerLevelUp()
    {
        if (_player.Hp == 0) return;
        _player.LevelUp();
        UpdateUI();
    }

    public void PlayerHpChanged()
    {
        if (_player.Hp == 0) return;
        _player.TakeDamage(10);
        ui.UpdateHP(_player.Hp);
        if (_player.Hp > 0) return;
        ui.Show();
    }

    private void UpdateUI()
    {
        ui.UpdateLevel(_player.Level);
        ui.UpdateHP(_player.Hp);
    }
    public void RestartGame()
    {
        _player.Reset();
        ui.Hide();
        UpdateUI();
    }
}