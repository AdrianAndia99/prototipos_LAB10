using System.Collections.Generic;
using UnityEngine;

public class TypeParticle : MonoBehaviour
{
    private Material Material;
    private Color Color;
    private float Speed;
    private float Size;

    private static readonly List<TypeParticle> Particle = new List<TypeParticle>();
    private TypeParticle(Material material, Color color, float speed, float size)
    {
        Material = material;
        Color = color;
        Speed = speed;
        Size = size;
    }
    public static TypeParticle GetParticleType(Material material, Color color, float speed, float size)
    {
        for (int i = 0; i < Particle.Count; i++)
        {
            TypeParticle instance = Particle[i];
            if (instance.Material == material && instance.Color == color && instance.Speed == speed && instance.Size == size)
            {
                return instance;
            }
        }

        TypeParticle newType = new TypeParticle(material, color, speed, size);
        Particle.Add(newType);
        return newType;
    }
}
