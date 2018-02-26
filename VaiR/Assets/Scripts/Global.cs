using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {
	
		public static int count = 0;
        public static string[] currentScenario;
		public static string mode;
        
        public static void setScenario(int id) {
        switch (id)
        {
            case 0:
                currentScenario = new string[]{ "battery_guard", "electric_hydraulic_pumps", "landing_gear", "grd_power", "light_set", "overheat_dtc_1", "overheat_dtc_2", "overheat_test", "overheat_test", "master_fire_warn", "ext_test", "detector_select_switches", "cargo_fire_test", "master_fire_warn", "apu_start", "apu_gen_bus_2", "apu_gen_bus_3" };
                break;
            default:
                print("Incorrect parameter");
                break;

        }
    }
}
