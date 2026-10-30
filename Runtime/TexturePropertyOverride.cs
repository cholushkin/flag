using UnityEngine;

public class TexturePropertyOverride : MonoBehaviour
{
    public Renderer Renderer;
    public Texture2D TextureOverride;
    public string PropertyReferenceName;

    private void Awake()
    {
        ApplyTexture(TextureOverride);
    }

    public void ApplyTexture(Texture2D texture)
    {
        MaterialPropertyBlock block = new MaterialPropertyBlock();
        Renderer.GetPropertyBlock(block);
        block.SetTexture(PropertyReferenceName, texture);
        Renderer.SetPropertyBlock(block);
    }
}
