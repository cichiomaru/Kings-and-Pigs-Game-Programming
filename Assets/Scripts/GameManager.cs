using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Vector2 gravity;

    private float time;

    private void Awake()
    {
        Physics2D.gravity = gravity;
    }

    private void Update()
    {
        time -= Time.deltaTime;
    }
}
