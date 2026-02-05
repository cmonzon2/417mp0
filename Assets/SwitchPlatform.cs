using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchPlatform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public InputActionReference action;
    public Transform player;
    private int onMainPlat = 1;
    void Start()
    {
        // test
    }

    // Update is called once per frame
    void Update()
    {
        // if (Keyboard.current != null && Keyboard.current.spaceKey.wasPressedThisFrame) {
        //     Switch();
        // }
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
        onMainPlat *= -1;

        if (onMainPlat > 0)
        {
            player.position = new Vector3(0.63671f, -0.25f, -2.46874f);
        }
        else
        {
            player.position = new Vector3(-0.25f, 0f, 30f);
        }
    }
}
