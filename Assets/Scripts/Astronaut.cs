using UnityEngine;

public class Astronaut : MonoBehaviour
{
    Rigidbody2D physic;

    [SerializeField]
    private int verticalForce = 8;
    [SerializeField]
    private int horizontalForce = 2;

    private Director director;

    private Vector3 inicialPosition;

    private void Awake()
    {
        this.physic = this.GetComponent<Rigidbody2D>();
        this.inicialPosition = this.transform.position;
    }

    private void Start()
    {
        this.director = GameObject.FindObjectOfType<Director>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            this.GoToLeft();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            this.GoToRight();
        }
    }

    private void GoToRight() {
        this.physic.velocity = Vector2.zero;
        this.physic.AddForce(Vector2.up * this.verticalForce, ForceMode2D.Impulse);
        this.physic.AddForce(Vector2.right * this.horizontalForce, ForceMode2D.Impulse);
        this.physic.AddTorque(0.1f, ForceMode2D.Impulse);
    }

    private void GoToLeft()
    {
        this.physic.velocity = Vector2.zero;
        this.physic.AddForce(Vector2.up * this.verticalForce, ForceMode2D.Impulse);
        this.physic.AddForce(Vector2.left * this.horizontalForce, ForceMode2D.Impulse);
        this.physic.AddTorque(-0.1f, ForceMode2D.Impulse);

    }

    public void Restart() {
        this.transform.position = this.inicialPosition;
        this.physic.simulated = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Asteroids") { 
            this.physic.simulated = false;
            this.director.GameOver();
        }
    }
}
