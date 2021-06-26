using UnityEngine;




[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour

{

    /// Podstawowa prędkość piłki (rakiety)

    [Tooltip("The base speed of the ball.")]
    public float speed = 200.0f;


    /// Rigibody podpięte z piłką

    private Rigidbody2D _rigidbody;

    private void Awake()
    {

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        //reset do domyślnego położenia rakiety
        _rigidbody.velocity = Vector2.zero;
        _rigidbody.position = Vector2.zero;
    }


    public void AddStartingForce()
    {
        
            //Losowaie po której stronie zaczyna się gra
            float x = Random.value < 0.5f ? -1.0f : 1.0f;


            float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f)
                                          : Random.Range(0.5f, 1.0f);
        
            // Przypisanie siły do rakiety przez *
            Vector2 direction = new Vector2(x, y);
            _rigidbody.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        
            _rigidbody.AddForce(force);
        
    }
}

