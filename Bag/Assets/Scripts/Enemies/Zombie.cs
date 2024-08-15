using UnityEngine;

namespace EnemySystem
{
    public class Zombie : Enemy
    {
        private void Update()
        {
            DecreaseTimer();
            MoveToTarget();
        }
    
        protected override void MoveToTarget()
        {
            Vector2 direction = _target.transform.position - transform.position;
            float distance = Vector2.Distance(_target.transform.position, transform.position);
    
            if (distance <= _minAttackDistance)
            {
                _isWalking = false;
                Attack();
            }
            else
            {
                _isWalking = true;
                _animator.SetBool("Walk", true);
                transform.position += new Vector3(direction.normalized.x, 0f, 0f) * _moveSpeed * Time.deltaTime;
            }
        }
    
        protected override void Attack()
        {
            if (_currentAttackInterval <= 0f)
            {
                _animator.SetBool("Walk", false);
                _animator.SetTrigger("Attack");
                _currentAttackInterval = _attackInterval;
            }
        }
    
        protected override void DecreaseTimer()
        {
            if (_isWalking == false)
            {
                base.DecreaseTimer();
            }
        }
    }
}