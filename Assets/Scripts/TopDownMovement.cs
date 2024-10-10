using Unity.Burst;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D movementRigidbody;
    private Animator animator;

    private Vector2 movementDirection = Vector2.zero;
    [SerializeField] private float moveSpeed = 5f;

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        
        direction = direction * moveSpeed;
        movementRigidbody.velocity = direction;
        
    }

    private void ApplyAnimation()
    {
        if (movementRigidbody.velocity.magnitude != 0) animator.SetBool("isWalk", true);
        else animator.SetBool("isWalk", false);
    }

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    private void Update()
    {
        ApplyAnimation();
    }

}
