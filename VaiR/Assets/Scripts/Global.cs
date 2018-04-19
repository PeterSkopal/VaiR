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
				{"battery_guard", "button",
				"Next: BATTERY switch Guard closed"},

				{"electric_hydraulic_pumps", "button",
				"Next: ELECTRIC HYDRAULIC PUMPS switches OFF"},

				{"landing_gear", "button",
				"Next: LANDING GEAR lever DN"},

                {"landing_gear_lights", "gaze",
				"Verify green LANDING GEAR INDICATORS are lit"},

                {"landing_gear_lights", "gaze",
				"Verify red LANDING GEAR INDICATORS are unlit"},

                {"grd_power_available", "gaze",
				"Verify GRD POWER AVAILABLE light is lit."},

                {"grd_power",  "button",
				"Next: GRD POWER switch – ON"},

                // {"source_off_lights","Next: Verify that the SOURCE OFF lights are extinguished"},

                {"transfer_bus_lights", "gaze",
				"Verify that the TRANSFER BUS OFF lights are extinguished"},

                {"standby_pwr_off_lights", "gaze",
				"Verify that the STANDBY PWR OFF light is extinguished"},

				{"light_set", "button",
				"Next: LIGHT SET"},

				{"fire_1_apu", "gaze",
				"Verify that the engine No. 1, APU fire switches are in"},

				{"fire_2_apu", "gaze",
				"Verify that the engine No. 2, APU fire switches are in"},

				{"overheat_dtc_1", "button",
				"Next: OVERHEAT DETECTOR switches 1 – NORMAL"},

				{"overheat_dtc_2", "button",
				"Next: OVERHEAT DETECTOR switches 2 – NORMAL"},

				{"overheat_test", "button",
				"Next: TEST switch – Hold to FAULT/INOP"},

				{"master_caution", "gaze",
				"Verify that the MASTER CAUTION lights are illuminated"},

				{"overheat_test", "button",
				"Next: TEST switch – Hold to OVHT/FIRE"},

				{"master_fire_warn", "button",
				"Next: Master FIRE WARN light – Push"},

				{"ext_test", "button",
				"Next: EXTINGUISHER TEST switch – Check"},

				{"detector_select_switches", "button",
				"Next: DETECTOR SELECT switches – NORM"},

				{"cargo_fire_test", "button",
				"Next: TEST switch – Push"},

				{"master_fire_warn", "button",
				"Next: Master FIRE WARN light – Push"},

				{"apu_start", "button",
				"Next: APU – Start if needed."},

				{"apu_gen_bus_2", "button",
				"Next: APU GENERATOR bus switches 2 - ON"},

				{"apu_gen_bus_3", "button",
				"Next: APU GENERATOR bus switches 3 - ON"}};
			break;
		default:
			print ("Incorrect parameter");
			break;

		}

	}
}
