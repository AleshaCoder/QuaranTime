using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public AudioSource audioSourse1;
    public AudioSource audioSource2;
    private Vector2 movementInput;
    private Rigidbody2D RigidbodyPlayer;
    public GameObject Player;
    private  float x = 0;
    private void OnMouseDrag()
    {
        if (!(SpawnVirus.Time>0))
        {
            Player.GetComponent<Animator>().SetBool("Staying", true);
            audioSourse1.Stop();
            audioSource2.Stop();
        }
    }
    private void MoverPlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            x -= 3 * Time.deltaTime;
            if ((x<2.8f)&&(x>-2.8f))
            {
                Player.transform.position = new Vector2(x, -1.5f);
                Player.transform.rotation = new Quaternion(0, 0, 0.1f, 1);
            }
            else
            {
                x += 3 * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 3 * Time.deltaTime;
            if ((x < 2.8f) && (x > -2.8f))
            {
                Player.transform.position = new Vector2(x, -1.5f);
                Player.transform.rotation = new Quaternion(0, 0, -0.1f, 1);
            }
            else
            {
                x -= 3 * Time.deltaTime;
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Player.transform.rotation = new Quaternion(0, 0, 0, 1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Player.transform.rotation = new Quaternion(0, 0, 0, 1);
        }
    }

    private void Start()
    {
        Player.GetComponent<Animator>().speed = 5f;
        Player.GetComponent<Animator>().SetBool("Staying", false);
    }
    private void Update()
    {
        MoverPlayer();
    }
}
