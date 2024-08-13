using UnityEngine;

public class PlayerAnimationStates : MonoBehaviour
{
    [SerializeField] private bool _isWalkingNow;
    [SerializeField] private Animator _playerAnimator;

    private void Start()
    {
        EventManager.OnPlayerMove += WalkState;
        EventManager.OnPlayerAttack += AttackState;
    }

    public void AttackState()
    {
        _playerAnimator.SetTrigger("Attack");
    }

    public void WalkState(bool state)
    {
        _playerAnimator.SetBool("Walk", state);
        _isWalkingNow = state;
    }

    public bool GetWalkState()
    {
        return _isWalkingNow;
    }
}
