using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  public float speed = 10f;

  private Transform target;
  private int waypointIndex = 1;

  private void Start() {
    target = Waypoints.waypoints[0];
  }

  private void Update() {
    Vector3 movementDirection = target.position - transform.position;
    transform.Translate(movementDirection.normalized * speed * Time.deltaTime, Space.World);

    if (Vector3.Distance(transform.position, target.position) <= 0.2f && waypointIndex < Waypoints.waypoints.Length) {
      target = Waypoints.waypoints[waypointIndex];
      ++waypointIndex;
    }
  }
}
