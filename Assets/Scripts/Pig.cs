using UnityEngine;

public class Pig : MonoBehaviour, IDamageable
{
    [SerializeField] private int currentHp;

    public void TakeDamage(int damage)
    {
        currentHp = damage > currentHp ? 0 : currentHp - damage;
    }
}
