using PlayerController;
using UnityEngine;

namespace EnemySystem
{
    public abstract class Enemy : MonoBehaviour
    {
        #region Fields
    [SerializeField] protected int _health;
    [SerializeField] protected float _minAttackDistance = 5f;
    [SerializeField] protected float _moveSpeed;
    [SerializeField] protected float _attackInterval;
    [SerializeField] protected Player _target;
    [SerializeField] protected Animator _animator;
    
    protected bool _isWalking; 
    protected float _currentAttackInterval;
    #endregion
    
        #region Virtual Methods
        public void SetTarget(Player player)
        {
            _target = player;
        }
    
        protected virtual void TakeDamage(int decreaseDamage)
        {
            _health -= decreaseDamage;
        }
        protected virtual void DecreaseTimer()
        {
            _currentAttackInterval -= 1f * Time.deltaTime;
            _currentAttackInterval = Mathf.Clamp(_currentAttackInterval, 0f, Mathf.Infinity);
        }
        #endregion
    
        #region Abstraction Methods
        protected abstract void MoveToTarget();
    
        protected abstract void Attack();
        #endregion
    }
}