using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    #region Fields
    private Vector2 movementInput;
    private Rigidbody2D RigidbodyPlayer;
    public GameObject Player;
    public Camera MainCamera;
    public static Sprite ItemPlayerSprite;
    public GameObject it1;
    private float angle = 180;
    #endregion


    #region Private Methods
    private void MoveCamera()
    {
        MainCamera.transform.position = new Vector3(Player.transform.position.x, MainCamera.transform.position.y, 80);
        MainCamera.transform.position = new Vector3(MainCamera.transform.position.x, Player.transform.position.y, 80);
    }
    private void MoverPlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movementInput.y += 10f;
            RigidbodyPlayer.velocity = Player.transform.up * 6f;
            Player.GetComponent<Animator>().SetBool("Staying", false);
            Player.GetComponent<Animator>().speed = 3f;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            movementInput.y = 0;
            RigidbodyPlayer.velocity = new Vector2(0, 0);
            Player.GetComponent<Animator>().SetBool("Staying", true);
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.Rotate(new Vector3(0, 0, angle) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.Rotate(new Vector3(0, 0, -angle) * Time.deltaTime);
        }
    }
    #endregion

    #region Unity Methods
    private void Start()
    {
        it1.GetComponent<SpriteRenderer>().sprite = ItemPlayerSprite;
        RigidbodyPlayer = Player.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        it1.GetComponent<SpriteRenderer>().sprite = ItemPlayerSprite;
    }
    private void LateUpdate()
    {
        MoveCamera();
    }
    private void Update()
    {
        MoverPlayer();
        RotatePlayer();
    }
    #endregion
}
