using UnityEngine;
using UnityEngine.AI;

public class playerController : MonoBehaviour {

    // Public svo ég get sett myndavelina og agentinn við scriptið ínní editornum
    public Camera cam;
    public NavMeshAgent agent;

	void Update () {
		// mouse button 0 er left-click
		if (Input.GetMouseButtonDown(0))
        {
			// Tekur púnktin sem músin er á skjánum og breytir því í "ray"
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
			
            if (Physics.Raycast(ray, out hit))
            {
				// Setur áfangastað agentsins á punktinn sem ray skotið lendir
                agent.SetDestination(hit.point);
            }
        }
	}
}
