using System.Numerics;

namespace Quasar.Scripts.Features
{
    internal class Entity
    {
        public nint Address { get; set; }
        public Vector3 Position { get; set; }
        public int Health { get; set; }
        public float Distance { get; set; }
        public int Team { get; set; }

    }
}
