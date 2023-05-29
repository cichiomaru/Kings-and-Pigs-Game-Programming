using UnityEngine;

public class Pig : MonoBehaviour, IDamageable
{
    //[SerializeField] private int currentHp;
    [SerializeField] private Health health;

    public void TakeDamage(int damage)
    {
        //currentHp = damage > currentHp ? 0 : currentHp - damage;
        health.Reduce(damage);
    }

    internal Health GetHealth()
    {
        return health;
    }
}
