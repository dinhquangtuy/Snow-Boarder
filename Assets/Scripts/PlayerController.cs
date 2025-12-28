using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D _rb2d;
    [SerializeField] private float torqueAmount;
    void Start() {
        _rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        float moveInput = Input.GetAxisRaw("Horizontal");
        _rb2d.AddTorque(-moveInput * torqueAmount);
    }
}
