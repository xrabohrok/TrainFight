using System.Collections.Generic;
using UnityEngine;

namespace Assets.Code.ZoneKeeper
{
    public class Zone : MonoBehaviour
    {
        public List<Zone> Neighbors;
        public List<ZoneFollower> Guards;
        public int MaxOccupants = 1;



        // Use this for initialization
        public void Start () {
	        
        }
	
        // Update is called once per frame
        public void Update () {
	
        }

        public Vector3? WhereAmI(ZoneFollower immigrant)
        {
            if (Guards.Count < MaxOccupants)
            {
                Guards.Add(immigrant);

                //TODO: make this a derived location instead
                return this.gameObject.transform.position;
            }
            return null;
        }
    }
}
