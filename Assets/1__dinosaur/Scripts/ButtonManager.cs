using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public VariableJoystick joy;
    public VariableJoystick rotY;
    
    public GameObject cam;
    public float cameraSpeed = 4f;
    public float rotationSpeed = 2f;

    void Update()
    {
        float horizontalInput = joy.Horizontal;
        float verticalInput = joy.Vertical;

        Vector3 moveDirection = new Vector3(horizontalInput, 0f, verticalInput);
        Vector3 desiredPosition = cam.transform.position + moveDirection * cameraSpeed * Time.deltaTime;

        cam.transform.position = desiredPosition;

        float rotYInput = rotY.Horizontal;
        float rotXInput = rotY.Vertical;

        Vector3 currentRotation = cam.transform.eulerAngles;
        
        currentRotation.x -= rotXInput * rotationSpeed;
        currentRotation.y += rotYInput * rotationSpeed;
        cam.transform.eulerAngles = currentRotation;
    }
}
