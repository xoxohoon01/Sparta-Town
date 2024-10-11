using UnityEngine;

public class TopDownRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        characterRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    
}
