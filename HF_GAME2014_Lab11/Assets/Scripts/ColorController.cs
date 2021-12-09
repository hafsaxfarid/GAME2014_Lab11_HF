using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ColorController : MonoBehaviour
{
    public Color platformColor;

    private List<SpriteRenderer> tileSpriteRenderers;

    void Start()
    {
        tileSpriteRenderers = GetComponentsInChildren<SpriteRenderer>().ToList();
        setColor();
    }

    public void setColor()
    {
        foreach(var renderer in tileSpriteRenderers)
        {
            renderer.material.SetColor("_Color", platformColor);
        }
    }

    public void setColor(Color color)
    {
        foreach (var renderer in tileSpriteRenderers)
        {
            renderer.material.SetColor("_Color", color);
        }
    }
}
