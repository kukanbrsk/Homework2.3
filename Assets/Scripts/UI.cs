using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI hpText;

    private Mediator _mediator;

    private void OnEnable() => restartButton.onClick.AddListener(RestartGame);

    private void OnDisable() => restartButton.onClick.RemoveListener(RestartGame);

    public void SetMediator(Mediator gameMediator) => _mediator = gameMediator;

    public void UpdateLevel(int level) => levelText.text = "Level: " + level;

    public void UpdateHP(int hp) => hpText.text = "HP: " + hp;

    private void RestartGame() => _mediator.RestartGame();

    public void Show() => restartButton.gameObject.SetActive(true);
    public void Hide() => restartButton.gameObject.SetActive(false);
}