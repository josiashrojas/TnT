using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ARLocation.MapboxRoutes
{
    public class NewBehaviourScript : MonoBehaviour
    {

        public static RouteV2 getRoute()
        {
            RouteV2 route = new RouteV2();
            route.Points[0].Location = new Location(-33.03481, -71.59653, 0f);
            route.Points[0].Name = "inicio";
            route.Points[0].IsStep = true;
            route.Points[1].Location = new Location(-33.03484, -71.59666, 0f);
            route.Points[1].Name = "fin";
            route.Points[1].IsStep = true;
            return route;
        }
    }

}
