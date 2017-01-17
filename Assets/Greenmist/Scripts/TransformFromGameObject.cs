using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TransformFromGameObject : MonoBehaviour
{
    [SerializeField] private RectTransform rectTransform;
    [SerializeField] private Alignment alignment;

    private RectTransform alignedTransform;

    private void Start()
    {
        alignedTransform = (RectTransform) transform;
    }

    private void Update()
    {
        switch (alignment)
        {
            case Alignment.TOP:
                transform.position = new Vector3(rectTransform.position.x, rectTransform.position.y + rectTransform.rect.height, transform.position.z);
                break;

            case Alignment.BOTTOM:
                transform.position = new Vector3(rectTransform.position.x, rectTransform.position.y - rectTransform.rect.height - alignedTransform.rect.height, transform.position.z);
                break;

            case Alignment.LEFT:
                transform.position = new Vector3(rectTransform.position.x - alignedTransform.rect.width, transform.position.y, transform.position.z);
                break;

            case Alignment.RIGHT:
                transform.position = new Vector3(rectTransform.position.x + rectTransform.rect.width, transform.position.y, transform.position.z);
                break;
        }
    }

    private enum Alignment
    {
        TOP,
        BOTTOM,
        LEFT,
        RIGHT
    }
}
