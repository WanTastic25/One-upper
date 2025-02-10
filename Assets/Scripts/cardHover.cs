using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardHover : MonoBehaviour
{
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void OnMouseEnter()
    {
        transform.localScale = originalScale * 1.1f;
    }

    void OnMouseDown()
    {
        transform.localScale = originalScale * 1.05f;
    }

    void OnMouseExit()
    {
        transform.localScale = originalScale;
    }
}
