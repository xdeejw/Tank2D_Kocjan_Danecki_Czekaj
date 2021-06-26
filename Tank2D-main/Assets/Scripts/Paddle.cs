using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
   
    // Szybkość poruszania góra dół

    public float speed = 8.0f;

    protected Rigidbody2D _rigidbody;

    private void Awake()
    {
       
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        //Zatrzymanie ruchu i restart pozycji 

        _rigidbody.velocity = Vector2.zero;
        _rigidbody.position = new Vector2(_rigidbody.position.x, 0.0f);
    }

}
