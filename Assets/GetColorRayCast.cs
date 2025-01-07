using UnityEngine;

public class GetColorWithRaycast : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // On left mouse click
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Renderer renderer = hit.collider.GetComponent<Renderer>();
                MeshCollider meshCollider = hit.collider as MeshCollider;

                if (renderer != null && renderer.material.mainTexture != null && meshCollider != null)
                {
                    Texture2D texture = (Texture2D)renderer.material.mainTexture;

                    // Get UV coordinates of the hit point
                    Vector2 uv = hit.textureCoord;

                    // Convert UV coordinates to texture pixels
                    int x = Mathf.FloorToInt(uv.x * texture.width);
                    int y = Mathf.FloorToInt(uv.y * texture.height);

                    // Get the color from the texture
                    Color color = texture.GetPixel(x, y);
                    Debug.Log($"Color at hit point: {color}");
                }
                else
                {
                    Debug.Log("No texture found at the hit point!");
                }
            }
        }
    }
}
