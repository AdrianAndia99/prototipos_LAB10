using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private GameObject _particlePrefab;
    [SerializeField] private ParticleConfigSO _particleConfig;

    private List<Particle> _particles = new List<Particle>();
    private TypeParticle _particleType;
    private float _spawnTimer;
    void Start()
    {
        _particleType = TypeParticle.GetParticleType(_particleConfig);
        SpawnMultipleParticles(20000);
    }
    void Update()
    {
        HandleParticleSpawning();
        UpdateActiveParticles();
    }

    private void HandleParticleSpawning()
    {
        _spawnTimer += Time.deltaTime;
        float spawnInterval = 1f / _particleConfig.spawnRate;

        if (_spawnTimer >= spawnInterval)
        {
            SpawnParticle();
            _spawnTimer = 0f;
        }
    }
    private void SpawnParticle()
    {
        Vector3 spawnPos = transform.position + new Vector3(
            Random.Range(-_particleConfig.spawnRange.x, _particleConfig.spawnRange.x),
            Random.Range(-_particleConfig.spawnRange.y, _particleConfig.spawnRange.y),
            Random.Range(-_particleConfig.spawnRange.z, _particleConfig.spawnRange.z));

        Vector3 velocity = Random.insideUnitSphere.normalized * _particleType.Speed;
        float lifetime = _particleConfig.lifetime;

        GameObject particleGO = Instantiate(_particlePrefab, spawnPos, Quaternion.identity);

        Renderer renderer = particleGO.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material = _particleType.Material;
            renderer.material.color = _particleConfig.color;
            particleGO.transform.localScale = Vector3.one * _particleType.Size;
        }

        Particle newParticle = new Particle(particleGO, velocity, lifetime, _particleType);
        _particles.Add(newParticle);
    }
    private void UpdateActiveParticles()
    {
        for (int i = _particles.Count - 1; i >= 0; i--)
        {
            if (!_particles[i].Actualization(Time.deltaTime))
            {
                _particles[i].DestroyParticle();
                _particles.RemoveAt(i);
            }
        }
    }

    private void SpawnMultipleParticles(int count)
    {
        for (int i = 0; i < count; i++)
        {
            SpawnParticle();
        }
    }
}