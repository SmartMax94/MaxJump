using Assets.Scripts;
using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject splitPrefab;
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;

    public Platform CurrentPlatform;
        public  void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
       Rigidbody.velocity = Vector3.zero;
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject newsplit = Instantiate (splitPrefab, new Vector3 (transform.position.x, other.transform.position.y + 0.30f, transform.position.z), transform.rotation);
        newsplit.transform.localScale = Vector3.one * UnityEngine.Random.Range (0.8f, 1.2f);
        newsplit.transform.parent = other.transform;
    }
}
