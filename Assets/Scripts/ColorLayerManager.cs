using UnityEngine;
using UnityEngine.InputSystem;

public class ColorLayerManager : MonoBehaviour
{
    public GameObject[] redObjects = new GameObject[0];
    public GameObject[] blueObjects = new GameObject[0];

    private bool redLayerActive = true;

    private void Start()
    {
        ApplyLayer();
    }

    private void Update()
    {
        if (Keyboard.current == null)
        {
            return;
        }

        if (Keyboard.current.qKey.wasPressedThisFrame ||
            Keyboard.current.eKey.wasPressedThisFrame)
        {
            redLayerActive = !redLayerActive;
            ApplyLayer();
        }
    }

    private void ApplyLayer()
    {
        foreach (GameObject item in redObjects)
        {
            item.SetActive(redLayerActive);
        }

        foreach (GameObject item in blueObjects)
        {
            item.SetActive(!redLayerActive);
        }

        if (Camera.main != null)
        {
            Camera.main.backgroundColor = redLayerActive
                ? new Color(0.35f, 0.12f, 0.15f)
                : new Color(0.10f, 0.20f, 0.38f);
        }
    }
}