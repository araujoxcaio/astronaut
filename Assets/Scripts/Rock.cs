using UnityEngine;

public class Rock : MonoBehaviour
{
    Rigidbody2D rock;

    [SerializeField]
    private int verticalForce = 5;

    [SerializeField]
    private int horizontalForce = 2;

    private void Awake()
    {
        this.rock = this.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GoToRight();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            this.GoToLeft();
        }
    }

    private void GoToRight()
    {
        this.rock.AddForce(Vector2.up * this.verticalForce, ForceMode2D.Impulse);
        this.rock.AddForce(Vector2.right * this.horizontalForce, ForceMode2D.Impulse);
    }

    private void GoToLeft()
    {
        this.rock.AddForce(Vector2.up * this.verticalForce, ForceMode2D.Impulse);
        this.rock.AddForce(Vector2.left * this.horizontalForce, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destroy();
    }

    public void Destroy() {
        GameObject.Destroy(this.gameObject);
    }
}
