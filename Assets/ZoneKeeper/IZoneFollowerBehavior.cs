using UnityEngine;

namespace Assets.ZoneKeeper
{
    interface IZoneFollowerBehavior
    {
        void AwayFromZone(Vector3 zonePosition, ZoneFollower me);
    }
}