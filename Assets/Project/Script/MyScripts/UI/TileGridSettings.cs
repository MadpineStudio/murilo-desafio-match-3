using UnityEngine;
using UnityEngine.UI;

public class TileGridSettings : MonoBehaviour
{
    [SerializeField] private RectTransform canvas;
    private GridLayoutGroup _gridLayoutGroup;

    private void Awake()
    {
        _gridLayoutGroup = GetComponent<GridLayoutGroup>();
    }
    private void Start()
    {
        TileSizeBasedOnCanvas();
    }
    private void TileSizeBasedOnCanvas()
    {
        Vector3 canvasRect = canvas.rect.size;
        float size = canvasRect.y * .1f;
        _gridLayoutGroup.cellSize = new Vector2(size, size);
    }    
}
