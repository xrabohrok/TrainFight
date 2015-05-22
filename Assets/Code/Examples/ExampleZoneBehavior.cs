using Assets.Code.ZoneKeeper;
using UnityEngine;

namespace Assets.Code.Examples
{
    public class ExampleZoneBehavior : MonoBehaviour, IZoneFollowerBehavior
    {
        private CharacterController _mover;
        private Vector3 baseSpeed = new Vector3(1,0,0);

        public void Start()
        {
            _mover = this.GetComponent<CharacterController>();
        }
        public void AwayFromZone(Vector3 zonePosition, ZoneFollower me)
        {
            Debug.Log("Behavior Activated");
            me.gameObject.transform.LookAt(zonePosition, Vector3.up);
            _mover.Move(baseSpeed);
        }
    }
}