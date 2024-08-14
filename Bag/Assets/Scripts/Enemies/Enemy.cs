using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected int _health;
    [SerializeField] protected float _minAttackDistance = 5f;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected float _attackInterval;
    [SerializeField] protected Player _target;
    [SerializeField] protected Animator _animator;
    
    protected bool _isWalking; 
    protected float _currentAttackInterval;

    public void SetTarget(Player player)
    {
        _target = player;
    }

    protected virtual void TakeDamage(int decreaseDamage)
    {
        _health -= decreaseDamage;
    }

    protected abstract void MoveToTarget();

    protected abstract void Attack();

    protected virtual void DecreaseTimer()
    {
        _currentAttackInterval -= 1f * Time.deltaTime;
        _currentAttackInterval = Mathf.Clamp(_currentAttackInterval, 0f, Mathf.Infinity);
    }
}