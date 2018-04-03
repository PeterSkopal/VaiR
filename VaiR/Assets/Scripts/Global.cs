using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Global : MonoBehaviour
{
	
	public static int count = 0;
	public static int incorrectClickCounter = 0;
	public static string[,] currentScenario;
	public static string mode;
	public Text buttonClickedText;

	public static void setScenario (int id)
	{
		switch (id) {
		case 0:
			currentScenario = new string[,] {
				{"battery_guard", "Next: BATTERY switch Guard closed"},
				{"electric_hydraulic_pumps", "Next: ELECTRIC HYDRAULIC PUMPS switches OFF"},
				{"landing_gear", "Next: LANDING GEAR lever DN"},
				{"grd_power","Next: GRD POWER switch – ON"},
				{"light_set","Next: LIGHT SET"},
				{"overheat_dtc_1","Next: OVERHEAT DETECTOR switches 1 – NORMAL"},
				{"overheat_dtc_2","Next: OVERHEAT DETECTOR switches 2 – NORMAL"},
				{"overheat_test","Next: TEST switch – Hold to FAULT/INOP"},
				{"overheat_test","Next: TEST switch – Hold to OVHT/FIRE"},
				{"master_fire_warn","Next: Master FIRE WARN light – Push"},
				{"ext_test","Next: EXTINGUISHER TEST switch – Check"},
				{"detector_select_switches","Next: DETECTOR SELECT switches – NORM"},
				{"cargo_fire_test","Next: TEST switch – Push"},
				{"master_fire_warn","Next: Master FIRE WARN light – Push"},
				{"apu_start","Next: APU – Start if needed."},
				{"apu_gen_bus_2","Next: APU GENERATOR bus switches 2 - ON"},
				{"apu_gen_bus_3}","Next: APU GENERATOR bus switches 3 - ON"}};
			break;
		default:
			print ("Incorrect parameter");
			break;

		}

	}
}
