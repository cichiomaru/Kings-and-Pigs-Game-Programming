using System;
using UnityEngine;

[Serializable]
public class Health
{
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;

    public int GetCurrentHealth()
    {
        return currentHealth;
    }
    public int GetMaxHealth()
    {
        return maxHealth;
    }
    public float GetPercentage()
    {
        return (float)currentHealth / (float)maxHealth;
    }
    internal void Reduce(int damage)
    {
        currentHealth = damage > currentHealth ? 0 : currentHealth - damage;
    }
    public void Gain(int value)
    {
        currentHealth = currentHealth + value > maxHealth ? maxHealth : currentHealth + value;
    }
}