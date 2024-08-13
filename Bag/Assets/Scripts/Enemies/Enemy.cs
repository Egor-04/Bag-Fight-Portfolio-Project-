using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected int _health;
    [SerializeField] protected float _minAttackDistance = 5f;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected float _attackSpeed;
    [SerializeField] protected Player _target;
    [SerializeField] protected Animator _animator;

    public void SetTarget(Player player)
    {
        _target = player;
    }

    protected virtual void TakeDamage(int decreaseDamage)
    {
        _health -= decreaseDamage;
    }

    protected abstract void MoveToTarget();
}