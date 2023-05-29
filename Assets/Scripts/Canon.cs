using System;
using System.Collections;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bomb;
    [SerializeField] private Transform bombAnchor;

    private IEnumerator Start()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(1);
        }
    }

    private void Shoot()
    {
        Bomb _bomb = Instantiate(bomb, bombAnchor.position, Quaternion.identity).GetComponent<Bomb>();

        _bomb.SetVelocity(GetDirection() * speed);
    }

    private Vector2 GetDirection()
    {
        Vector2 direction = new Vector2();
        direction.x = transform.rotation.eulerAngles.y == 0 ? 1 : -1;
        direction.y = 1;

        return direction;
    }
}
