using UnityEngine;

public class Zombie : Enemy
{
    private void Start()
    {
        
    }

    private void Update()
    {
        MoveToTarget();
    }

    protected override void MoveToTarget()
    {
        Vector2 direction = _target.transform.position - transform.position;
        float distance = Vector2.Distance(_target.transform.position, transform.position);

        if (distance <= _minAttackDistance)
        {
            _animator.SetBool("Walk", false);
        }
        else
        {
            _animator.SetBool("Walk", true);
            transform.position += new Vector3(direction.normalized.x, 0f, 0f) * _moveSpeed * Time.deltaTime;
        }
    }
}
