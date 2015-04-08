using UnityEngine;

namespace Assets.ZoneKeeper
{
    public class ExampleZoneBehavior : MonoBehaviour, IZoneFollowerBehavior
    {
        public virtual void AwayFromZone(Vector3 zonePosition, ZoneFollower me)
        {
            me.gameObject.transform.LookAt(zonePosition, Vector3.up);
        }
    }
}