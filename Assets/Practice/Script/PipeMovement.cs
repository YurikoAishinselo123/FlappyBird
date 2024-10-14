using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 2f;  // How fast the pipes move

    private void Update()
    {
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);  // Move pipes to the left

        if (transform.position.x < -10f)  // If the pipe moves off the screen, destroy it
        {
            
            Destroy(gameObject);
        }
    }
}
