using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float m_DampTime = 0.2f;                 // Approximate time for the camera to refocus.
    public float m_ScreenEdgeBuffer = 4f;           // Space between the top/bottom most target and the screen edge.
    public float m_MinSize = 6.5f;                  // The smallest orthographic size the camera can be.
    [HideInInspector] public Transform[] m_Targets; // All the targets the camera needs to encompass.


    private Camera m_Camera;                        // Used for referencing the camera.
    private float m_ZoomSpeed;                      // Reference speed for the smooth damping of the orthographic size.
    private Vector3 m_MoveVelocity;                 // Reference velocity for the smooth damping of the position.
    private Vector3 m_DesiredPosition;              // The position the camera is moving towards.



    void Awake()
    {
        m_Camera = GetComponent<Camera>();
    }
    private void FixedUpdate ()
    {
        // Move the camera towards a desired position.
        Move ();

        // Change the size of the camera based.
       // Zoom ();
    }
    void Move()
    {
        // Find the average position of the targets.
        //FindAveragePosition ();
        // Smoothly transition to that position.
        transform.position = Vector3.SmoothDamp(transform.position, m_DesiredPosition, ref m_MoveVelocity, m_DampTime);
    }
    // private void Zoom ()
    // {
    //     // Find the required size based on the desired position and smoothly transition to that size.
    //     float requiredSize = FindRequiredSize();
    //     m_Camera.orthographicSize = Mathf.SmoothDamp (m_Camera.orthographicSize, requiredSize, ref m_ZoomSpeed, m_DampTime);
    // }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
