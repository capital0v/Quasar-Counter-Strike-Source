using System.Numerics;

namespace Quasar.Features
{
    internal class Entity
    {
        public IntPtr Address { get; set; }
        public Vector3 Position { get; set; }
        public int Health { get; set; }
        public float Distance { get; set; }
        public int Team { get; set; }

    }
}
