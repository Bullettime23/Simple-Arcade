using SimpleFPS;
using UnityEngine;

[RequireComponent(typeof(MouseLook))]
public class WinScreen : MonoBehaviour
{
    [SerializeField] private MouseLook mouseLook;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        mouseLook.SetCursorLock(false);
    }
}
