using UnityEngine;

public class ColorPropertyOverride : MonoBehaviour
{
    public Renderer Renderer;
    public Color ColorOverride;
    public string PropertyReferenceName;

    private void Awake()
    {
        ApplyColor(ColorOverride);
    }

    public void ApplyColor(Color color)
    {
        MaterialPropertyBlock block = new MaterialPropertyBlock();
        Renderer.GetPropertyBlock(block);
        block.SetColor(PropertyReferenceName, color);
        Renderer.SetPropertyBlock(block);
    }
}
