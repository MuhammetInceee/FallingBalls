using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 10f;
    private Rigidbody _rb;
    private Renderer _renderer;

    void Awake()
    {
        GetReferences();
        InitVariables();
        SetColor();
        CreateAnim();
    }


    void FixedUpdate() 
    {
        if (_rb.velocity.magnitude > maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * maxSpeed;
        }
    }
    
    private void InitVariables()
    {
        
    }

    private void GetReferences()
    {
        _rb = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
    }

    private void SetColor()
    {
        Color randomColor = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1f);
        
        _renderer.material.color = randomColor;
    }

    private void CreateAnim()
    {
        transform.DOScale(Vector3.one * 1.5f, 0.4f);
    }
}
