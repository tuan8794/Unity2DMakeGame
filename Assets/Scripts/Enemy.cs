using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance = 5f;
    private Vector3 startPos;
    private bool movingRight = true; 

    //public float speed = 2f;
    //public float moveDistance = 3f;
    //private Vector3 startPosition;
    //private bool movingRight = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float leftBound = startPos.x - distance;
        float rightBound = startPos.x + distance;
        float movement = speed * Time.deltaTime;

        if (movingRight)
        {
            transform.Translate(Vector2.right * movement);
            if (transform.position.x >= rightBound)
            {
                movingRight = false;
                Flip();
            }
        }
        else
        {
            transform.Translate(Vector2.left * movement);
            if (transform.position.x <= leftBound)
            {
                movingRight = true;
                Flip();
            }
        }
        
    }
        //if (movingRight)
        //{
        //    transform.position += Vector3.right * movement;

        //    if (transform.position.x >= rightBound)
        //    {
        //        movingRight = false;
        //        Flip();
        //    }
        //}
        //else
        //{
        //    transform.position += Vector3.left * movement;

        //    if (transform.position.x <= leftBound)
        //    {
        //        movingRight = true;
        //        Flip();
        //    }
        //}

        void Flip()
        {
            Vector3 scaler = transform.localScale;
            scaler.x *= -1;
            transform.localScale = scaler;
        }
    }


