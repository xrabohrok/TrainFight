using Assets.Code.ZoneKeeper;
using UnityEngine;

namespace Assets.Code.Examples
{
    [RequireComponent(typeof(CharacterController))]
    public class ExampleZoneBehavior : MonoBehaviour, IZoneFollowerBehavior
    {
        private CharacterController _mover;
        private float _baseSpeed = 1f;

        public void Start()
        {
            _mover = this.GetComponent<CharacterController>();
        }
        public void AwayFromZone(Vector3 zonePosition, ZoneFollower me)
        {
            me.gameObject.transform.LookAt(zonePosition, Vector3.up);
            _mover.Move((zonePosition - me.gameObject.transform.position).normalized * _baseSpeed);
        }
    }
}