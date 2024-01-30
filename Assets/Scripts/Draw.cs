using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class Draw : MonoBehaviour
{
  public bool draw;
  public GameObject landmarkParent;
  public int landMarkIndex;
  public float zPos;

  //LineRenderer allow to draw a line using an array of points
  //we will use the position of the hand and we will add a new point to the line
  //check the documentation for exploring the properties of LineRenderer
  //https://docs.unity3d.com/Manual/class-LineRenderer.html
  private LineRenderer _lineRenderer;

  //The list of points that we will update at each frame
  private readonly Queue<Vector3> _points = new Queue<Vector3>();

  private void Start()
  {
    //Gets the line renderer component that is in the same Game Object
    _lineRenderer = gameObject.GetComponent<LineRenderer>();

    //Assigns a material and modifies the properties
    _lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
    _lineRenderer.widthMultiplier = 1.0f;
    _lineRenderer.positionCount = 0;
  }

  private void Update()
  {
    // We draw in the screen only if the draw variable is true.
    // it can be changed when we want to stop drawing
    if (draw && landmarkParent.activeSelf)
    {
      //Adds the current position of the landmark assigned in the inspector to the line points list
      //We can choose any landmark to paint
      Vector3 pos = landmarkParent.transform.GetChild(0).GetChild(0).GetChild(landMarkIndex).position;
      _points.Enqueue(new Vector3(pos.x,pos.y, zPos));
      _lineRenderer.positionCount++;
      _lineRenderer.SetPositions(_points.ToArray());
    }
  }
}
