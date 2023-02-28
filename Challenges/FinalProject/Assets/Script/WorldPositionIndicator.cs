using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WorldPositionIndicator : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    private RectTransform rectTransform;
    private Image image;
    [SerializeField] private TMP_Text text;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        image = GetComponent<Image>();
    }

    void Update()
    {
        showIndicator();
    }

    private void showIndicator()
    {
        if (GameManager.instance.indicatorTargetTransform)
        {
            targetTransform = GameManager.instance.indicatorTargetTransform;
        }
        Debug.Log(targetTransform.name);
        var screenPoint = Camera.main.WorldToScreenPoint(targetTransform.position);
        rectTransform.position = screenPoint;

        var viewportPoint = Camera.main.WorldToViewportPoint(targetTransform.position);
        var distanceFromCenter = Vector2.Distance(viewportPoint, Vector2.one * 0.5f);

        var show = distanceFromCenter < 0.3f && GameManager.instance.onSight;
        // Debug.Log($"distance {distanceFromCenter < 0.3f}");
        // Debug.Log($"onsight {GameManager.instance.onSight}");
        // Debug.Log("show" + show);
        image.enabled = show;
        text.enabled = show;


    }
}
