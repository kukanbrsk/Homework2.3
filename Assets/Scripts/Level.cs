using UnityEngine;

public class Level : MonoBehaviour
{
    private Mediator _mediator;
    
    public void SetMediator(Mediator mediator) => _mediator = mediator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _mediator.PlayerHpChanged();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            _mediator.PlayerLevelUp();
        }
    }
}
