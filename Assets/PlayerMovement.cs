using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    private float walkSpeed = 2.2f;
    private float runSpeed = 4f;
    private float turnSpeed = 180f;

    void Start() {
        controller = GetComponent<CharacterController>();
        controller.stepOffset = 2.0F;
    }

    void Update() {
        Vector3 movDir;
        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;
        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
        movDir = transform.forward * Input.GetAxis("Vertical") * currentSpeed;
        controller.Move(movDir * Time.deltaTime - Vector3.up * 0.1f);
    }
}
