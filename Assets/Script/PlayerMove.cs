using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private PlayerInput playerInput;
    private PlayerAnimation playerAnimation;
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 move;
    private Player player;
    void Awake()
    {
        playerInput = new PlayerInput();

    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<PlayerAnimation>();
        player = GetComponent<Player>();
    }
    void OnEnable()
    {
        playerInput.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        ReadMoveVector();
    }
    void FixedUpdate()
    {
        Move();
    }
    public void Move()
    {
        if (player.Status.health <= 0) return;
        rb.MovePosition(rb.position + move * Time.deltaTime * speed);
    }
    public void ReadMoveVector()
    {
        move = playerInput.Player.Move.ReadValue<Vector2>().normalized;

        if (move == Vector2.zero)
        {
            playerAnimation.SetMovingAnimation(false);
            return;
        }
        playerAnimation.SetMovingAnimation(true);
        playerAnimation.SetMoveAnimation(move);
    }
    void OnDisable()
    {
        playerInput.Disable();
    }

}
