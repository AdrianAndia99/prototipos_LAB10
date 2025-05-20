using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer _renderer;
    private MaterialPropertyBlock _propBlock;
    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _propBlock = new MaterialPropertyBlock();
    }
    void Update()
    {
      // _renderer.material.color = GetRandomColor();
      //  _renderer.material.SetColor("_Color", GetRandomColor());
//
     _renderer.GetPropertyBlock(_propBlock);
     _propBlock.SetColor("_Color",  GetRandomColor());
    
     _renderer.SetPropertyBlock(_propBlock);
    }
    private Color GetRandomColor()
    {
        return new Color(
        r: Random.Range(0f, 1f),
        g: Random.Range(0f, 1f),
        b: Random.Range(0f, 1f));
    }
    


}
