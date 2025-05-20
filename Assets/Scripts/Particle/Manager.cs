using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject _particlePrefab;
    [SerializeField] private Material _particleMaterial;
    [SerializeField] private Color _particleColor = Color.white;
    [SerializeField, Range(1f, 20f)] private float _particleSpeed = 5f;
    [SerializeField, Range(0.1f, 2f)] private float _particleSize = 0.5f;
    [SerializeField, Range(0.1f, 10f)] private float _spawnRate = 1f;
    [SerializeField] private Vector3 _spawnRange = Vector3.one;

    private List<Particle> _particles = new List<Particle>();
    private TypeParticle _particleType;
    private float _spawnTimer;

    void Start()
    {
        _particleType = TypeParticle.GetParticleType(_particleMaterial, _particleColor, _particleSpeed, _particleSize);
    }
}