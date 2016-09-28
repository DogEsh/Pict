using UnityEngine;
using System.Collections;
namespace Assets
{
    public class Txt : MonoBehaviour
    {
        public GameObject MinX;
        public GameObject MaxX;
        public GameObject MinY;
        public GameObject MaxY;


        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Coord c = gameObject.transform.parent.GetComponentInChildren<Coord>();
            MaxX.GetComponent<TextMesh>().text = c.MaxX.ToString();
            MinX.GetComponent<TextMesh>().text = c.MinX.ToString();
            MaxY.GetComponent<TextMesh>().text = c.MaxY.ToString();
            MinY.GetComponent<TextMesh>().text = c.MinY.ToString();
        }
    }

}
