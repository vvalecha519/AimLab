using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public float sizeMultiplier = 2f; // multiplier for object size
    public float velocity = 0f; // speed of object movement
    public Globals.DifficultySettings m_settings;
    private Vector3 moveDir;
    private const float leftBound = -6.0f;
    private const float rightBound = 6.0f;
    // private Rigidbody rb; // reference to Rigidbody component

    void Start()
    {

        // Get the Rigidbody component of the object
        //rb = GetComponent<Rigidbody>();

        // Double the size of the object
        m_settings = Globals.getDifficultySettings();
        sizeMultiplier = (float) m_settings.SizeMultiplier;
        transform.localScale *= sizeMultiplier;

        // determine starting direciton of object
        if (Random.value < 0.5f)
        {
            moveDir = Vector3.forward;
        }
        else
        {
            moveDir = Vector3.back;
        }

        // Give the object a forward velocity
        //rb.velocity = transform.forward * velocity;
    }

    // Update is called once per frame
    void Update()
    {
        float moveSpeed = m_settings.MoveSpeed;
        if (moveSpeed > 0)
        {
            // move sphere
            if (transform.position.z <= leftBound)
            {
                moveDir = Vector3.forward;
            }
            else if (transform.position.z >= rightBound)
            {
                moveDir = Vector3.back;
            }
            transform.Translate(moveDir * moveSpeed * Time.deltaTime);
        }
    }

}
