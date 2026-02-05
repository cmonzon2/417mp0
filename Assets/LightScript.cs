using UnityEngine;
using UnityEngine.InputSystem;

public class LightScript : MonoBehaviour
{

    public Light light;
    public InputActionReference action;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.tabKey.wasPressedThisFrame) {
            light.color = Color.blue;
        }
    }

    void OnEnable()
    {
        action.action.Enable();
        action.action.performed += OnSwitch;
    }

    void OnDisable()
    {
        action.action.performed -= OnSwitch;
        action.action.Disable();
    }

    private void OnSwitch(InputAction.CallbackContext context)
    {
        Switch();
    }

    private void Switch()
    {
        light.color = Color.blue;
    }
}
