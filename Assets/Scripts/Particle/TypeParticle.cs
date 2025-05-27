using UnityEngine;
using System.Collections.Generic;

public class TypeParticle
{
    public readonly Material Material;
    public readonly Color Color;
    public readonly float Speed;
    public readonly float Size;

    private static readonly List<TypeParticle> _particleTypes = new List<TypeParticle>();

    private TypeParticle(ParticleConfigSO config)
    {
        Material = config.material;
        Color = config.color;
        Speed = config.speed;
        Size = config.size;
    }

    public static TypeParticle GetParticleType(ParticleConfigSO config)
    {
        for (int i = 0; i < _particleTypes.Count; i++)
        {
            TypeParticle type = _particleTypes[i];
            if (type.Material == config.material && type.Color == config.color && type.Speed == config.speed && type.Size == config.size)
            {
                return type;
            }
        }

        TypeParticle newType = new TypeParticle(config);
        _particleTypes.Add(newType);
        return newType;
    }
}