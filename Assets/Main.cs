using UnityEngine;
using System.Collections;
namespace Assets
{
    public class Main : MonoBehaviour
    {

        const string _linePrefPath = "Line";
        Line _linePref;
        Line _line;
        Coord _coord;
        // Use this for initialization
        void Start()
        {
            _linePref = Resources.Load<Line>(_linePrefPath);
            GameObject inst = Instantiate(_linePref.gameObject);
            inst.transform.parent = gameObject.transform;
            _line = inst.GetComponent<Line>();
            _coord = gameObject.GetComponentInChildren<Coord>();
        }

        // Update is called once per frame
        void Update()
        {
            _line.SetCoord(_coord);
        }
    }

}
