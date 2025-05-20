using UnityEngine;

public class Particle : MonoBehaviour
{
    private Vector3 Position;
    private Vector3 Velocity;
    private float Lifetime;
    private float Age;
    private TypeParticle TypeParticle;
    public Particle(Vector3 position, Vector3 velocity, float lifetime, TypeParticle typeParticle)
    {
        Position = position;
        Velocity = velocity;
        Lifetime = lifetime;
        TypeParticle = typeParticle;
    }

    public bool Actualization(float deltaTime)
    {
        Age += deltaTime;
        Position += Velocity * deltaTime;
        return Age < Lifetime;
    }
}