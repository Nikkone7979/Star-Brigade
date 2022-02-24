using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float movement;
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] float speed = 10.0f;
    [SerializeField] bool isFacingRight = true;
    [SerializeField] float randomMovement = 0;
    int interval = 1;
    float nextTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (rigid == null)
            rigid = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame; best for user input
    void Update()
    {
        movement = Input.GetAxis("Horizontal");

        if (Time.time >= nextTime)
        {

            //do something here every interval seconds
            randomMovement = Random.Range(-0.4f, 0.4f);

            nextTime += interval;

        }


    }

    //FixedUpdate is called potentially multiple times per frame; best for physics and movement
    private void FixedUpdate()
    {
        rigid.velocity = new Vector2(randomMovement * speed, rigid.velocity.y);
        if (movement < 0 && isFacingRight || movement > 0 && !isFacingRight)
            Flip();


    }

    private void Flip()
    {


        transform.Rotate(0, 180, 0);
        isFacingRight = !isFacingRight;

    }





}
