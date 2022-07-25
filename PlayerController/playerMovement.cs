using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace player
{
    public class playerMovement : MonoBehaviour
    {
        public bool habitación;
        public Rigidbody2D rb;
        private bool aPressed, dPressed;
        public float moveSpeed;
        public AudioSource Walk;
        public status stats;
        public float buff, debuff;

        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            if (!habitación)
            {
                if (!stats.hasEat)
                {
                    moveSpeed = debuff;
                }
                if (stats.hasEat && stats.hasSugar)
                {
                    moveSpeed = buff;
                }
            }
        }

        private void Update()
        {
            aPressed |= Input.GetKeyDown(KeyCode.A);
            dPressed |= Input.GetKeyDown(KeyCode.D);
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if (!Walk.isPlaying)
                {
                    Walk.Play();
                }
                else
                {
                   Walk.Stop();
                }
            }
        }
        private void FixedUpdate()
        {
            if(aPressed || dPressed)
            {
                Movement();
            }
        }
        private void Movement()
        {
            float xMov = Input.GetAxisRaw("Horizontal");
            rb.velocity = new Vector2(xMov, rb.velocity.y) * moveSpeed;
            if((xMov > 0 || xMov < 0) && !Walk.isPlaying)
            {
                Walk.Play();
            }
            else
            {
                Walk.Stop();
            }
        }
    }
}