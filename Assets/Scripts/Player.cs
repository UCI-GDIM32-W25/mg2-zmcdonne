using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
[SerializeField] private Collider2D _collider;
[SerializeField] private Rigidbody2D _rigidbody;
[SerializeField] private float _jump;

private bool _isGrounded = true;


private void OnCollisionEnter2D (Collision2D collider)
{
    {
      string tag = collider.gameObject.tag;
        if (tag.Equals("Ground"))
        {
            _isGrounded = true;
        }
    }
}
void Update()
{
  if (Input.GetKey(KeyCode.UpArrow) && _isGrounded)
        {
            _isGrounded = false;

            _rigidbody.velocity = new Vector2(
                _rigidbody.velocity.x,
                _jump
            );
        }
    
}
}
