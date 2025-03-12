using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // ---------- [Variables] ----------

    [SerializeField] private float speed = 0f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector2 movement;

    // ----------------------------------

    // ---------- [Methods] ----------

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

}
