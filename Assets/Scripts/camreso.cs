using UnityEngine;

[RequireComponent(typeof(Camera))]
public class VirtualResolution : MonoBehaviour
{
    public int targetWidth = 704;
    public int targetHeight = 528;

    private RenderTexture renderTexture;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();

        renderTexture = new RenderTexture(targetWidth, targetHeight, 16);
        renderTexture.filterMode = FilterMode.Point; // no blurring

        cam.targetTexture = renderTexture;

        // Show it fullscreen using a GUI draw
        RenderTexture.active = renderTexture;
    }

    void OnGUI()
    {
        GUI.depth = 0;
        GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), renderTexture, ScaleMode.ScaleToFit, false);
    }
}
