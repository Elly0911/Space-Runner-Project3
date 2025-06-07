using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    private GameObject Player;
    public AudioClip collisionSound;
    private bool hasCollided = false; // Prevent multiple collisions

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player" && !hasCollided)
        {
            hasCollided = true;
            
            // Play the collision sound if it's assigned
            if (collisionSound != null)
            {
                // Method 1: Using AudioSource.PlayClipAtPoint (recommended)
                AudioSource.PlayClipAtPoint(collisionSound, transform.position, 1.0f);
                
                // Method 2: Alternative - Create a temporary AudioSource
                // GameObject tempAudio = new GameObject("TempAudio");
                // AudioSource audioSource = tempAudio.AddComponent<AudioSource>();
                // audioSource.clip = collisionSound;
                // audioSource.Play();
                // Destroy(tempAudio, collisionSound.length);
            }
            
            // Add a small delay before destroying the player to ensure sound plays
            StartCoroutine(DestroyPlayerAfterSound());
        }
    }
    
    private IEnumerator DestroyPlayerAfterSound()
    {
        // Wait a short moment to ensure the sound starts playing
        yield return new WaitForSeconds(0.1f);
        
        if (Player != null)
        {
            Destroy(Player.gameObject);
        }
    }
}