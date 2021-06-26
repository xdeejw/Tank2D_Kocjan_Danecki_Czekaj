using UnityEngine;


/// Skrypt od poruszania się przeciwnika


public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        // Sprawdzenie czy piłka porusza się w kierunku czołgu lub przeciwko

        if (this.ball.velocity.x > 0.0f)
        {
            // Sledzi pozycję piłki i przesuwa się w jej kierunku
            if (this.ball.position.y > _rigidbody.position.y) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            } else if (this.ball.position.y < _rigidbody.position.y) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }
        }
        else
        {
            // Wrócenie do pozycji 0 i oczekiwanie na poruszenie się ponowne krązka w kierunku
            // czołgu kierowanego przez komputer
            if (_rigidbody.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            } else if (_rigidbody.position.y < 0.0f) {
                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }

}
