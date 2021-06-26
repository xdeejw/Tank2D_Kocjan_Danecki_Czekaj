using UnityEngine;
using UnityEngine.EventSystems;


/// Uruchamia dodanie punktu gdy piłka wpadnie w strefę

[RequireComponent(typeof(BoxCollider2D))]
public class ScoringZone : MonoBehaviour
{

    /// Zdarzenie gdy gracz trafi w strefę

    [Tooltip("The event triggered when a player scores.")]
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        Ball ball = collision.gameObject.GetComponent<Ball>();


        if (ball != null)
        {

            BaseEventData eventData = new BaseEventData(EventSystem.current);
            eventData.selectedObject = this.gameObject;
            this.scoreTrigger.Invoke(eventData);
        }
    }

}
