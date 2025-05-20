using System.Collections.Generic;
using UnityEngine;

namespace AllienProblem
{
    public class Allien
    {
        public List<Vector3> eyePositions;
        public List<Vector3> legPositions;
        public List<Vector3> armPositions;

        public Allien()
        {

        }

        public void SetEyePosition(List<Vector3> positions)
        {
            eyePositions = positions;
        }

        public void SetLegPosition(List<Vector3> positions)
        {
            legPositions = positions;
        }

        public void SetArmPosition(List<Vector3> positions)
        {
            armPositions = positions;
        }
    }
}
