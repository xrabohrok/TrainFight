using UnityEngine;

namespace Assets.Code.ZoneKeeper
{

    //Zone moving state machine should go here
    public class ZoneFollower : MonoBehaviour
    {

        public GameObject CurrentZone;
        public float DistanceVariations = 1f;

        private Zone _attachedZone;
        private IZoneFollowerBehavior _behaviors;

        // Use this for initialization
        public void Start ()
        {
            _attachedZone = CurrentZone.GetComponent<Zone>();          
            _behaviors = GetComponent<IZoneFollowerBehavior>();
        }

        public void SetHome(Zone newZone)
        {
            if (newZone.JoinZone(this) != null)
            {
                _attachedZone = newZone;
            }
        }
	
        public void Update ()
        {
            var here = this.gameObject.transform.position;
            var destination = _attachedZone.gameObject.transform.position;
            var distance = Vector3.Distance(here, destination);
            if (distance > DistanceVariations)
            {
                var lookAtPost = new Vector3(destination.x, here.y, destination.z);
                _behaviors.AwayFromZone(lookAtPost, this);
            }
        }
    }
}
