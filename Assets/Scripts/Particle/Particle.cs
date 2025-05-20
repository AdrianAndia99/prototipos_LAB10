using UnityEngine;

public class Particle : MonoBehaviour
{
    private Vector3 Position;
    private Vector3 Velocity;
    private float Lifetime;

    public Particle(Vector3 position, Vector3 velocity, float lifetime)
    {
        Position = position;
        Velocity = velocity;
        Lifetime = lifetime;
    }
}