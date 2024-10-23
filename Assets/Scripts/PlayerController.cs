using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*  Rigidbody2D _compRigidbody2D;
      float horizontal;
      float vertical;
      [SerializeField] float speed;

      private void Awake()
      {
          _compRigidbody2D = GetComponent<Rigidbody2D>();
      }

      private void Update()
      {
          horizontal = Input.GetAxisRaw("Horizontal");
          vertical = Input.GetAxisRaw("Vertical");

      }

      private void FixedUpdate()
      {
          _compRigidbody2D.velocity = new Vector2(speed * horizontal, speed * vertical);
      }
    */
    Vector2 PositionToMove;
    [SerializeField] float speedMove;
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, PositionToMove, speedMove * Time.deltaTime);
    }
    public void SetNewPosition(Vector2 newPosition)
    {
        PositionToMove = newPosition;
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Node")   
        {
            SetNewPosition(collision.GetComponent<NodeControll>().GetAdjacentNode().transform.position);
        } 
    }*/
}
