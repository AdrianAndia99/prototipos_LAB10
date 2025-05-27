using UnityEngine;

public class Particle
{
    private GameObject _gameObject;
    private Vector3 _velocity;
    private float _lifetime;
    private float _age;
    private TypeParticle _typeParticle;

    public Particle(GameObject gameObject, Vector3 velocity, float lifetime, TypeParticle typeParticle)
    {
        _gameObject = gameObject;
        _velocity = velocity;
        _lifetime = lifetime;
        _typeParticle = typeParticle;
        _age = 0f;
    }

    public bool Actualization(float deltaTime)
    {
        _age += deltaTime;
        _gameObject.transform.position += _velocity * deltaTime;
        return _age < _lifetime;
    }

    public void DestroyParticle()
    {
        GameObject.Destroy(_gameObject);
    }
}