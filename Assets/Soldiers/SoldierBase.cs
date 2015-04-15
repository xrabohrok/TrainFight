using Assets.Code.Clickable;
using UnityEngine;

namespace Assets.Soldiers
{
    public class SoldierBase : MonoBehaviour, IClickable {
        public string MasterName = "soldierMaster";

        private GameObject _master;
        private SoldierMaster _soldierMaster;

        public void Start()
        {
            FindMaster();
        }

        private void FindMaster()
        {
            _master = GameObject.Find(MasterName);
            _soldierMaster = _master.GetComponent<SoldierMaster>();
        }
	
        // Update is called once per frame
        public void Update () {
	
        }

        public void HoverReaction()
        {
        }

        public void ClickReaction()
        {
            _soldierMaster.ReportClick(this);
        }
    }
}
