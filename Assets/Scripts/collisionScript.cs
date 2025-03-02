using UnityEngine;

public class collisionScript : MonoBehaviour
{
    public scr movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log("Collision Occured. Player Stopped");
            FindFirstObjectByType<GameManager>().EndGame();
        }
    }
}
