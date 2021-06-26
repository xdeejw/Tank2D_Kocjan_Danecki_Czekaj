using UnityEngine;


/// Siła odbicia od przeciwnika

[RequireComponent(typeof(BoxCollider2D))]
public class BounceSurface : MonoBehaviour
{

    [Tooltip("The strength of the force added to the ball after bouncing off the surface.")]
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Ball ball = collision.gameObject.GetComponent<Ball>();


        if (ball != null)
        {

            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }

}
