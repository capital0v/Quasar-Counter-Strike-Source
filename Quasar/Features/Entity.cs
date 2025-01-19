using System.Numerics;

namespace Quasar.Features
{
    internal class Entity
    {
        public IntPtr address { get; set; }

        public Vector3 position { get; set; }

        public int team { get; set; }

        public float health { get; set; }
        public float distance { get; set; }
    }
}
