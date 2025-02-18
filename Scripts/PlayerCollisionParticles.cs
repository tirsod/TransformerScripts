using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns a particle system, stores it, then
/// moves it to the collision point with gameobjects tagged "Player".
/// </summary>
public class PlayerCollisionParticles : MonoBehaviour
{
    public GameObject particleToSpawn;
    private ParticleSystem myparticle;
    
    void Start()
    {
        GameObject partobj = Instantiate(particleToSpawn, transform.position, Quaternion.identity);
        myparticle = partobj.GetComponent<ParticleSystem>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Player") || other.transform.parent.CompareTag("Player"))
        {
            myparticle.transform.position = other.GetContact(0).point;
            myparticle.Emit(5);
        }
    }
}
