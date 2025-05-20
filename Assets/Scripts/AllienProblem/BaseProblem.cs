using System.Collections.Generic;
using UnityEngine;

namespace AllienProblem
{
    public abstract class BaseProblem : MonoBehaviour
    {
        [Header("Allien Problem")]
        [SerializeField] protected int NumberAlliens = 50;
        [SerializeField] protected int NumberBodyParts = 50;

        protected List<Allien> allAlliens = new List<Allien>();

        protected abstract void Start();

        protected List<Vector3> GetBodyPartPositions()
        {
            List<Vector3> bodyPartPositions = new List<Vector3>();

            for (int i = 0; i < NumberBodyParts; i++)
            {
                bodyPartPositions.Add(new Vector3());
            }

            return bodyPartPositions;
        }
    }
}
