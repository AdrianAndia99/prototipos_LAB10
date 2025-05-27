using UnityEngine;

[CreateAssetMenu(fileName = "ParticleConfig", menuName = "Particles/New Config")]
public class ParticleConfigSO : ScriptableObject
{
    public Material material;
    public Color color = Color.white;
    [Range(0.1f, 2f)] public float size = 0.5f;

    [Range(1f, 20f)] public float speed = 5f;
    public Vector3 spawnRange = Vector3.one;

    [Range(0.1f, 10f)] public float spawnRate = 1f;
    [Range(0.1f, 10f)] public float lifetime = 2f;
}