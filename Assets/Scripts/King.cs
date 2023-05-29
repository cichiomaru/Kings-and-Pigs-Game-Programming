using UnityEngine;

public class King : MonoBehaviour, IMove, IJump, IDamageable
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private int currentHp;

    private Vector3 direction;

    // components
    private Rigidbody2D Rigidbody2D;

    private void Awake()
    {
        direction = new Vector3();
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        PositionUpdate();
    }

    public void Jump()
    {
        Vector3 jumpVector = new Vector3(Rigidbody2D.velocity.x, jumpPower, 0);
        Rigidbody2D.velocity = jumpVector;
    }

    public void SetDirection(float direction)
    {
        this.direction.x = direction;

        SetOrientation(direction);
    }

    public void PositionUpdate()
    {
        transform.position += direction * Time.deltaTime * speed;
    }

    public void SetOrientation(float direction)
    {
        if (direction > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (direction < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHp = damage > currentHp ? 0 : currentHp - damage;
    }
}
